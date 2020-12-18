using eMuzickiStudio.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eMuzickiStudio.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KorisnickiPodaciPage : ContentPage
    {
        private readonly APIService _klijenti = new APIService("Klijenti");
        public KorisnickiPodaciPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var search = new KlijentiSearchRequest()
            {
                KorisnickoIme = GlobalKlijent.Username
            };
            var klijenti = await _klijenti.Get<List<Model.Klijenti>>(search);
            var klijent = klijenti[0];
            string emailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$";
            if (string.IsNullOrWhiteSpace(KorisnickoIme.Text) || string.IsNullOrWhiteSpace(Email.Text) || string.IsNullOrWhiteSpace(Telefon.Text))
            {
                await Application.Current.MainPage.DisplayAlert("Greska", "Sva polja su obavezna.", "OK");
                return;
            }
            if (!Regex.IsMatch(Telefon.Text, @"(06[0-9])([0-9]){3}([0-9]){3}$"))
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Broj telefona mora biti u formatu: 06X/XXX-XXX", "Ok");
                return;
            }
            if (Telefon.Text.Length < 9)
            {
                await Application.Current.MainPage.DisplayAlert("Greska", "Telefon mora imati minimalno 9 brojeva.", "OK");
                return;
            }

            if (KorisnickoIme.Text.Length < 4)
            {
                await Application.Current.MainPage.DisplayAlert("Greska", "Korisnicko ime mora imati minimalno 4 karaktera.", "OK");
                return;
            }
            if (Regex.IsMatch(Email.Text, emailPattern) == false)
            {
                await Application.Current.MainPage.DisplayAlert("Greska", "Unesite email u pravilnom formatu, npr test@hotmail.com.", "OK");
                return;
            }
            
            var lista = await _klijenti.Get<List<Model.Klijenti>>(null);
            foreach (var item in lista)
            {
                if (KorisnickoIme.Text == item.KorisnickoIme)
                {
                    await Application.Current.MainPage.DisplayAlert("Greska", "Korisnicko ime je zauzeto.", "OK");
                    return;
                }
            }
            var novi = new KlijentiInsertRequest()
            {
                KorisnickoIme = KorisnickoIme.Text,
                Email = Email.Text,
                Telefon = Telefon.Text,
                Ime = klijent.Ime,
                Prezime = klijent.Prezime,
                GradId = klijent.GradId,
                Slika = klijent.Slika,
                Password = APIService.Password,
                PasswordConfirmation = APIService.Password
            };
            await _klijenti.Update<Model.Klijenti>(klijent.KlijentId, novi);
            APIService.Username = KorisnickoIme.Text;
            await Application.Current.MainPage.DisplayAlert("Gotovo", "Podaci uspjesno promjenjeni, ulogujte se opet.", "OK");
            await Navigation.PushAsync(new LoginPage());

        }
    }
}