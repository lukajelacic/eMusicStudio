using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eMuzickiStudio.WinUI.MuzickaOprema
{
    public partial class frmPovecajKolicinu : Form
    {
        private readonly APIService _muzickaOprema = new APIService("MuzickaOprema");
        private readonly APIService _vrste = new APIService("Vrsta");
        private int? _id = null;

        public frmPovecajKolicinu(int? muzickaOpremaId)
        {
            InitializeComponent();
            _id = muzickaOpremaId;
        }

        private async void frmPovecajKolicinu_Load(object sender, EventArgs e)
        {
            var oprema = await _muzickaOprema.GetById<Model.MuzickaOprema>(_id);
            var vrsta = await _vrste.GetById<Model.Vrsta>(oprema.VrstaId);
            txtNaziv.Text = oprema.Naziv;
            txtNaziv.ReadOnly = true;
            txtVrsta.Text = vrsta.Naziv;
            txtVrsta.ReadOnly = true;
            txtNaStanju.Text = oprema.NaStanju.ToString();
            txtNaStanju.ReadOnly = true;
            byte[] image = oprema.Slika;
            if (image.Length > 0)
            {
                Image x = (Bitmap)((new ImageConverter().ConvertFrom(oprema.Slika)));
                x = Resize(x, 150, 150);
                pictureBox1.Image = x;
            }

        }
        private Image Resize(Image img, int iWidth, int iHeight)
        {
            Bitmap bmp = new Bitmap(iWidth, iHeight);
            Graphics graphic = Graphics.FromImage((Image)bmp);
            graphic.DrawImage(img, 0, 0, iWidth, iHeight);

            return (Image)bmp;
        }
        private async void btnPovecaj_Click(object sender, EventArgs e)
        {
            var oprema = await _muzickaOprema.GetById<Model.MuzickaOprema>(_id);
            oprema.NaStanju += int.Parse(txtKolicina.Text);
            if(oprema.NaStanju > 50)
            {
                MessageBox.Show("Na stanju moze biti najvise 50 instrumenata iste vrste!");
                return;
            }
            await _muzickaOprema.Update<Model.MuzickaOprema>(oprema.MuzickaOpremaId, oprema);
            MessageBox.Show("Povecan broj dostupnih " + oprema.Naziv + " na stanju.");
            this.Close();
        }
        string regexNumber = @"[1-10]";
        private void txtKolicina_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKolicina.Text))
            {
                errorProvider1.SetError(txtKolicina, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtKolicina.Text, regexNumber))
            {
                errorProvider1.SetError(txtKolicina, "Kolicina mora biti broj izmedju 1 i 10.");
                e.Cancel = true;
            }
            
            else
            {
                errorProvider1.SetError(txtKolicina, null);
            }
        }
    }
}
