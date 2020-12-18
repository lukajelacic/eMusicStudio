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
    public class TerminiKlijentaViewModel
    {
        private readonly APIService _rezervacije = new APIService("RezervacijeGluveSobe");
        private readonly APIService _klijenti = new APIService("Klijenti");
        public TerminiKlijentaViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Model.RezervacijeGluveSobe> RezervacijeList { get; set; } = new ObservableCollection<Model.RezervacijeGluveSobe>();
        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            var search = new KlijentiSearchRequest()
            {
                KorisnickoIme = GlobalKlijent.Username
            };
            var klijenti = await _klijenti.Get<List<Model.Klijenti>>(search);
            var klijent = klijenti[0];
            var searchRequest = new RezervacijaGluveSobeSearchRequest()
            {
                KlijentId = klijent.KlijentId
            };
            var rezervacijeGluveSobe = await _rezervacije.Get<List<Model.RezervacijeGluveSobe>>(searchRequest);
            RezervacijeList.Clear();
            foreach(var item in rezervacijeGluveSobe)
            {
                RezervacijeList.Add(item);
            }
        }
    }
}
