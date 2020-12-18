using eMuzickiStudio.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eMuzickiStudio.WinUI.MuzickaOprema
{
    public partial class frmMuzickaOprema : Form
    {
        private readonly APIService _muzickaOprema = new APIService("MuzickaOprema");
        private readonly APIService _vrsta= new APIService("Vrsta");

        public frmMuzickaOprema()
        {
            InitializeComponent();
        }

        private async void  frmMuzickaOprema_Load(object sender, EventArgs e)
        {
            await LoadVrsta();  
        }
        private async Task LoadVrsta()
        {
            var result = await _vrsta.Get<List<Model.Vrsta>>(null);
            result.Insert(0, new Model.Vrsta());
            cmbVrsta.DataSource = result;
            cmbVrsta.DisplayMember = "Naziv";
            cmbVrsta.ValueMember = "VrstaId";
            
        }

        private async void cmbVrsta_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbVrsta.SelectedValue;
            if(int.TryParse(idObj.ToString(),out int id))
            {
                await LoadMuzickaOprema(id);
            }
        }
        private async Task LoadMuzickaOprema(int vrstaId)
        {
            var result = await _muzickaOprema.Get<List<Model.MuzickaOprema>>(new MuzickaOpremaSearchRequest()
            {
                VrstaId = vrstaId
            });
            dgvMuzickaOprema.AutoGenerateColumns = false;
            dgvMuzickaOprema.DataSource = result;
        }
        MuzickaOpremaUpsertRequest request = new MuzickaOpremaUpsertRequest();

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var idObj = cmbVrsta.SelectedValue;
                if (int.TryParse(idObj.ToString(), out int vrstaId))
                {
                    request.VrstaId = vrstaId;
                }
                request.Naziv = txtNaziv.Text;
                request.NaStanju = int.Parse(txtBrojNaStanju.Text);
                request.Cijena = int.Parse(txtCijena.Text);
                request.Slika = converterDemo(pictureBox1.Image);

                await _muzickaOprema.Insert<Model.MuzickaOprema>(request);
                MessageBox.Show("Operacija uspjesna!");

            }

        }
        public static byte[] converterDemo(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
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

        private void dgvMuzickaOprema_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvMuzickaOprema.SelectedRows[0].Cells[0].Value;
            var frm = new frmPovecajKolicinu(int.Parse(id.ToString()));
            frm.Show();
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                errorProvider1.SetError(txtNaziv, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtNaziv, null);
            }
        }

        private void txtBrojNaStanju_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBrojNaStanju.Text))
            {
                errorProvider1.SetError(txtBrojNaStanju, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtBrojNaStanju, null);
            }
        }

        private void txtCijena_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCijena.Text))
            {
                errorProvider1.SetError(txtCijena, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtCijena, null);
            }
        }

        private void cmbVrsta_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbVrsta.Text))
            {
                errorProvider1.SetError(cmbVrsta, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(cmbVrsta, null);
            }
        }

       
    }
}
