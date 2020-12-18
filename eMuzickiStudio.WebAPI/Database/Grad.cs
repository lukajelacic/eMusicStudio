using System;
using System.Collections.Generic;

namespace eMuzickiStudio.WebAPI.Database
{
    public partial class Grad
    {
        public Grad()
        {
            Klijenti = new HashSet<Klijenti>();
        }

        public int GradId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Klijenti> Klijenti { get; set; }
    }
}
