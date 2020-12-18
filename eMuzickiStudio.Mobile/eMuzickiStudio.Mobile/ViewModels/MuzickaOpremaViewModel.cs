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
    public class MuzickaOpremaViewModel:BaseViewModel
    {
        private readonly APIService _muzickaOprema = new APIService("MuzickaOprema");
        private readonly APIService _vrsta = new APIService("Vrsta");
        public MuzickaOpremaViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Model.MuzickaOprema> MuzickaOpremaList { get; set; } = new ObservableCollection<Model.MuzickaOprema>();
        public ObservableCollection<Model.Vrsta> VrstaList { get; set; } = new ObservableCollection<Model.Vrsta>();
        public ICommand InitCommand { get; set; }
        Model.Vrsta _selectedVrsta = null;
        public Model.Vrsta SelectedVrsta
        {
            get { return _selectedVrsta; }
            set 
            { 
                SetProperty(ref _selectedVrsta, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }

        public async Task Init()
        {
            if (VrstaList.Count == 0)
            {
                var vrsteList = await _vrsta.Get<List<Model.Vrsta>>(null);
                foreach (var item in vrsteList)
                {
                    VrstaList.Add(item);
                }
            }

            if (SelectedVrsta != null)
            {
                MuzickaOpremaSearchRequest search = new MuzickaOpremaSearchRequest()
                {
                    VrstaId = SelectedVrsta.VrstaId
                };
                var list = await _muzickaOprema.Get<List<Model.MuzickaOprema>>(search);
                MuzickaOpremaList.Clear();
                foreach (var item in list)
                {
                    MuzickaOpremaList.Add(item);
                }
            }
            else
            {
                var list = await _muzickaOprema.Get<List<Model.MuzickaOprema>>(null);
                MuzickaOpremaList.Clear();
                foreach (var item in list)
                {
                    MuzickaOpremaList.Add(item);
                }
            }
        } 
           
    }
}
