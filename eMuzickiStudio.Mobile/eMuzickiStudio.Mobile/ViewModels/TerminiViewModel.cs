using eMuzickiStudio.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eMuzickiStudio.Mobile.ViewModels
{
    public class TerminiViewModel:BaseViewModel
    {
        private readonly APIService _termini = new APIService("Termini");
        public TerminiViewModel()
        {
            InitCommand = new Command(async () => await Init());
            DatumCommand = new Command(async () => await CalcDatum(null));
        }
        public ObservableCollection<Model.Termini> TerminiList { get; set; } = new ObservableCollection<Model.Termini>();
        public ICommand InitCommand { get; set; }
        public ICommand DatumCommand { get; set; }
        public readonly DateTime trenutno = DateTime.Now;
        DateTime _datumRezervacije;
        public DateTime DatumRezervacije
        {
            get { return _datumRezervacije; }
            set { SetProperty(ref _datumRezervacije, value);}
        }
       
        public async Task Init()
        {
            var search = new TerminiSearchRequest()
            {
                Aktivan = true
            };
            var list = await _termini.Get<List<Model.Termini>>(search);
            TerminiList.Clear();
            foreach(var item in list)
            {
                TerminiList.Add(item);
            }
         
        }
        public async Task CalcDatum(DateTime? date)
        {
            if (!date.HasValue)
            {
                var list = await _termini.Get<List<Model.Termini>>(null);
                TerminiList.Clear();
                foreach (var item in list)
                {
                    TerminiList.Add(item);
                }
            }
            else
            {
                TerminiSearchRequest search = new TerminiSearchRequest();
                search.Datum = date;

                var list = await _termini.Get<IEnumerable<Model.Termini>>(search);

                TerminiList.Clear();
                foreach (var item in list)
                {

                    TerminiList.Add(item);
                }
            }
           
            if (TerminiList.Count == 0)
            {
                await Application.Current.MainPage.DisplayAlert("Poruka", "Nema dostupnih termina", "OK");
            }

        }
    }
}
