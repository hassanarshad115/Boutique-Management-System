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
            timer1.Start();
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
                SqlCommand cm = new SqlCommand("select * from PurchaseTbl where DressName = '" + textBox1.Text.Trim() + "'", conn1);

                SqlDataAdapter adapter = new SqlDataAdapter(cm);
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
         
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //print document k ander ye likhna ha
            e.Graphics.DrawString(rtReceipt.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //jb receipt k button p click kry tw ye code run ho \
            
            rtReceipt.Clear();
            rtReceipt.AppendText(Environment.NewLine); //phli line chor k
            rtReceipt.AppendText("\t" + "Boutique Management System" + Environment.NewLine); //title

            rtReceipt.AppendText("-----------------------------------------------------------" + Environment.NewLine); //fr line
            rtReceipt.AppendText(timerlabel5.Text + "\t" + datelabel5.Text + Environment.NewLine);
            rtReceipt.AppendText("-----------------------------------------------------------" + Environment.NewLine); //fr line
                                                                                                                       //fr jo txtbox ki value receipt ma show krni ho us us ko asy likhna ha jsy nichy likha hoa h
            rtReceipt.AppendText("Client Name      \t\t\t" + clientnametextBox3.Text + Environment.NewLine);
            rtReceipt.AppendText("Dress Name     \t\t\t" + textBox1.Text + Environment.NewLine);
            rtReceipt.AppendText("Quanity      \t\t\t" + textBox2.Text + Environment.NewLine);
            rtReceipt.AppendText("Total Price      \t\t\t" + totalPricetextBox4.Text + Environment.NewLine);

            rtReceipt.AppendText("-----------------------------------------------------------" + Environment.NewLine);

            rtReceipt.AppendText("©Boutique Management System(Pvt) Ltd. BahawalNagar,\n Pakistan Since 2018. " + Environment.NewLine);

            printbutton3.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerlabel5.Text = DateTime.Now.ToLongTimeString();
            datelabel5.Text = DateTime.Now.ToLongDateString();
        }
    }
}
