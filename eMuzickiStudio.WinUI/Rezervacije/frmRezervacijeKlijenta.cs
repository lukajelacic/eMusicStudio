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
    public partial class frmRezervacijeKlijenta : Form
    {
        private int? _id;
        private readonly APIService _rezervacije = new APIService("Rezervacije");
        public frmRezervacijeKlijenta(int? KlijentId)
        {
            InitializeComponent();
            _id = KlijentId;
        }

        private async void frmRezervacijeKlijenta_Load(object sender, EventArgs e)
        {
            var result = await _rezervacije.Get<List<Model.Rezervacija>>(new RezervacijeSearchRequest()
            {
                KlijentId = _id.Value
            });
           
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = result;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dataGridView1.SelectedRows[0].Cells[0].Value;
            var frm = new frmRezervacijeDetalji(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
