using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eMuzickiStudio.Model.Requests
{
    public class MuzickaOpremaUpsertRequest
    {
        [Required(AllowEmptyStrings =false)]
        public string Naziv { get; set; }
        public int VrstaId { get; set; }
        [Range(0,double.MaxValue)]
        public decimal Ocjena { get; set; }
        [Range(0,50)]
        [Required]
        public int NaStanju { get; set; }
        public byte[] Slika { get; set; }
        [Required]
        [Range(0,double.MaxValue)]
        public int Cijena { get; set; }
    }
}
