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
    public partial class frmPregledRezervacija : Form
    {
        private readonly APIService _rezervacije = new APIService("Rezervacije");
        public frmPregledRezervacija()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            
            var list = await _rezervacije.Get<List<Model.Rezervacija>>(null);
            bool pronadjen = false;
            var nova = new List<Model.Rezervacija>();
            foreach(var item in list)
            {
                if (item.DatumRezervacije.Date == dateTimePicker1.Value.Date)
                {
                    pronadjen = true;
                    nova.Add(item);
                }
            }
            if (pronadjen == true)
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = nova;
            }
            else
            {
                MessageBox.Show("Na izabrani datum nije bilo rezervacija");
                return;
            }
          
            

            Reports.RezervacijePoDatumuReportViewForm frm = new Reports.RezervacijePoDatumuReportViewForm();
            frm.rezervacije = nova;
            frm.Show();
        }
    }
}
