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
    public partial class TerminiPage : ContentPage
    {
        private TerminiViewModel model = null;
        public TerminiPage()
        {
            InitializeComponent();
            BindingContext = model = new TerminiViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Model.Termini;
            await Navigation.PushAsync(new TerminDetailPage(item));
        }

        private async void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            DateTime date = new DateTime();
            date = DatePicker.Date;
            await model.CalcDatum(date);
        }
    }
}