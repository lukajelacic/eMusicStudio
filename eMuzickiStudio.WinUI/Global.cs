using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMuzickiStudio.WinUI
{
    public class Global
    {
        public static Model.Korisnici prijavljeniKorisnik { get; set; }
        public static int prijavljeniKorisnikId { get; set; }
    }
}
