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
    public partial class PurchaseForm : Form
    {
        public PurchaseForm()
        {
            InitializeComponent();
        }
        public bool isUpdateP { get; set; }
        public int idP { get; set; }
        public bool delbtnP { get; set; }
        public bool savebtnP { get; set; }
        private void insertBotton_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                if (isUpdateP)
                {
                    updateRecordMethod();
                    this.Hide();
                    PurchaseShowForm p = new PurchaseShowForm();
                    p.Show();
                }
                else
                {
                    SaveRecordMethod();
                    this.Hide();
                    PurchaseShowForm p = new PurchaseShowForm();
                    p.Show();
                }
                
            }
        }

        private bool isEmpty()
        {
            if (dressnametextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Dress Name is Required","Error ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                dressnametextBox.Focus();
                return false;
            }
            if (dressizetextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Dress Size is Required", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dressizetextBox.Focus();
                return false;
            }
            if (pricePerItemtextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Price Per Item is Required", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pricePerItemtextBox.Focus();
                return false;
            }
            if (QuantitytextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Quantity is Required", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                QuantitytextBox.Focus();
                return false;
            }
            if (descriptionrichTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Description is Required", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                descriptionrichTextBox.Focus();
                return false;
            }
            return true;
        }

        DataSet ds = new DataSet();
        SqlCommand cm;
        private void SaveRecordMethod()
        {
            //DataTable dt = new DataTable();

            string connectionstring = ConfigurationManager.ConnectionStrings["edb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);
            cm = new SqlCommand("select * from PurchaseTbl where DressName='" + dressnametextBox.Text.Trim() + "'", conn);

            SqlDataAdapter adpter = new SqlDataAdapter(cm);
            adpter.Fill(ds);
            int name = ds.Tables[0].Rows.Count;

            if (name > 0)
            {
                MessageBox.Show("Item Name " + dressnametextBox.Text + " is Already Exist", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                string connectionstring1 = ConfigurationManager.ConnectionStrings["edb"].ConnectionString;
                SqlConnection conn1 = new SqlConnection(connectionstring1);
                SqlCommand cmd = new SqlCommand("spPI", conn1);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@DName", dressnametextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@DSize", dressizetextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@ppi", pricePerItemtextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@q", QuantitytextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@desc", descriptionrichTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@purchaseD", datepurchasedatetime.Value.Date);

                conn1.Open();
                cmd.ExecuteNonQuery();
                conn1.Close();

                MessageBox.Show("Save Record Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void updateRecordMethod()
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["edb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand("spUp", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@DName", dressnametextBox.Text.Trim());
            cmd.Parameters.AddWithValue("@DSize", dressizetextBox.Text.Trim());
            cmd.Parameters.AddWithValue("@ppi", pricePerItemtextBox.Text.Trim());
            cmd.Parameters.AddWithValue("@q", QuantitytextBox.Text.Trim());
            cmd.Parameters.AddWithValue("@desc", descriptionrichTextBox.Text.Trim());
            cmd.Parameters.AddWithValue("@purchaseD", datepurchasedatetime.Value.Date);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Update Record Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PurchaseForm_Load(object sender, EventArgs e)
        {
            if (isUpdateP)
            {
                DataTable dt = GetRecordById(idP);
                DataRow dr = dt.Rows[0];

                dressnametextBox.Text = dr["DressName"].ToString();
                dressizetextBox.Text = dr["DressSize"].ToString();
                pricePerItemtextBox.Text = dr["PerPrizeItem"].ToString();
                QuantitytextBox.Text = dr["Quantity"].ToString();
                descriptionrichTextBox.Text = dr["Description"].ToString();
                datepurchasedatetime.Text = dr["PurchaseDate"].ToString();

                deleteBotton.Enabled = true;
                insertBotton.Text = "Update";
            }
          
        }

        private DataTable GetRecordById(int idP)
        {
            DataTable dt = new DataTable();
            string connectionstring = ConfigurationManager.ConnectionStrings["edb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand("IdAccess", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", idP);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;


        }


        private void deleteBotton_Click(object sender, EventArgs e)
        {
            string connectionstring1 = ConfigurationManager.ConnectionStrings["edb"].ConnectionString;
            SqlConnection conn1 = new SqlConnection(connectionstring1);
            SqlCommand cm = new SqlCommand("select * from PurchaseTbl where DressName='" + dressnametextBox.Text.Trim() + "'", conn1);

            SqlDataAdapter adapter = new SqlDataAdapter(cm);
            adapter.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i > 0)
            {
                string connectionstring = ConfigurationManager.ConnectionStrings["edb"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionstring);
                SqlCommand cmd = new SqlCommand("spDel", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@DName", dressizetextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@DSize", dressizetextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@ppi", pricePerItemtextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@q", QuantitytextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@desc", descriptionrichTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@purchaseD", datepurchasedatetime.Value.Date);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Delete Record Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                PurchaseShowForm p = new PurchaseShowForm();
                p.Show();
            }
            else
            {
                MessageBox.Show("Employee Name " + dressnametextBox.Text + " is Not Exist", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void pricePerItemtextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void pricePerItemtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyEnterNumberMethod(e);
        }

        private static void OnlyEnterNumberMethod(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch))
            {
                MessageBox.Show("Only Enter Number", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void QuantitytextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyEnterNumberMethod(e);
        }
    }
}
