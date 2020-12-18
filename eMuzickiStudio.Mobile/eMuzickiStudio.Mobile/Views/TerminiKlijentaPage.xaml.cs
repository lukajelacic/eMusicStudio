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
    public partial class TerminiKlijentaPage : ContentPage
    {
        private TerminiKlijentaViewModel model = null;
        public TerminiKlijentaPage()
        {
            InitializeComponent();
            BindingContext = model = new TerminiKlijentaViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}