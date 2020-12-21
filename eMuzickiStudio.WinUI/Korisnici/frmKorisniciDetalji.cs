using eMuzickiStudio.Model.Requests;
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

namespace eMuzickiStudio.WinUI.Korisnici
{
    public partial class frmKorisniciDetalji : Form
    {
        private readonly APIService _korisnici = new APIService("Korisnici");
        private readonly APIService _gradovi = new APIService("Grad");
        private readonly APIService _uloge = new APIService("Uloge");
        string emailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$";
        private int? _id = null;
        public frmKorisniciDetalji(int? korisnikId)
        {
            InitializeComponent();
            _id = korisnikId;
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var request = new KorisniciInsertRequest();
                request.Ime = txtIme.Text;
                request.Prezime = txtPrezime.Text;
                request.Telefon = txtPhone.Text;
                request.Email = txtEmail.Text;
                request.KorisnickoIme = txtKorisnickoIme.Text;
                request.Password = txtPassword.Text;
                request.PasswordConfirmation = txtPasswordConfirmation.Text;
                request.UlogaId = cmbUloga.SelectedIndex;
                if (_id.HasValue)
                {
                    await _korisnici.Update<Model.Korisnici>(_id, request);
                }
                else
                {
                    await _korisnici.Insert<Model.Korisnici>(request);
                }
                MessageBox.Show("Operacija uspjesna!");

            }
        }

        private async void frmKorisniciDetalji_Load(object sender, EventArgs e)
        {
            await LoadUloge();
            if (_id.HasValue)
            {
                var korisnik = await _korisnici.GetById<Model.Korisnici>(_id);
                txtIme.Text = korisnik.Ime;
                txtIme.ReadOnly = true;

                txtPrezime.Text = korisnik.Prezime;
                txtPrezime.ReadOnly = true;

                txtPhone.Text = korisnik.Telefon;
                txtPhone.ReadOnly = true;

                txtEmail.Text = korisnik.Email;
                txtEmail.ReadOnly = true;

                txtKorisnickoIme.Text = korisnik.KorisnickoIme;
                txtKorisnickoIme.ReadOnly = true;

                cmbUloga.SelectedIndex = korisnik.UlogaId;
                cmbUloga.Enabled = false;

                txtPassword.Visible = false;
                label6.Visible = false;

                txtPasswordConfirmation.Visible = false;
                label7.Visible = false;

                btnSnimi.Visible = false;
                //btnIzbrisi.Visible = true;
            }
            //else
            //{
            //    btnIzbrisi.Visible = false;
            //}
            //if (Global.prijavljeniKorisnik.UlogaId == 2)
            //{
            //    btnIzbrisi.Visible = false;
            //}
        }
      
        private async Task LoadUloge()
        {
            var result = await _uloge.Get<List<Model.Uloge>>(null);
            result.Insert(0, new Model.Uloge());
            cmbUloga.DataSource = result;
            cmbUloga.DisplayMember = "Naziv";
            cmbUloga.ValueMember = "UlogaId";
        }


        private void txtIme_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text) || txtIme.Text.Length<4)
            {
                errorProvider1.SetError(txtIme, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text) || txtPrezime.Text.Length<4)
            {
                errorProvider1.SetError(txtPrezime, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPrezime, null);
            }
        }

      

        private void txtEmail_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
                bool isEmailValid = Regex.IsMatch(txtEmail.Text, emailPattern);
                if (isEmailValid == false)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtEmail, "Unesite email u ispravnom formatu!");
                }
            }
        }

        private void txtKorisnickoIme_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text) && txtKorisnickoIme.Text.Length < 4)
            {
                errorProvider1.SetError(txtKorisnickoIme, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtKorisnickoIme, null);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text)) 
            {
                errorProvider1.SetError(txtPassword, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            if (!string.IsNullOrWhiteSpace(txtPassword.Text) && !string.IsNullOrWhiteSpace(txtKorisnickoIme.Text) && txtPassword.Text == txtKorisnickoIme.Text)
            {
                errorProvider1.SetError(txtPassword, "Lozinka ne smije biti ista kao i korisnicko ime!");
                e.Cancel = true;
            }
            if (!string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, null);
                e.Cancel = false;

            }
            if (!string.IsNullOrWhiteSpace(txtPassword.Text) && !string.IsNullOrWhiteSpace(txtKorisnickoIme.Text) && txtPassword.Text != txtKorisnickoIme.Text)
            {
                errorProvider1.SetError(txtPassword, null);
                e.Cancel = false;

            }
        }

        private void txtPasswordConfirmation_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPasswordConfirmation.Text))
            {
                errorProvider1.SetError(txtPasswordConfirmation, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            if (!string.IsNullOrWhiteSpace(txtPasswordConfirmation.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text) && txtPassword.Text != txtPasswordConfirmation.Text)
            {

                errorProvider1.SetError(txtPasswordConfirmation, "Potvrda lozinke mora imati istu vrijednost kao i sama lozinka!");
                e.Cancel = true;
            }
            if (!string.IsNullOrWhiteSpace(txtPasswordConfirmation.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text) && txtPassword.Text == txtPasswordConfirmation.Text)
            {
                errorProvider1.SetError(txtPasswordConfirmation, null);
                e.Cancel = false;

            }
            if (!string.IsNullOrWhiteSpace(txtPasswordConfirmation.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text) && txtPassword.Text == txtPasswordConfirmation.Text)
            {
                errorProvider1.SetError(txtPasswordConfirmation, null);
                e.Cancel = false;

            }
        }

        

        private void cmbUloga_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbUloga.Text))
            {
                errorProvider1.SetError(cmbUloga, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(cmbUloga, null);
            }
        }

       

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (!txtPhone.MaskCompleted)
            {
                errorProvider1.SetError(txtPhone, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPhone, null);
            }
        }
    }
}
