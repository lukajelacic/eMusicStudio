using eMuzickiStudio.Mobile.Views;
using eMuzickiStudio.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eMuzickiStudio.Mobile.ViewModels
{
    public class RezervacijaViewModel:BaseViewModel
    {
        private readonly APIService _rezervacije = new APIService("Rezervacije");
        private readonly APIService _rezervacijaStavke = new APIService("RezervacijaStavke");
        private readonly APIService _klijenti = new APIService("Klijenti");
        private readonly APIService _muzickaOprema = new APIService("MuzickaOprema");
        private readonly INavigation Navigation;

        public RezervacijaViewModel(INavigation navigation)
        {
            ZakljuciRezervacijuCommand = new Command(() => ZakljuciRezervaciju());
            this.Navigation = navigation;
        }

        public readonly DateTime trenutno = DateTime.Now;
        DateTime _datumRezervacije = DateTime.Now;
        public DateTime DatumRezervacije
        {
            get { return _datumRezervacije; }
            set { SetProperty(ref _datumRezervacije, value); }
        }

        public ObservableCollection<MuzickaOpremaDetailViewModel> RezervacijaList { get; set; } = new ObservableCollection<MuzickaOpremaDetailViewModel>();
        public void Init()
        {
            RezervacijaList.Clear();
            foreach(var item in CartService.Cart.Values)
            {
                RezervacijaList.Add(item);
            }
        }
        public Command<MuzickaOpremaDetailViewModel> RemoveCommand
        {
            get
            {
                return new Command<MuzickaOpremaDetailViewModel>((Product) => {
                    RezervacijaList.Remove(Product);
                    CartService.Cart.Remove(Product.MuzickaOprema.MuzickaOpremaId);
                });
            }
        }
        public ICommand ZakljuciRezervacijuCommand { get; set; }
        public async  void ZakljuciRezervaciju()
        {
            if (RezervacijaList.Count == 0)
            {
                
                await Application.Current.MainPage.DisplayAlert("Greska", "Niste izabrali nijedan muzicki instrument.", "OK");
                return;
            }
            int cijena = 0;
            var list = await _rezervacije.Get<List<Model.Rezervacija>>(null);
            int brojRezervacije;
            if (list.Count==0)
            {
                brojRezervacije = 1;
            }
            else
            {
                brojRezervacije = list.Select(x => x.BrojRezervacije).Max() + 1;
            }
            
            var search = new KlijentiSearchRequest()
            {
                KorisnickoIme = GlobalKlijent.Username
            };
            var klijenti = await _klijenti.Get<List<Model.Klijenti>>(search);
            var klijent = klijenti[0];
            foreach (var item in RezervacijaList)
            {
                cijena += item.Kolicina * item.MuzickaOprema.Cijena;
            }
            foreach(var item in RezervacijaList)
            {
                if (item.Kolicina < 1)
                {
                    await Application.Current.MainPage.DisplayAlert("Greska", "Morate rezervisati minimalno jedan instrument.", "OK");
                    return;
                }
            }
            Model.Rezervacija rezervacija = new Model.Rezervacija()
            {
                BrojRezervacije = brojRezervacije,
                Datum = DateTime.Now,
                DatumRezervacije = DatumRezervacije,
                Otkazano = false,
                Status = false,
                KlijentId = klijent.KlijentId,
                Cijena = cijena,
                Arhivirana = false
            };
            var rez = await _rezervacije.Insert<Model.Rezervacija>(rezervacija);
            


            List<Model.RezervacijaStavke> rezervacijaStavke = new List<Model.RezervacijaStavke>();
            foreach(var item in RezervacijaList)
            {
                rezervacijaStavke.Add(new Model.RezervacijaStavke()
                {
                    RezervacijaId = rez.RezervacijaId,
                    MuzickaOpremaId = item.MuzickaOprema.MuzickaOpremaId,
                    Kolicina = item.Kolicina
                });
            }
            bool uspjesna = true;
            foreach(var item in rezervacijaStavke)
            {
                var oprema = await _muzickaOprema.GetById<Model.MuzickaOprema>(item.MuzickaOpremaId);
                if (item.Kolicina > oprema.NaStanju)
                {
                    await Application.Current.MainPage.DisplayAlert("Greska", "Nazalost nemamo toliko " + oprema.Naziv + " na stanju.", "OK");
                    uspjesna = false;
                    await _rezervacije.Delete(rez.RezervacijaId);
                    break;
                }
                else
                {
                    await _rezervacijaStavke.Insert<Model.RezervacijaStavke>(item);
                    oprema.NaStanju -= item.Kolicina;
                    await _muzickaOprema.Update<Model.MuzickaOprema>(oprema.MuzickaOpremaId, oprema);
                }
            }
            RezervacijaList.Clear();
            CartService.Cart.Clear();
            if (!uspjesna)
            {
                return;
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Operacija uspjesna", "Rezervacija je zakljucena, jos ostaje da platite." , "OK");
                await Navigation.PushAsync(new RezervacijaDetailPage(rez));
            }
        }
       
    }
}
