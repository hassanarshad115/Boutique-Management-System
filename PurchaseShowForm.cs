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
    public partial class PurchaseShowForm : Form
    {
        public PurchaseShowForm()
        {
            InitializeComponent();
        }

        private void PurchaseShowForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetData();
            dataGridView1.Columns[0].Visible = false;
        }

       
        private DataTable GetData()
        {
            DataTable dt = new DataTable();
            string connectionstring = ConfigurationManager.ConnectionStrings["edb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlDataAdapter adapter = new SqlDataAdapter("select * from [PurchaseTbl]", conn);
            adapter.Fill(dt);
            return dt;
        }

        private void addNewRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MethodInFirstForm(0, false);
            //this.Hide();
        }

        private void MethodInFirstForm(int idV, bool updateV)
        {
            PurchaseForm obj = new PurchaseForm();
            obj.idP = idV;
            obj.isUpdateP = updateV;
            
            obj.Show();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int index = dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            int updateObj = (int)dataGridView1.Rows[index].Cells[0].Value; //cells[0] he hoga q k hm id pr sp bnaygy wo access kryga sari values

            //jo method upser add new record ko jb click krty ha usmy bnaya ta usko yha agian call ki but obj r true pas krdia
            MethodInFirstForm(updateObj, true);
            //bs datagridview ma jst ye 3 lines he likhni  ha..
            dataGridView1.DataSource = GetData();
            //this.Hide();
        }
    }
}
