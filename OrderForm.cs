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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetData();
            dataGridView1.Columns[0].Visible = false;
        }
        DataTable dt = new DataTable();
        private DataTable GetData()
        {
            
            string connectionstring = ConfigurationManager.ConnectionStrings["edb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);
            //SqlDataAdapter adapter = new SqlDataAdapter("select * from [PurchaseTbl] where [DressName] like '%" + textBox1.Text.Trim() + "%'", conn);
            SqlDataAdapter adapter = new SqlDataAdapter("select * from [PurchaseTbl] ", conn);

            adapter.Fill(dt);
            return dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dr = dt.DefaultView;

            dr.RowFilter = "[DressName] like '%" + textBox1.Text.Trim() + "%'";

        }

        private void button1_Click(object sender, EventArgs e)
        {

          

        }

        private bool isEmpty()
        {
            if (textBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Correct Dress Name is Required", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return false;
            }
          
            return true;
        }
        double result;
        double price;
        double quanitity;
        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Quantity is Required", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
            }
            else
            {
                price = Convert.ToDouble(dataGridView1.Rows[0].Cells[3].Value);
                quanitity = Convert.ToDouble(textBox2.Text.Trim());


                result = quanitity * price;
                totalPricetextBox4.Text = result.ToString();
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch))
            {
                MessageBox.Show("Only Enter Number", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
    }
}
