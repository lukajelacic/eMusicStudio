using eMuzickiStudio.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eMuzickiStudio.Mobile.ViewModels
{
    public class KlijentProfilViewModel:BaseViewModel
    {
        private readonly APIService _klijenti = new APIService("Klijenti");
        public KlijentProfilViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        string _ime = string.Empty;
        public string Ime
        {
            get { return _ime; }
            set { SetProperty(ref _ime, value); }
        }
        string _prezime = string.Empty;
        public string Prezime
        {
            get { return _prezime; }
            set { SetProperty(ref _prezime, value); }
        }
        string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }
        string _telefon = string.Empty;
        public string Telefon
        {
            get { return _telefon; }
            set { SetProperty(ref _telefon, value); }
        }
        string _korisnickoIme = string.Empty;
        public string KorisnickoIme
        {
            get { return _korisnickoIme; }
            set { SetProperty(ref _korisnickoIme, value); }
        }
        public Model.Klijenti Klijent { get; set; } = new Model.Klijenti();
        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            var search = new KlijentiSearchRequest()
            {
                KorisnickoIme = GlobalKlijent.Username
            };
            var klijenti = await _klijenti.Get<List<Model.Klijenti>>(search);
            var klijent = klijenti[0];

            Klijent = klijent;
            Ime = klijent.Ime;
            Prezime = klijent.Prezime;
            Email = klijent.Email;
            Telefon = klijent.Telefon;
            KorisnickoIme = klijent.KorisnickoIme;
        }

    }
}
