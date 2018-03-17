using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBMS
{
    public partial class logoForm : Form
    {
        public logoForm()
        {
            InitializeComponent();
        }

        private void logoForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int a = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            a++;
            if (a == 20)
            {
                this.Hide();
                loginForm l = new loginForm();
                l.Show();
            }
        }
    }
}
