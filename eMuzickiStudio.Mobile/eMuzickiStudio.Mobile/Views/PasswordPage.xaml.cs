using eMuzickiStudio.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eMuzickiStudio.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PasswordPage : ContentPage
    {
        private readonly APIService _klijenti = new APIService("Klijenti");
        public PasswordPage()
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
            if (string.IsNullOrWhiteSpace(OldPassword.Text) || string.IsNullOrWhiteSpace(NewPassword.Text) || string.IsNullOrWhiteSpace(ConfirmPassword.Text))
            {
                await Application.Current.MainPage.DisplayAlert("Greska", "Sva polja su obavezna", "OK");
                return;
            }
            if (OldPassword.Text != APIService.Password)
            {
                await Application.Current.MainPage.DisplayAlert("Pogresan password", "Unjeli ste pogresan trenutni password.", "OK");
                return;
            }
            else if (NewPassword.Text.Length < 4)
            {
                await Application.Current.MainPage.DisplayAlert("Greska", "Password mora imati minimalno 4 karaktera", "OK");
            }
            else if (NewPassword.Text != ConfirmPassword.Text)
            {
                await Application.Current.MainPage.DisplayAlert("Greska", "Passwordi se ne poklapaju.", "OK");
            }
            else if (NewPassword.Text == APIService.Password)
            {
                await Application.Current.MainPage.DisplayAlert("Identican password", "Unjeli ste  trenutni password, molim Vas unesite drugi password.", "OK");
                return;
            }
            else
            {
                KlijentiInsertRequest novi = new KlijentiInsertRequest()
                {
                    Ime = klijent.Ime,
                    Prezime = klijent.Prezime,
                    Email = klijent.Email,
                    Telefon = klijent.Telefon,
                    KorisnickoIme = klijent.KorisnickoIme,
                    GradId = klijent.GradId,
                    Slika = klijent.Slika,
                    Password = NewPassword.Text,
                    PasswordConfirmation = ConfirmPassword.Text
                };
                await _klijenti.Update<Model.Klijenti>(klijent.KlijentId, novi);
                await Application.Current.MainPage.DisplayAlert("Promjenjen password", "Password je uspjesno promjenjen, ulogujte se ponovo.", "OK");
                await Navigation.PushAsync(new LoginPage());
            }
        }
    }
}