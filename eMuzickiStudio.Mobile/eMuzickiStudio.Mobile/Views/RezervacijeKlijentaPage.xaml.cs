﻿using eMuzickiStudio.Mobile.ViewModels;
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
    public partial class RezervacijeKlijentaPage : ContentPage
    {
        private RezervacijeKlijentaViewModel model = null;
        public RezervacijeKlijentaPage()
        {
            InitializeComponent();
            BindingContext = model = new RezervacijeKlijentaViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Model.Rezervacija;
            await Navigation.PushAsync(new RezervacijaDetailPage(item));
        }
    }
}