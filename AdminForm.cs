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

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesForm obj = new SalesForm();
            obj.ShowDialog(); //iski abi krni ha coding
        }

        private void availableStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckStockForm obj = new CheckStockForm();
            obj.ShowDialog();
        }

        private void salesDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderDetailForm obj = new OrderDetailForm();
            obj.ShowDialog();
        }

        private void availableStockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StockReportForm obj = new StockReportForm();
            obj.ShowDialog();
        }
    }
}
