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
    public partial class AvailableStockReportForm : Form
    {
        public AvailableStockReportForm()
        {
            InitializeComponent();
        }

        private void AvailableStockReportForm_Load(object sender, EventArgs e)
        {
            ReportDocument rdoc = new ReportDocument();

            string appPath = Application.StartupPath;
            string reportPath = @"AvailableStockReport.rpt";

            string fullPath = System.IO.Path.Combine(appPath, reportPath);

            rdoc.Load(fullPath);

            crystalReportViewer1.ReportSource = rdoc;
        }
    }
}
