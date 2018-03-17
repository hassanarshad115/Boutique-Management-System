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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginbutton1_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                bool isUsername, isPassword;
                getLoginMethod(out isUsername, out isPassword);
                if (isUsername && isPassword)
                {
                    this.Hide();
                    AdminForm af = new AdminForm();
                    af.Show();
                }
                else if (!isUsername)
                {
                    MessageBox.Show("UserName is Not Correct", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernametextBox1.Clear();
                    passwordtextBox2.Clear();
                    usernametextBox1.Focus();
                }
                else
                {
                    MessageBox.Show("Password is Not Correct", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passwordtextBox2.Clear();
                    passwordtextBox2.Focus();
                }
            }
        }

        private bool isEmpty()
        {
            if (usernametextBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("UserName is Required","Error!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                usernametextBox1.Focus();
                return false;
            }
            if (passwordtextBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Password is Required", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordtextBox2.Focus();
                return false;
            }
            return true;
        }

        private void getLoginMethod(out bool isUsername, out bool isPassword)
        {
            
            string connectionString = ConfigurationManager.ConnectionStrings["edb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("spl",conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@isu", SqlDbType.Bit).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@isp", SqlDbType.Bit).Direction = ParameterDirection.Output;
            cmd.Parameters.AddWithValue("@u", usernametextBox1.Text.Trim());
            cmd.Parameters.AddWithValue("@p", passwordtextBox2.Text.Trim());

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            isUsername =(bool) cmd.Parameters["@isu"].Value;
            isPassword = (bool)cmd.Parameters["@isp"].Value;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ShowAndNotShowPasswordMethod();
        }

        private void ShowAndNotShowPasswordMethod()
        {
            if (passswordcheckBox1.Checked )
            {
                passwordtextBox2.PasswordChar = default(char);
            }
            if (!passswordcheckBox1.Checked)
            {
                passwordtextBox2.PasswordChar =Convert.ToChar("*");
            }
        }
    }
}
