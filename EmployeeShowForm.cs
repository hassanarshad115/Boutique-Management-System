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
    public partial class EmployeeShowForm : Form
    {
        public EmployeeShowForm()
        {
            InitializeComponent();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MethodInFirstForm(0, false);
            
        }

        private void MethodInFirstForm(int idV, bool isUpdateV)
        {
            EmployeesForm obj = new EmployeesForm();
            obj.eIdP = idV;
            obj.eIsupdateP = isUpdateV;
            obj.Show();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            int row =(int) dataGridView1.Rows[rowindex].Cells[0].Value;
            MethodInFirstForm(row, true);
           
        }

        private void EmployeeShowForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetData();
            dataGridView1.Columns[0].Visible = false;
        }

        private DataTable GetData()
        {
            DataTable dt = new DataTable();
            string connectionstring = ConfigurationManager.ConnectionStrings["edb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlDataAdapter adapter = new SqlDataAdapter("select * from EmployeeTbl", conn);
            adapter.Fill(dt);
            return dt;
        }
    }
}
