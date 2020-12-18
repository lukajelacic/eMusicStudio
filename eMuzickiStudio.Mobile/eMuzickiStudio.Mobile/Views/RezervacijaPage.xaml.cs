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
    public partial class RezervacijaPage : ContentPage
    {
        private RezervacijaViewModel model = null;
        public RezervacijaPage()
        {
            InitializeComponent();
            BindingContext = model = new RezervacijaViewModel(this.Navigation);
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.Init();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var stavka = button.BindingContext as MuzickaOpremaDetailViewModel;
            var vm = BindingContext as RezervacijaViewModel;
            vm.RemoveCommand.Execute(stavka);
        }
    }
}