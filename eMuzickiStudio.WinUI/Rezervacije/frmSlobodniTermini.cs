using eMuzickiStudio.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eMuzickiStudio.WinUI.Rezervacije
{
    public partial class frmSlobodniTermini : Form
    {
        private readonly APIService _termini = new APIService("Termini");
        public frmSlobodniTermini()
        {
            InitializeComponent();
        }

        private async void btnDodajTermin_Click(object sender, EventArgs e)
        {
            
            var termin = new TerminiInsertRequest()
            {
                Datum = dateTimePicker1.Value.Date,
                VrijemeOd = dateTimePicker3.Value.TimeOfDay,
                VrijemeDo = dateTimePicker2.Value.TimeOfDay,
                KorisnikId = Global.prijavljeniKorisnikId,
                Aktivan=true
            };
            await _termini.Insert<Model.Termini>(termin);
            MessageBox.Show("Termin uspjesno dodan.");
        }
    }
}
