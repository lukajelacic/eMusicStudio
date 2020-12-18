using eMuzickiStudio.Model.Requests;
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
    public partial class KlijentiRezervacijeReportViewForm : Form
    {
        public List<Model.Rezervacija> rezervacije { get; set; }
        public KlijentiRezervacijeReportViewForm()
        {
            InitializeComponent();
        }

        private  void KlijentiRezervacijeReportViewForm_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("dsRezervacije", rezervacije);
            
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
