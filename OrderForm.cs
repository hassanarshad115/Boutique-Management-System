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
            if (clientnametextBox3.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Client Name is Required", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clientnametextBox3.Focus();
                return false;
            }

            return true;
        }
        double result;
        double price;
        double quanitity;
        DataSet ds = new DataSet();
        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Quantity is Required", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
            }
            else
            {
                string connectionstring1 = ConfigurationManager.ConnectionStrings["edb"].ConnectionString;
                SqlConnection conn1 = new SqlConnection(connectionstring1);
                SqlCommand cm = new SqlCommand("select * from PurchaseTbl where DressName='" + textBox1.Text.Trim() + "'", conn1);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    price = Convert.ToDouble(dataGridView1.Rows[0].Cells[3].Value);
                    quanitity = Convert.ToDouble(textBox2.Text.Trim());


                    result = quanitity * price;
                    totalPricetextBox4.Text = result.ToString();

                    SaveSaleDetailMethod(); //Dress Detail Save in Database
                    MessageBox.Show("Save Record Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CheckRemainingStock(); // delete Dress Name and show new record in checkStockForm
                }
            }

        }


        //checkStockForm k lye ye bnana pra
        private void CheckRemainingStock()
        {
            string c = ConfigurationManager.ConnectionStrings["edb"].ConnectionString;
            SqlConnection conn = new SqlConnection(c);
            SqlCommand cmd = new SqlCommand("spStock", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@dName", textBox1.Text.Trim());


            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void SaveSaleDetailMethod()
        {
            string c = ConfigurationManager.ConnectionStrings["edb"].ConnectionString;
            SqlConnection conn = new SqlConnection(c);
            SqlCommand cmd = new SqlCommand("spSaleDetail", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@dName", textBox1.Text.Trim());
            cmd.Parameters.AddWithValue("@cName", clientnametextBox3.Text.Trim());
            cmd.Parameters.AddWithValue("@quantity", textBox2.Text.Trim());
            cmd.Parameters.AddWithValue("@price", totalPricetextBox4.Text.Trim());


            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
