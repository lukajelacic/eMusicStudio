using eMuzickiStudio.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eMuzickiStudio.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IspisMuzickeOpremePage : ContentPage
    {
        private MuzickaOpremaViewModel model = null;
        public IspisMuzickeOpremePage()
        {
            InitializeComponent();
            BindingContext = model = new MuzickaOpremaViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Model.MuzickaOprema;
            await Navigation.PushAsync(new OcjeniMuzickuOpremuPage(item));
        }
    }
}