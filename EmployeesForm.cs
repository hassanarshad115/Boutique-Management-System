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
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();
        }
        public int eIdP { get; set; }
        public bool eIsupdateP { get; set; }
        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            if (eIsupdateP)
            {
                DataTable dt = GetRecordById(eIdP);
                DataRow row = dt.Rows[0];

                nametext.Text = row["EmpName"].ToString();
                designationComboBox1.Text = row["EmpDesignation"].ToString();
                passwordtextbox.Text = row["EmpPassword"].ToString();
                joiningdate.Text = row["EmpJoinDate"].ToString();

                button1.Text = "Update"; // when datagrid view clicked then Update write on save button
            }
        }

        private DataTable GetRecordById(int eIdP)
        {
            DataTable dt = new DataTable();
            string c = ConfigurationManager.ConnectionStrings["edb"].ConnectionString;
            SqlConnection conn = new SqlConnection(c);
            SqlCommand cmd = new SqlCommand("spEAccessById", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", eIdP);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            return dt;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                if (eIsupdateP)
                {
                    UpdateMethod();
                    this.Hide();
                    EmployeeShowForm obj = new EmployeeShowForm();
                    obj.Show();
                }
                else
                {
                    SaveMethod();
                    this.Hide();
                    EmployeeShowForm obj = new EmployeeShowForm();
                    obj.Show();
                }

            }
        }




        private bool isEmpty()
        {
            if (nametext.Text.Trim() == string.Empty)
            {
                MessageBox.Show(" Name is Required", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nametext.Focus();
                return false;
            }
            if (designationComboBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show(" Designation is Required", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (passwordtextbox.Text.Trim() == string.Empty)
            {
                MessageBox.Show(" Password is Required", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordtextbox.Focus();
                return false;
            }
            return true;
        }

            private void SaveMethod()
        {
            string c = ConfigurationManager.ConnectionStrings["edb"].ConnectionString;
            SqlConnection conn = new SqlConnection(c);
            SqlCommand cmd = new SqlCommand("spEI", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@n", nametext.Text.Trim());
            cmd.Parameters.AddWithValue("@designation", designationComboBox1.Text);
            cmd.Parameters.AddWithValue("@epwd", passwordtextbox.Text.Trim());
            cmd.Parameters.AddWithValue("@edate", joiningdate.Value.Date);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Save Record Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateMethod()
        {
            string c = ConfigurationManager.ConnectionStrings["edb"].ConnectionString;
            SqlConnection conn = new SqlConnection(c);
            SqlCommand cmd = new SqlCommand("spEup", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@n", nametext.Text.Trim());
            cmd.Parameters.AddWithValue("@designation", designationComboBox1.Text);
            cmd.Parameters.AddWithValue("@epwd", passwordtextbox.Text.Trim());
            cmd.Parameters.AddWithValue("@edate", joiningdate.Value.Date);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Update Record Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        DataSet ds = new DataSet();
        private void button3_Click(object sender, EventArgs e)
        {
            string c1 = ConfigurationManager.ConnectionStrings["edb"].ConnectionString;
            SqlConnection conn1 = new SqlConnection(c1);
            SqlCommand cm = new SqlCommand("select * from [EmployeeTbl] where [EmpName]='" + nametext.Text.Trim() + "'", conn1);

            SqlDataAdapter adapter = new SqlDataAdapter(cm);
            adapter.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if(i > 0)
            {
                string c = ConfigurationManager.ConnectionStrings["edb"].ConnectionString;
                SqlConnection conn = new SqlConnection(c);
                SqlCommand cmd = new SqlCommand("spEdel", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@n", nametext.Text.Trim());
                cmd.Parameters.AddWithValue("@designation", designationComboBox1.Text);
                cmd.Parameters.AddWithValue("@epwd", passwordtextbox.Text.Trim());
                cmd.Parameters.AddWithValue("@edate", joiningdate.Value.Date);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Delete Record Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                EmployeeShowForm obj = new EmployeeShowForm();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Employee Name " + nametext.Text + " is Not Exist", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
