using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eMuzickiStudio.WinUI.Reports
{
    public partial class RezervacijePoDatumuReportViewForm : Form
    {
        public List<Model.Rezervacija> rezervacije { get; set; }
        public RezervacijePoDatumuReportViewForm()
        {
            InitializeComponent();
        }

        private void RezervacijePoDatumuReportViewForm_Load(object sender, EventArgs e)
        {
            var dgvRezultat = new List<Model.Requests.RezervacijaRezultat>();
            foreach (var item in rezervacije)
            {
                Model.Requests.RezervacijaRezultat temp = new Model.Requests.RezervacijaRezultat(item);
                dgvRezultat.Add(temp);
                temp = null;
            }
            decimal ukupno = 0;
            foreach(var item in dgvRezultat)
            {
                ukupno += item.Cijena.Value;
            }
            ReportDataSource rds = new ReportDataSource("dsRezervacije", dgvRezultat);
            string datum = dgvRezultat[0].DatumRezervacije.ToShortDateString();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("DatumRezervacije", datum));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Ukupno", ukupno.ToString()));
            this.reportViewer1.RefreshReport();
        }
    }
}
