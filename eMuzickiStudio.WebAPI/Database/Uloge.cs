using System;
using System.Collections.Generic;

namespace eMuzickiStudio.WebAPI.Database
{
    public partial class Uloge
    {
        public Uloge()
        {
            Korisnici = new HashSet<Korisnici>();
        }
        
        public int UlogaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public virtual ICollection<Korisnici> Korisnici { get; set; }

    }
}
