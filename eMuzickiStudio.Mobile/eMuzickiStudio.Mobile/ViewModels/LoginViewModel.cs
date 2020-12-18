using eMuzickiStudio.Mobile.Views;
using eMuzickiStudio.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eMuzickiStudio.Mobile.ViewModels
{
    public class LoginViewModel:BaseViewModel
    {
        private readonly APIService _service = new APIService("Klijenti");//grad
        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
        }
        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
        public ICommand LoginCommand { get; set; }
        async Task Login()
        {
            APIService.Username = Username;
            APIService.Password = Password;
            APIService.Context = "Klijenti";
            List<Model.Klijenti> klijenti = await _service.Get<List<Model.Klijenti>>(new KlijentiSearchRequest()
            {
                KorisnickoIme = APIService.Username
            });
            var klijent = klijenti[0];
            if (klijent.Banovan == true)
            {
                await Application.Current.MainPage.DisplayAlert("Vas profil je banovan", "Kontaktirajte muzicki studio da dobijete razlog bana.","Ok");
                return;
            }
            try
            {
                var response = await _service.Get<dynamic>(null);
                Application.Current.MainPage = new MainPage();
                //await _service.Get<dynamic>(null);
                //Application.Current.MainPage = new MainPage();
               
            }
            catch(Exception ex)
            {
               
            }
        }
     
    }
}
