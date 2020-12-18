using eMuzickiStudio.Mobile.Views;
using eMuzickiStudio.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eMuzickiStudio.Mobile.ViewModels
{
    public class RezervacijaDetailViewModel:BaseViewModel
    {
        private readonly APIService _rezervacijaStavke = new APIService("RezervacijaStavke");
        private readonly APIService _muzickaOprema = new APIService("MuzickaOprema");
        private readonly APIService _rezervacije = new APIService("Rezervacije");
        private readonly APIService _klijenti = new APIService("Klijenti");
        public Model.Rezervacija Rezervacija { get; set; }
        private readonly INavigation Navigation;
       
        public RezervacijaDetailViewModel(INavigation navigation)
        {
            InitCommand = new Command(async () => await Init());
            OtkaziRezervacijuCommand = new Command(() =>  OtkaziRezervaciju());
            NaplatiRezervacijuCommand = new Command(async () => await NaplatiRezervaciju());
            this.Navigation = navigation;
        }

        public ObservableCollection<Model.RezervacijaStavkeRezultat> RezervacijaStavkeList { get; set; } = new ObservableCollection<Model.RezervacijaStavkeRezultat>();
        public ICommand InitCommand { get; set; }
        public ICommand OtkaziRezervacijuCommand { get; set; }
        public ICommand NaplatiRezervacijuCommand { get; set; }
        decimal _cijena =0;
        public decimal Cijena
        {
            get { return _cijena; }
            set { SetProperty(ref _cijena, value); }
        }
        public async Task PozivPaymentaAsync()
        {
            var klijenti = await _klijenti.Get<List<Model.Klijenti>>(new KlijentiSearchRequest()
            {
                KorisnickoIme = GlobalKlijent.Username
            });
            var klijent = klijenti[0];
            await Navigation.PushAsync(new StripePaymentGatewayPage(Rezervacija.RezervacijaId, klijent.KlijentId));
            
        }
        public async Task NaplatiRezervaciju()
        {
            await PozivPaymentaAsync();
            //if (PozivPaymentaAsync().GetAwaiter().IsCompleted)
            //{
            //    Rezervacija.Status = true;
            //    await _rezervacije.Update<Model.Rezervacija>(Rezervacija.RezervacijaId, Rezervacija);
            //}
        }
        public async Task Init()
        {
            RezervacijaStavkeSearchRequest searchRequest = new RezervacijaStavkeSearchRequest()
            {
                RezervacijaId = Rezervacija.RezervacijaId
            };
            var list = await _rezervacijaStavke.Get<List<Model.RezervacijaStavke>>(searchRequest);
            List<Model.RezervacijaStavkeRezultat> rezultat = new List<Model.RezervacijaStavkeRezultat>();
            foreach (var item in list)
            {
                Model.RezervacijaStavkeRezultat temp = new Model.RezervacijaStavkeRezultat(item);
                rezultat.Add(temp);
                Cijena += temp.Cijena * temp.Kolicina;
                temp = null;
                
            }
            RezervacijaStavkeList.Clear();
            foreach(var item in rezultat)
            {
                RezervacijaStavkeList.Add(item);
            }
            
        }
        public async void OtkaziRezervaciju()
        {
            RezervacijaStavkeSearchRequest searchRequest = new RezervacijaStavkeSearchRequest()
            {
                RezervacijaId = Rezervacija.RezervacijaId
            };
            var list = await _rezervacijaStavke.Get<List<Model.RezervacijaStavke>>(searchRequest);
           
            if (Rezervacija.DatumRezervacije.Year == DateTime.Now.Year && Rezervacija.DatumRezervacije.Month==DateTime.Now.Month && Rezervacija.DatumRezervacije.Day==DateTime.Now.Day)
            {
                await Application.Current.MainPage.DisplayAlert("Nemoguce otkazivanje", "Nazalost zakasnili ste sa otkazivanjem rezervacije.", "OK");
            }
            else
            {
                Rezervacija.Otkazano = true;
                await _rezervacije.Update<Model.Rezervacija>(Rezervacija.RezervacijaId, Rezervacija);
                foreach(var item in list)
                {
                    var oprema = await _muzickaOprema.GetById<Model.MuzickaOprema>(item.MuzickaOpremaId);
                    oprema.NaStanju += item.Kolicina;
                    await _muzickaOprema.Update<Model.MuzickaOprema>(oprema.MuzickaOpremaId, oprema);
                }
                await Application.Current.MainPage.DisplayAlert("Rezervacija otkazana", "Rezervacija je uspjesno otkazana", "OK");
                await Navigation.PopToRootAsync();
            }
        }
       

    }
}
