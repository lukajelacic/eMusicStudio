using eMuzickiStudio.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace eMuzickiStudio.Mobile.ViewModels
{
    public class OcjeniMuzickuOpremuViewModel:BaseViewModel
    {
        private readonly APIService _klijenti = new APIService("Klijenti");
        private readonly APIService _ocjene = new APIService("Ocjene");
        public Model.MuzickaOprema MuzickaOprema { get; set; }
        int _ocjena = 0;
        public int Ocjena
        {
            get { return _ocjena; }
            set { SetProperty(ref _ocjena, value); }
        }
        public OcjeniMuzickuOpremuViewModel()
        {
            OcjeniCommand = new Command(() => Ocjeni());
        }
        public ICommand OcjeniCommand { get; set; }
        public async void Ocjeni()
        {
            var search = new KlijentiSearchRequest()
            {
                KorisnickoIme = GlobalKlijent.Username
            };
            var klijenti = await _klijenti.Get<List<Model.Klijenti>>(search);
            var klijent = klijenti[0];
            if (Ocjena < 1 || Ocjena > 5)
            {
                await Application.Current.MainPage.DisplayAlert("Greska", "Ocjena mora imati vrijednost izmedju 1 i 5.", "OK");
                return;
            }
            var ocjena = new OcjenaInsertRequest()
            {
                Ocjena = Ocjena,
                Datum = DateTime.Now,
                MuzickaOpremaId = MuzickaOprema.MuzickaOpremaId,
                KlijentId = klijent.KlijentId
            };
            await _ocjene.Insert<Model.Ocjene>(ocjena);
            await Application.Current.MainPage.DisplayAlert("Instrument ocjenjen", "Muzicki instrument je uspjesno ocjenjen.", "OK");
        }
    }
}
