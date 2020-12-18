using System;
using System.Collections.Generic;
using System.Text;

namespace eMuzickiStudio.Model
{
    public class MuzickaOprema
    {
        public int MuzickaOpremaId { get; set; }
        public string Naziv { get; set; }
        public int VrstaId { get; set; }
        public int NaStanju { get; set; }
        public byte[] Slika { get; set; }
        public int Cijena { get; set; }
    }
}
