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
    public class RezervacijeKlijentaViewModel:BaseViewModel
    {
        private readonly APIService _rezervacije = new APIService("Rezervacije");
        private readonly APIService _klijenti = new APIService("Klijenti");
        public RezervacijeKlijentaViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Model.Rezervacija> RezervacijeList { get; set; } = new ObservableCollection<Model.Rezervacija>();
        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            var search = new KlijentiSearchRequest()
            {
                KorisnickoIme = GlobalKlijent.Username
            };
            var klijenti = await _klijenti.Get<List<Model.Klijenti>>(search);
            var klijent = klijenti[0];
            RezervacijeSearchRequest searchRequest = new RezervacijeSearchRequest()
            {
                KlijentId = klijent.KlijentId
            };
            var list = await _rezervacije.Get<List<Model.Rezervacija>>(searchRequest);
            RezervacijeList.Clear();
            foreach(var item in list)
            {
                RezervacijeList.Add(item);
            }
        }
    }
}
