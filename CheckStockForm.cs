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
    public partial class CheckStockForm : Form
    {
        public CheckStockForm()
        {
            InitializeComponent();
        }

        private void CheckStockForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetData();
        }
        DataTable dt = new DataTable();
        private DataTable GetData()
        {

            string connectionstring = ConfigurationManager.ConnectionStrings["edb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);
            //SqlDataAdapter adapter = new SqlDataAdapter("select * from [PurchaseTbl] where [DressName] like '%" + textBox1.Text.Trim() + "%'", conn);
            SqlDataAdapter adapter = new SqlDataAdapter("select * from spStock ", conn);

            adapter.Fill(dt);
            return dt;
        }
    }
}
