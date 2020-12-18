using System;
using System.Collections.Generic;
using System.Text;

namespace eMuzickiStudio.Model.Requests
{
    public class KlijentBanovanRequest
    {
        public int KlijentId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public int GradId { get; set; }
        public string Grad { get; set; }
        public byte[] Slika { get; set; }
        public bool Banovan { get; set; }
        public string LozinkaSalt { get; set; }
        public string LozinkaHash { get; set; }
    }
}
