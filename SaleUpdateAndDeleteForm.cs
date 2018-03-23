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
    public partial class SaleUpdateAndDeleteForm : Form
    {
        public SaleUpdateAndDeleteForm()
        {
            InitializeComponent();
        }
        public string DnameP { get; set; }
        public string DpriceP { get; set; }
        public string DquantityP { get; set; }

        DataSet ds = new DataSet();
        SqlCommand cm;
        private void insertBotton_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                string c = ConfigurationManager.ConnectionStrings["edb"].ConnectionString;
                SqlConnection conn = new SqlConnection(c);
                cm = new SqlCommand("select * from SaleDetailTbl where DressName='" + dressnametextBox.Text.Trim() + "'", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cm);
                adapter.Fill(ds);
                int r = ds.Tables[0].Rows.Count;
                if (r > 0)
                {
                    SqlCommand cmd = new SqlCommand("spSaleDetailUpdate", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@dName", dressnametextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@price", pricePerItemtextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@quantity", QuantitytextBox.Text.Trim());

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Update Record Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    SalesForm sf = new SalesForm();
                    sf.Show();
                }
                else
                {
                    MessageBox.Show("Dress Name " + dressnametextBox.Text + " is Not Exist", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private bool isEmpty()
        {

            if (dressnametextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Dress Name is Required", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dressnametextBox.Focus();
                return false;
            }
            if (pricePerItemtextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Price is Required", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pricePerItemtextBox.Focus();
                return false;
            }
            if (QuantitytextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Quantity is Required", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                QuantitytextBox.Focus();
                return false;
            }
            return true;
        }

        private void deleteBotton_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                string c = ConfigurationManager.ConnectionStrings["edb"].ConnectionString;
                SqlConnection conn = new SqlConnection(c);
                cm = new SqlCommand("select * from SaleDetailTbl where DressName='" + dressnametextBox.Text.Trim() + "'", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cm);
                adapter.Fill(ds);
                int r = ds.Tables[0].Rows.Count;
                if (r > 0)
                {
                    SqlCommand cmd = new SqlCommand("spSaleDetailDel", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@dName", dressnametextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@price", pricePerItemtextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@quantity", QuantitytextBox.Text.Trim());

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Delete Record Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    SalesForm sf = new SalesForm();
                    sf.Show();
                }
                else
                {
                    MessageBox.Show("Dress Name " + dressnametextBox.Text + " is Not Exist", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaleUpdateAndDeleteForm_Load(object sender, EventArgs e)
        {
            dressnametextBox.Text = DnameP;
            pricePerItemtextBox.Text = DpriceP;
            QuantitytextBox.Text = DquantityP;
        }
    }
}
