using eMuzickiStudio.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eMuzickiStudio.Mobile.ViewModels
{
    public class MuzickaOpremaDetailViewModel:BaseViewModel
    {
        private readonly APIService _klijenti = new APIService("Klijenti");
       // private readonly APIService _ocjene = new APIService("Ocjene");
        private readonly APIService _preporuceniProizvodi = new APIService("SistemPreporuke");
        public MuzickaOpremaDetailViewModel()
        {
            PovecajKolicinuCommand = new Command(() => Kolicina += 1);
            SmanjiKolicinuCommand = new Command(() => Kolicina -= 1);
            RezervisiCommand = new Command(() => Rezervisi());
            //OcjeniCommand = new Command(() => Ocjeni());
            InitCommand = new Command(async () => await Init());
        }
        public Model.MuzickaOprema MuzickaOprema { get; set; }
        public ObservableCollection<Model.MuzickaOprema> MuzickaOpremaList { get; set; } = new ObservableCollection<Model.MuzickaOprema>();
        int _kolicina = 1;
        public int Kolicina
        {
            get { return _kolicina; }
            set { SetProperty(ref _kolicina, value); }
        }
        int _ocjena = 0;
        public int Ocjena
        {
            get { return _ocjena; }
            set { SetProperty(ref _ocjena, value); }
        }
        public ICommand PovecajKolicinuCommand { get; set; }
        public ICommand SmanjiKolicinuCommand { get; set; }
        public ICommand RezervisiCommand { get; set; }
        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            MuzickaOpremaList.Clear();
            var list = await _preporuceniProizvodi.Get<List<Model.MuzickaOprema>>(MuzickaOprema.MuzickaOpremaId);
            foreach(var item in list)
            {
                MuzickaOpremaList.Add(item);
            }
        }
       
        private void Rezervisi()
        {
            if (CartService.Cart.ContainsKey(MuzickaOprema.MuzickaOpremaId))
            {
                CartService.Cart.Remove(MuzickaOprema.MuzickaOpremaId);
            }
            CartService.Cart.Add(MuzickaOprema.MuzickaOpremaId, this);
        }
    }
}
