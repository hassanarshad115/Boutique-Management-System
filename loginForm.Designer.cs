namespace EBMS
{
    partial class loginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.usernametextBox1 = new System.Windows.Forms.TextBox();
            this.loginbutton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passswordcheckBox1 = new System.Windows.Forms.CheckBox();
            this.passwordtextBox2 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // usernametextBox1
            // 
            this.usernametextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametextBox1.Location = new System.Drawing.Point(149, 29);
            this.usernametextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.usernametextBox1.Name = "usernametextBox1";
            this.usernametextBox1.Size = new System.Drawing.Size(152, 23);
            this.usernametextBox1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.usernametextBox1, "Enter Employee Name");
            // 
            // loginbutton1
            // 
            this.loginbutton1.BackColor = System.Drawing.Color.Maroon;
            this.loginbutton1.FlatAppearance.BorderSize = 0;
            this.loginbutton1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginbutton1.Location = new System.Drawing.Point(149, 133);
            this.loginbutton1.Margin = new System.Windows.Forms.Padding(4);
            this.loginbutton1.Name = "loginbutton1";
            this.loginbutton1.Size = new System.Drawing.Size(53, 35);
            this.loginbutton1.TabIndex = 2;
            this.loginbutton1.Text = "Login";
            this.toolTip1.SetToolTip(this.loginbutton1, "Click for login");
            this.loginbutton1.UseVisualStyleBackColor = false;
            this.loginbutton1.Click += new System.EventHandler(this.loginbutton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(37, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // passswordcheckBox1
            // 
            this.passswordcheckBox1.AutoSize = true;
            this.passswordcheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.passswordcheckBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passswordcheckBox1.Location = new System.Drawing.Point(149, 112);
            this.passswordcheckBox1.Name = "passswordcheckBox1";
            this.passswordcheckBox1.Size = new System.Drawing.Size(102, 17);
            this.passswordcheckBox1.TabIndex = 3;
            this.passswordcheckBox1.Text = "Show Password";
            this.toolTip1.SetToolTip(this.passswordcheckBox1, "Show Password");
            this.passswordcheckBox1.UseVisualStyleBackColor = false;
            this.passswordcheckBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // passwordtextBox2
            // 
            this.passwordtextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtextBox2.Location = new System.Drawing.Point(149, 64);
            this.passwordtextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.passwordtextBox2.Name = "passwordtextBox2";
            this.passwordtextBox2.PasswordChar = '*';
            this.passwordtextBox2.Size = new System.Drawing.Size(152, 23);
            this.passwordtextBox2.TabIndex = 1;
            this.toolTip1.SetToolTip(this.passwordtextBox2, "Password");
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EBMS.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(326, 202);
            this.Controls.Add(this.passswordcheckBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordtextBox2);
            this.Controls.Add(this.usernametextBox1);
            this.Controls.Add(this.loginbutton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "loginForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox usernametextBox1;
        private System.Windows.Forms.Button loginbutton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox passswordcheckBox1;
        private System.Windows.Forms.TextBox passwordtextBox2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

