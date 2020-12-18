using System;
using System.Collections.Generic;
using System.Text;

namespace eMuzickiStudio.Mobile.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        MuzickaOprema,
        Rezervacija,
        SlobodniTermini,
        RezervacijeKlijenta,
        GluvaSoba,
        Profil,
        Ocjena,
        LogOut
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
