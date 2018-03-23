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
            
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeShowForm obj = new EmployeeShowForm();
            obj.ShowDialog();
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            OrderForm obj = new OrderForm();
            obj.ShowDialog();
        }

        private void availableStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckStockForm obj = new CheckStockForm();
            obj.ShowDialog();
        }

        private void salesDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OrderDetailForm obj = new OrderDetailForm();
            //obj.ShowDialog();
        }

        private void availableStockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void availableStockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvailableStockReportForm report = new AvailableStockReportForm();
            report.ShowDialog();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            SaleReportForm obj = new SaleReportForm();
            obj.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            SalesForm obj = new SalesForm();
            obj.ShowDialog(); //iski abi krni ha coding
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timelabel1.Text = DateTime.Now.ToLongTimeString();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("©Boutique Management System(Pvt) Ltd. BahawalNagar,\n Pakistan Since 2018.","AboutUs",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm lf = new loginForm();
            lf.Show();
        }
    }
}
