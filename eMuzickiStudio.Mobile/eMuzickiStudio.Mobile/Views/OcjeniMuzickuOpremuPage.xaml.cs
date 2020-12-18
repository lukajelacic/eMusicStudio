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
    public partial class OcjeniMuzickuOpremuPage : ContentPage
    {
        private OcjeniMuzickuOpremuViewModel model = null;
        public OcjeniMuzickuOpremuPage(Model.MuzickaOprema muzickaOprema)
        {
            InitializeComponent();
            BindingContext = model = new OcjeniMuzickuOpremuViewModel()
            {
                MuzickaOprema = muzickaOprema
            };
        }
    }
}