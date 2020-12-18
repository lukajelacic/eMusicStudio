using eMuzickiStudio.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace eMuzickiStudio.Mobile.ViewModels
{
    public class GlobalKlijentViewModel
    {
        private readonly APIService _klijenti = new APIService("Klijenti");
        public ObservableCollection<Model.Klijenti> KlijentiList { get; set; } = new ObservableCollection<Model.Klijenti>();
        public async Task Init()
        {
            KlijentiSearchRequest searchRequest = new KlijentiSearchRequest()
            {
                KorisnickoIme = GlobalKlijent.Username
            };
            var list = await _klijenti.Get<List<Model.Klijenti>>(searchRequest);
            var klijent = list[0];
            KlijentiList.Clear();
            GlobalKlijent.prijavljeniKlijentId = klijent.KlijentId;
            GlobalKlijent.prijavljeniKlijent = klijent;
            KlijentiList.Add(klijent);
        
        }
    }
}
