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

namespace eMuzickiStudio.WinUI.Korisnici
{
    public partial class frmKorisnici : Form
    {
        private readonly APIService _korisnici = new APIService("Korisnici");
        public frmKorisnici()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new KorisniciSearchRequest()
            {
                KorisnickoIme = txtKorisnickoIme.Text
            };
            var result = await _korisnici.Get<List<Model.Korisnici>>(search);
            dgvKorisnici.AutoGenerateColumns = false;
            dgvKorisnici.DataSource = result;
            
        }

        private void dgvKorisnici_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvKorisnici.SelectedRows[0].Cells[0].Value;
            var frm = new frmKorisniciDetalji(int.Parse(id.ToString()));
            frm.Show();
            this.Close();
        }
    }
}
