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
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetData();
            dataGridView1.Columns[0].Visible = false;
        }
        private DataTable GetData()
        {
            DataTable dt = new DataTable();
            string connectionstring = ConfigurationManager.ConnectionStrings["edb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlDataAdapter adapter = new SqlDataAdapter("select * from [SaleDetailTbl]", conn);//ider sales waly table sy likhna ha select * from sales
            adapter.Fill(dt);
            return dt;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            SaleUpdateAndDeleteForm obj = new SaleUpdateAndDeleteForm();

            int rowindex = dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);

            string r1 = Convert.ToString(dataGridView1.Rows[rowindex].Cells["DressName"].Value);//convert krny ka treeka b dekh ly
            string r2 = Convert.ToString(dataGridView1.Rows[rowindex].Cells["Price"].Value);//convert krny ka treeka b dekh ly
            string r3 = Convert.ToString(dataGridView1.Rows[rowindex].Cells["Quantity"].Value);//convert krny ka treeka b dekh ly


            obj.DnameP = r1;
            obj.DpriceP = r2;
            obj.DquantityP = r3;

            obj.Show();

        }
    }
}
