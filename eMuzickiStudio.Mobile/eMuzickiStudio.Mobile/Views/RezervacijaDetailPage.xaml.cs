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
    public partial class RezervacijaDetailPage : ContentPage
    {
        private RezervacijaDetailViewModel model = null;
        private Model.Rezervacija rez = null;
        public RezervacijaDetailPage(Model.Rezervacija rezervacija)
        {
            InitializeComponent();
            BindingContext = model = new RezervacijaDetailViewModel(this.Navigation)
            {
                Rezervacija = rezervacija
            };
            rez = rezervacija;
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
            if (rez.Status == true)
            {
                Naplati.IsVisible = false;
               
            }
            if (rez.Otkazano == true || rez.DatumRezervacije.Date<DateTime.Now.Date)
            {
                Otkazi.IsVisible = false;
                Naplati.IsVisible = false;
            }
            
        }
    }
}