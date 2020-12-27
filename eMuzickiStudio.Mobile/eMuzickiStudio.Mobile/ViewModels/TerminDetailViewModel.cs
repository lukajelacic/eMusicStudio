using eMuzickiStudio.Model.Requests;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace eMuzickiStudio.Mobile.ViewModels
{
    public class TerminDetailViewModel:BaseViewModel
    {
        private readonly APIService _termini = new APIService("Termini");
        private readonly APIService _rezervacijeGluveSobe = new APIService("RezervacijeGluveSobe");
        private readonly APIService _klijenti = new APIService("Klijenti");
        private readonly INavigation Navigation;

        public TerminDetailViewModel(INavigation navigation)
        {
            RezervisiTerminCommand = new Command(() => RezervisiTermin());
            this.Navigation = navigation;
        }
        public Model.Termini Termin { get; set; }
        public ICommand RezervisiTerminCommand { get; set; }
        public async void RezervisiTermin()
        {
            var search = new KlijentiSearchRequest()
            {
                KorisnickoIme = GlobalKlijent.Username
            };
            var klijenti = await _klijenti.Get<List<Model.Klijenti>>(search);
            var klijent = klijenti[0];
            var rezervacija = new Model.RezervacijeGluveSobe()
            {
                Datum = Termin.Datum,
                VrijemeDo = Termin.VrijemeDo,
                VrijemeOd = Termin.VrijemeOd,
                KlijentId = klijent.KlijentId
            };
            await _rezervacijeGluveSobe.Insert<Model.RezervacijeGluveSobe>(rezervacija);
            Termin.Aktivan = false;
            await _termini.Update<Model.Termini>(Termin.TerminId,Termin);
            await Application.Current.MainPage.DisplayAlert("Termin rezervisan", "Termin je uspjesno rezervisan", "OK");

            await Navigation.PopToRootAsync();
        }
    }
}
