using System;
using System.Collections.Generic;

namespace eMuzickiStudio.WebAPI.Database
{
    public partial class Ocjene
    {
        public int OcjenaId { get; set; }
        public DateTime Datum { get; set; }
        public int Ocjena { get; set; }
        public int KlijentId { get; set; }
        public int MuzickaOpremaId { get; set; }

        public virtual Klijenti Klijent { get; set; }
        public virtual MuzickaOprema MuzickaOprema { get; set; }
    }
}