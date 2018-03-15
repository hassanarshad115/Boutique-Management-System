using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBMS
{
    public partial class BillForm : Form
    {
        public BillForm()
        {
            InitializeComponent();
        }

        private void BillForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetData();
        }
        private DataTable GetData()
        {
            DataTable dt = new DataTable();
            string connectionstring = ConfigurationManager.ConnectionStrings["edb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlDataAdapter adapter = new SqlDataAdapter("spSaleDetail", conn);
            adapter.Fill(dt);
            return dt;
        }
    }
}
