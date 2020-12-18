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
    public partial class TerminDetailPage : ContentPage
    {
        private TerminDetailViewModel model = null;
        public TerminDetailPage(Model.Termini termin)
        {
            InitializeComponent();
            BindingContext = model = new TerminDetailViewModel()
            {
                Termin = termin
            };
        }
    }
}