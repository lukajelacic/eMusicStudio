using eMuzickiStudio.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eMuzickiStudio.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Browse:
                        MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;
                    case (int)MenuItemType.Profil:
                        MenuPages.Add(id, new NavigationPage(new KlijentProfilPageg()));
                        break;
                    case (int)MenuItemType.MuzickaOprema:
                        MenuPages.Add(id, new NavigationPage(new MuzickaOpremaPage()));
                        break;
                    case (int)MenuItemType.Rezervacija:
                        MenuPages.Add(id, new NavigationPage(new RezervacijaPage()));
                        break;
                    case (int)MenuItemType.SlobodniTermini:
                        MenuPages.Add(id, new NavigationPage(new TerminiPage()));
                        break;
                    case (int)MenuItemType.RezervacijeKlijenta:
                        MenuPages.Add(id, new NavigationPage(new RezervacijeKlijentaPage()));
                        break;
                    case (int)MenuItemType.GluvaSoba:
                        MenuPages.Add(id, new NavigationPage(new TerminiKlijentaPage()));
                        break;
                    case (int)MenuItemType.Ocjena:
                        MenuPages.Add(id, new NavigationPage(new IspisMuzickeOpremePage()));
                        break;
                    case (int)MenuItemType.LogOut:
                        MenuPages.Add(id, new NavigationPage(new LoginPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}