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

namespace eMuzickiStudio.WinUI
{
    public partial class frmLogin : Form
    {
        APIService _service = new APIService("Grad");
        APIService _korisnici = new APIService("Korisnici");
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                APIService.Username = txtKorisnickoIme.Text;
                APIService.Password = txtPassword.Text;
                KorisniciSearchRequest search = new KorisniciSearchRequest()
                {
                    KorisnickoIme = txtKorisnickoIme.Text
                };
                var list = await _korisnici.Get<List<Model.Korisnici>>(search);
                var korisnik = list[0];
                Global.prijavljeniKorisnik = korisnik;
                Global.prijavljeniKorisnikId = korisnik.KorisnikId;
                await _service.Get<dynamic>(null);
                
                
                frmIndex frm = new frmIndex();
                frm.Show();
            }catch(Exception ex)
            {
                //MessageBox.Show(ex.Message, "Autentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
