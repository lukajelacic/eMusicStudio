using System;
using System.Collections.Generic;
using System.Text;

namespace eMuzickiStudio.Model.Requests
{
    public class KlijentiSearchRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
    }
}
