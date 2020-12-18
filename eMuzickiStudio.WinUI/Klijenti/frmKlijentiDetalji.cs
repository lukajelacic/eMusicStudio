using eMuzickiStudio.Model.Requests;
using eMuzickiStudio.WinUI.Rezervacije;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eMuzickiStudio.WinUI.Klijenti
{
    public partial class frmKlijentiDetalji : Form
    {
        private int? _id = null;
        private readonly APIService _apiService = new APIService("Klijenti");
        private readonly APIService _gradovi = new APIService("Grad");
        private readonly APIService _rezervacije = new APIService("Rezervacije");
        private readonly APIService _klijenti = new APIService("Klijenti");
        string emailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$";
        public List<Model.Klijenti> klijenti { get; set; }
        public frmKlijentiDetalji(int? KlijentId)
        {
            InitializeComponent();
            _id = KlijentId;
        }
        KlijentiInsertRequest request = new KlijentiInsertRequest();
        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                request.Ime = txtIme.Text;
                request.Prezime = txtPrezime.Text;
                request.Telefon = txtPhone.Text;
                request.Email = txtEmail.Text;
                request.KorisnickoIme = txtKorisnickoIme.Text;
                request.Password = txtPassword.Text;
                request.PasswordConfirmation = txtPasswordConfirmation.Text;
                request.GradId = cmbGrad.SelectedIndex;
                request.Slika = converterDemo(pictureBox1.Image);
                request.Banovan = false;
                if (!_id.HasValue)
                {
                    //await _apiService.Update<Model.Klijenti>(_id, request);
                    await _apiService.Insert<Model.Klijenti>(request);

                }
                //else
                //{
                //    await _apiService.Insert<Model.Klijenti>(request);
                //}
                MessageBox.Show("Operacija uspjesna!");

            }

        }
       
        public static byte[] converterDemo(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }
        private async void frmKlijentiDetalji_Load(object sender, EventArgs e)
        {
            await LoadGrad();
            if (_id.HasValue == false)
            {
                //btnIzbrisi.Visible = false;
                btnRezervacijeKlijenta.Visible = false;
                btnBanuj.Visible = false;
            }
            if (_id.HasValue)
            {
                var klijent = await _apiService.GetById<Model.Klijenti>(_id);
                txtIme.Text = klijent.Ime;
                txtIme.ReadOnly = true;
                txtPrezime.Text = klijent.Prezime;
                txtPrezime.ReadOnly = true;
                txtPhone.Text= klijent.Telefon;
                txtPhone.ReadOnly = true;
                txtEmail.Text = klijent.Email;
                txtEmail.ReadOnly = true;
                txtKorisnickoIme.Text = klijent.KorisnickoIme;
                txtKorisnickoIme.ReadOnly = true;
                cmbGrad.SelectedIndex = klijent.GradId;
                cmbGrad.Enabled = false;
                //txtPassword.ReadOnly = true;
                //txtPassword.Enabled = false;
                //txtPasswordConfirmation.ReadOnly = true;
                //txtPasswordConfirmation.Enabled = false;
                txtPassword.Visible = false;
                txtPasswordConfirmation.Visible = false;
                lblLozinka.Visible = false;
                lblPotvrda.Visible = false;
                lblSlika.Visible = false;
                byte[] image = klijent.Slika;
                if (image.Length > 0)
                {
                    Image x = (Bitmap)((new ImageConverter().ConvertFrom(klijent.Slika)));
                    x = Resize(x, 150, 150);
                    pictureBox1.Image = x;
                }
                txtSlika.Enabled = false;
                btnSnimi.Visible = false;
                btnDodajSliku.Visible = false;
                txtSlika.Visible = false;
                if (klijent.Banovan == true)
                {
                    btnBanuj.Visible = false;
                }
                else
                {
                    btnBanuj.Visible = true;
                }
 
            };
        }
        private async Task LoadGrad()
        {
            var result = await _gradovi.Get<List<Model.Grad>>(null);
            result.Insert(0, new Model.Grad());
            cmbGrad.DataSource = result;
            cmbGrad.DisplayMember = "Naziv";
            cmbGrad.ValueMember = "GradId";

        }
        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text) || txtIme.Text.Length<4)
            {
                errorProvider.SetError(txtIme, Properties.Resources.Validation_RequiredField);
                e.Cancel=true;
            }
            else
            {
                errorProvider.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text) | txtPrezime.Text.Length<4)
            {
                errorProvider.SetError(txtPrezime, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPrezime, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtEmail, null);
                bool isEmailValid = Regex.IsMatch(txtEmail.Text, emailPattern);
                if (isEmailValid == false)
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtEmail, "Unesite email u ispravnom formatu!");
                }
            }

        }

       

        private async void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text) && txtKorisnickoIme.Text.Length<4)
            {
                errorProvider.SetError(txtKorisnickoIme, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            var list = await _apiService.Get < List<Model.Klijenti>>(null);
            bool pronadjen = false;
            foreach(var item in list)
            {
                if (item.KorisnickoIme == txtKorisnickoIme.Text)
                {
                    pronadjen = true;
                }
            }
            if (pronadjen == true)
            {
                errorProvider.SetError(txtKorisnickoIme, "Korisnicko ime je zauzeto");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtKorisnickoIme, null);
            }
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                var file = File.ReadAllBytes(fileName);
                request.Slika = file;
                txtSlika.Text = fileName;
                Image image = Image.FromFile(fileName);
                image = Resize(image, 100, 100);
                pictureBox1.Image = image;
            }
        }
        private Image Resize(Image img, int iWidth, int iHeight)
        {
            Bitmap bmp = new Bitmap(iWidth, iHeight);
            Graphics graphic = Graphics.FromImage((Image)bmp);
            graphic.DrawImage(img, 0, 0, iWidth, iHeight);

            return (Image)bmp;
        }
        private async void btnRezervacijeKlijenta_Click(object sender, EventArgs e)
        {
            var frm = new frmRezervacijeKlijenta(_id);
            frm.Show();

            Reports.KlijentiRezervacijeReportViewForm izvjestaj = new Reports.KlijentiRezervacijeReportViewForm();
            izvjestaj.rezervacije = await _rezervacije.Get<List<Model.Rezervacija>>(new RezervacijeSearchRequest()
            {
                KlijentId = _id.Value
            });
            izvjestaj.Show();
        }

        private void cmbGrad_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbGrad.Text))
            {
                errorProvider.SetError(cmbGrad, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbGrad, null);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            if (!string.IsNullOrWhiteSpace(txtPassword.Text) && !string.IsNullOrWhiteSpace(txtKorisnickoIme.Text) && txtPassword.Text == txtKorisnickoIme.Text)
            {
                errorProvider.SetError(txtPassword, "Lozinka ne smije biti ista kao i korisnicko ime!");
                e.Cancel = true;
            }
            if (!string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, null);
                e.Cancel = false;

            }
            if (!string.IsNullOrWhiteSpace(txtPassword.Text) && !string.IsNullOrWhiteSpace(txtKorisnickoIme.Text) && txtPassword.Text != txtKorisnickoIme.Text)
            {
                errorProvider.SetError(txtPassword, null);
                e.Cancel = false;

            }
        }

        private void txtPasswordConfirmation_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPasswordConfirmation.Text))
            {
                errorProvider.SetError(txtPasswordConfirmation, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            if (!string.IsNullOrWhiteSpace(txtPasswordConfirmation.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text) && txtPassword.Text != txtPasswordConfirmation.Text)
            {

                errorProvider.SetError(txtPasswordConfirmation, "Potvrda lozinke mora imati istu vrijednost kao i sama lozinka!");
                e.Cancel = true;
            }
            if (!string.IsNullOrWhiteSpace(txtPasswordConfirmation.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text) && txtPassword.Text == txtPasswordConfirmation.Text)
            {
                errorProvider.SetError(txtPasswordConfirmation, null);
                e.Cancel = false;

            }
            if (!string.IsNullOrWhiteSpace(txtPasswordConfirmation.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text) && txtPassword.Text == txtPasswordConfirmation.Text)
            {
                errorProvider.SetError(txtPasswordConfirmation, null);
                e.Cancel = false;

            }
        }

       

        private void maskedTextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!txtPhone.MaskCompleted)
            {
                errorProvider.SetError(txtPhone, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPhone, null);
            }
        }

        private async void btnBanuj_Click(object sender, EventArgs e)
        {
            var klijent = await _klijenti.GetKlijenta<Model.Requests.KlijentBanovanRequest>(_id);
            klijent.Banovan = true;
            await _klijenti.UpdateBanovan<Model.Klijenti>(klijent.KlijentId, klijent);
            MessageBox.Show("Klijent je uspjesno banovan");
            this.Close();
        }
    }
}
