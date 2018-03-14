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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseShowForm obj = new PurchaseShowForm();

            obj.ShowDialog();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OderReportForm orf = new OderReportForm();
            orf.ShowDialog();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeShowForm obj = new EmployeeShowForm();
            obj.ShowDialog();
        }
    }
}
