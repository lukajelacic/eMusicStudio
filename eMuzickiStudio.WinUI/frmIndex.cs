using eMuzickiStudio.Model.Requests;
using eMuzickiStudio.WinUI.Klijenti;
using eMuzickiStudio.WinUI.Korisnici;
using eMuzickiStudio.WinUI.MuzickaOprema;
using eMuzickiStudio.WinUI.Rezervacije;
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
    public partial class frmIndex : Form
    {
        private int childFormNumber = 0;
        private readonly APIService _rezervacije = new APIService("Rezervacije");
        private readonly APIService _rezervacijaStavke = new APIService("RezervacijaStavke");
        private readonly APIService _muzickaOprema = new APIService("MuzickaOprema");
        private readonly APIService _termini = new APIService("Termini");
        private readonly APIService _korisnici = new APIService("Korisnici");

        public frmIndex()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void pretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmKlijenti();
            //frm.MdiParent = this;
            //frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void noviKlijentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmKlijentiDetalji(null);
            frm.Show();
        }

        private void pretragaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new frmMuzickaOprema();
            frm.Show();
        }

        private void pretragaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var frm = new frmKorisnici();
            frm.Show();
        }

        private async void noviKorisnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var korisnik = await _korisnici.GetById<Model.Korisnici>(Global.prijavljeniKorisnikId);
            if (korisnik.UlogaId == 2)
            {
                MessageBox.Show("Radnik nema mogucnost dodavanja novog korisnika.");
                return;
            }
            var frm = new frmKorisniciDetalji(null);
            frm.Show();
        }

        private void zahtjeviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmRezervacije();
            frm.Show();
        }

        private void slobodniTerminiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmSlobodniTermini();
            frm.Show();
        }

        private void listaSlobodnihTerminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmIspisSlobodnihTermina();
            frm.Show();
        }



        private void pregledRezervacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmPregledRezervacija();
            frm.Show();
        }

        

        private async void frmIndex_Load(object sender, EventArgs e)
        {
            await AktivniTermini();
            await ArhiviraneRezervacije();
        }
        private async Task AktivniTermini()
        {
            var list = await _termini.Get<List<Model.Termini>>(null);
            var nova = new List<Model.Termini>();
            foreach (var item in list)
            {
                if (item.Datum.Date < DateTime.Now.Date)
                {
                    nova.Add(item);
                }
            }
            foreach (var item in nova)
            {
                item.Aktivan = false;
                await _termini.Update<Model.Termini>(item.TerminId, item);
            }
        }
        private async Task ArhiviraneRezervacije()
        {
            var listaRezervacija = await _rezervacije.Get<List<Model.Rezervacija>>(null);
            var novaLista = new List<Model.Rezervacija>();
            foreach (var item in listaRezervacija)
            {
                if (item.DatumRezervacije.Date < DateTime.Now.Date && item.Arhivirana == false)
                {
                    novaLista.Add(item);
                }
            }
            foreach (var item in novaLista)
            {
                var stavke = await _rezervacijaStavke.Get<List<Model.RezervacijaStavke>>(new RezervacijaStavkeSearchRequest()
                {
                    RezervacijaId = item.RezervacijaId
                });
                foreach (var item2 in stavke)
                {
                    var muzickaOprema = await _muzickaOprema.GetById<Model.MuzickaOprema>(item2.MuzickaOpremaId);
                    muzickaOprema.NaStanju += item2.Kolicina;
                    await _muzickaOprema.Update<Model.MuzickaOprema>(muzickaOprema.MuzickaOpremaId, muzickaOprema);
                }
                item.Arhivirana = true;
                await _rezervacije.Update<Model.Rezervacija>(item.RezervacijaId, item);
            }
        }
    }
}
