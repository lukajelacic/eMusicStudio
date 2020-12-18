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
    public partial class frmRezervacijeDetalji : Form
    {
        private readonly APIService _rezervacije = new APIService("Rezervacije");
        private readonly APIService _rezervacijeStavke = new APIService("RezervacijaStavke");
        private readonly APIService _muzickaOprema = new APIService("MuzickaOprema");

        private int _id;
        private decimal ukupnaCijena;
        public frmRezervacijeDetalji(int RezervacijaId)
        {
            InitializeComponent();
            _id = RezervacijaId;
        }

        private async void frmRezervacijeDetalji_Load(object sender, EventArgs e)
        {
            var rezervacija = await _rezervacije.GetById<Model.Rezervacija>(_id);
            
            var rezervacijaStavke = await _rezervacijeStavke.Get<List<Model.RezervacijaStavke>>(new RezervacijaStavkeSearchRequest()
            {
                RezervacijaId = _id
            }) ;
            foreach(var item in rezervacijaStavke)
            {
                ukupnaCijena += item.Kolicina * item.MuzickaOprema.Cijena;
            }
          
            txtUkupno.Text = ukupnaCijena + "KM";
            txtUkupno.ReadOnly = true;

            txtBrojRezervacije.Text = rezervacija.BrojRezervacije.ToString();
            txtBrojRezervacije.ReadOnly = true;

            txtDatumRezervacije.Text = rezervacija.DatumRezervacije.ToString("dd/MM/yyyy");
            txtDatumRezervacije.ReadOnly = true;

            txtOtkazana.Text = rezervacija.Otkazano.ToString();
            txtOtkazana.ReadOnly = true;

            txtPlacena.ReadOnly = true;
            if (rezervacija.Otkazano==true)
            {
                txtOtkazana.Text = "DA";
            }
            else
            {
                txtOtkazana.Text = "NE";
            }
            if (rezervacija.Status == true || rezervacija.DatumRezervacije.Date<DateTime.Now.Date)
            {
                btnOdobri.Visible = false;
            }
            else
            {
                btnOdobri.Visible = true;
            }
            if (rezervacija.Status == true)
            {
                txtPlacena.Text = "DA";
            }
            else
            {
                txtPlacena.Text = "NE";
            }
            var dgvRezultat = new List<Model.RezervacijaStavkeRezultat>();
            foreach(var item in rezervacijaStavke)
            {
                Model.RezervacijaStavkeRezultat temp = new Model.RezervacijaStavkeRezultat(item);
                dgvRezultat.Add(temp);
                temp = null;
            }
            dgvRezervacijaStavke.AutoGenerateColumns = false;
            dgvRezervacijaStavke.DataSource = dgvRezultat;

        }

        private async void btnOdobri_Click(object sender, EventArgs e)
        {
            var rezervacija = await _rezervacije.GetById<Model.Rezervacija>(_id);
            rezervacija.Status = true;
            rezervacija.KorisnikId = Global.prijavljeniKorisnikId;
            rezervacija = await _rezervacije.Update<Model.Rezervacija>(_id, rezervacija);
            MessageBox.Show("Rezervacija prihvacena.");

            Reports.ReportViewForm frm = new Reports.ReportViewForm();
            frm.rezervacija = rezervacija;
            frm.Show();

            
        }

        
    }
}
