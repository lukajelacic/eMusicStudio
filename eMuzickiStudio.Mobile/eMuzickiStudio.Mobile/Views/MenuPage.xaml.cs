using eMuzickiStudio.Mobile.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eMuzickiStudio.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Browse, Title="Browse" },
                new HomeMenuItem {Id = MenuItemType.Profil, Title="Korisnicki profil" },
                new HomeMenuItem {Id = MenuItemType.MuzickaOprema, Title="Muzicka oprema" },
                new HomeMenuItem {Id = MenuItemType.Rezervacija, Title="Trenutna rezervacija" },
                new HomeMenuItem {Id = MenuItemType.SlobodniTermini, Title="Slobodni termini" },
                new HomeMenuItem {Id = MenuItemType.RezervacijeKlijenta, Title="Vase rezervacije" },
                new HomeMenuItem {Id = MenuItemType.GluvaSoba, Title="Rezervacije gluve sobe" },
                new HomeMenuItem {Id = MenuItemType.Ocjena, Title="Ocjeni muzicku opremu" },
                new HomeMenuItem {Id = MenuItemType.LogOut, Title="Logout" }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}