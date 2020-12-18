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
    public partial class frmRezervacije : Form
    {
        private readonly APIService _rezervacije = new APIService("Rezervacije");
        public frmRezervacije()
        {
            InitializeComponent();
        }

        private async void btnPrikaziRezervacije_Click(object sender, EventArgs e)
        {
            var result =await _rezervacije.Get<List<Model.Rezervacija>>(new RezervacijeSearchRequest()
            {
                Status = false
            });
            var dgvRezultat = new List<Model.Requests.RezervacijaRezultat>();
            foreach (var item in result)
            {
                Model.Requests.RezervacijaRezultat temp = new Model.Requests.RezervacijaRezultat(item);
                dgvRezultat.Add(temp);
                temp = null;
            }
            dgvRezervacije1.AutoGenerateColumns = false;
            dgvRezervacije1.DataSource = dgvRezultat;
        }

        private void dgvRezervacije1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvRezervacije1.SelectedRows[0].Cells[0].Value;
            var frm = new frmRezervacijeDetalji(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
