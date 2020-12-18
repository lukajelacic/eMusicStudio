using eMuzickiStudio.Model.Requests;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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
    public partial class ReportViewForm : Form
    {
        private readonly APIService _rezervacijaStavke = new APIService("RezervacijaStavke");
        public Model.Rezervacija rezervacija { get; set; }
        public ReportViewForm()
        {
            InitializeComponent();
        }

        private async void ReportViewForm_Load(object sender, EventArgs e)
        {
            var list = await _rezervacijaStavke.Get<List<Model.RezervacijaStavke>>(new RezervacijaStavkeSearchRequest()
            {
                RezervacijaId = rezervacija.RezervacijaId
            });
            var dgvRezultat = new List<Model.RezervacijaStavkeRezultat>();
            foreach (var item in list)
            {
                Model.RezervacijaStavkeRezultat temp = new Model.RezervacijaStavkeRezultat(item);
                dgvRezultat.Add(temp);
                temp = null;
            }
            ReportDataSource rds = new ReportDataSource("dsRezervacijeStavke", dgvRezultat);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("BrojRezervacije", rezervacija.BrojRezervacije.ToString()));
            this.reportViewer1.RefreshReport();
        }
    }
}
