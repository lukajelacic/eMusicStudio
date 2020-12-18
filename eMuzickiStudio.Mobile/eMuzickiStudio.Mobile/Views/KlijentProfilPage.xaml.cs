using eMuzickiStudio.Mobile.ViewModels;
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
    public partial class KlijentProfilPageg : ContentPage
    {
        private KlijentProfilViewModel model = null;
        public KlijentProfilPageg()
        {
            InitializeComponent();
            BindingContext = model = new KlijentProfilViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PasswordPage());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KorisnickiPodaciPage());
        }
    }
}