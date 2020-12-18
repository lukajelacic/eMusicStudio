using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;
using Flurl;
using eMuzickiStudio.Model.Requests;

namespace eMuzickiStudio.WinUI.Klijenti
{
    public partial class frmKlijenti : Form
    {
        private readonly APIService _apiService = new APIService("Klijenti");
        public frmKlijenti()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new KlijentiSearchRequest()
            {
                Ime = txtPretraga.Text,
                Prezime = txtPrezime.Text
            };
            var result = await _apiService.Get<List<Model.Klijenti>>(search);
            dgvKlijenti.AutoGenerateColumns = false;
            dgvKlijenti.DataSource = result;

            
        }

        private void dgvKlijenti_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvKlijenti.SelectedRows[0].Cells[0].Value;
            var frm = new frmKlijentiDetalji(int.Parse(id.ToString()));
            frm.Show();
        }

       
    }
}
