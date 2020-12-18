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
    public partial class MuzickaOpremaDetailPage : ContentPage
    {
        private MuzickaOpremaDetailViewModel model = null;
        public MuzickaOpremaDetailPage(Model.MuzickaOprema muzickaOprema)
        {
            InitializeComponent();
            BindingContext = model = new MuzickaOpremaDetailViewModel()
            {
                MuzickaOprema = muzickaOprema
            };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Model.MuzickaOprema;
            await Navigation.PushAsync(new MuzickaOpremaDetailPage(item));
        }
    }
}