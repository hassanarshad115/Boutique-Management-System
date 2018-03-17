using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBMS
{
    public partial class SaleReportForm : Form
    {
        public SaleReportForm()
        {
            InitializeComponent();
        }

        private void SaleReportForm_Load(object sender, EventArgs e)
        {
            ReportDocument rdoc = new ReportDocument();

            string appPath = Application.StartupPath;
            string reprotPath = @"SaleReport.rpt";

            string fullPath = System.IO.Path.Combine(appPath, reprotPath);
            rdoc.Load(fullPath);

            crystalReportViewer1.ReportSource = rdoc;
        }
    }
}
