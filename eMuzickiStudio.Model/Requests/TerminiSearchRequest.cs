using System;
using System.Collections.Generic;
using System.Text;

namespace eMuzickiStudio.Model.Requests
{
    public class TerminiSearchRequest
    {
        public DateTime? Datum { get; set; }
        public bool? Aktivan { get; set; }
    }
}
