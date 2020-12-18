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
    public partial class frmIspisSlobodnihTermina : Form
    {
        private readonly APIService _termini = new APIService("Termini");
        public frmIspisSlobodnihTermina()
        {
            InitializeComponent();
        }

        private async void frmIspisSlobodnihTermina_Load(object sender, EventArgs e)
        {
            var result = await _termini.Get<List<Model.Termini>>(null);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = result;

          
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var frm = new frmSlobodniTermini();
            frm.Show();
        }
    }
}
