namespace EBMS
{
    partial class PurchaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseForm));
            this.deleteBotton = new System.Windows.Forms.Button();
            this.insertBotton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datepurchasedatetime = new System.Windows.Forms.DateTimePicker();
            this.descriptionrichTextBox = new System.Windows.Forms.RichTextBox();
            this.QuantitytextBox = new System.Windows.Forms.TextBox();
            this.pricePerItemtextBox = new System.Windows.Forms.TextBox();
            this.dressizetextBox = new System.Windows.Forms.TextBox();
            this.dressnametextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteBotton
            // 
            this.deleteBotton.Enabled = false;
            this.deleteBotton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBotton.Location = new System.Drawing.Point(325, 275);
            this.deleteBotton.Name = "deleteBotton";
            this.deleteBotton.Size = new System.Drawing.Size(105, 36);
            this.deleteBotton.TabIndex = 7;
            this.deleteBotton.Text = "Delete";
            this.deleteBotton.UseVisualStyleBackColor = true;
            this.deleteBotton.Click += new System.EventHandler(this.deleteBotton_Click);
            // 
            // insertBotton
            // 
            this.insertBotton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBotton.Location = new System.Drawing.Point(191, 275);
            this.insertBotton.Name = "insertBotton";
            this.insertBotton.Size = new System.Drawing.Size(116, 36);
            this.insertBotton.TabIndex = 6;
            this.insertBotton.Text = "&Save";
            this.insertBotton.UseVisualStyleBackColor = true;
            this.insertBotton.Click += new System.EventHandler(this.insertBotton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.deleteBotton);
            this.groupBox1.Controls.Add(this.datepurchasedatetime);
            this.groupBox1.Controls.Add(this.insertBotton);
            this.groupBox1.Controls.Add(this.descriptionrichTextBox);
            this.groupBox1.Controls.Add(this.QuantitytextBox);
            this.groupBox1.Controls.Add(this.pricePerItemtextBox);
            this.groupBox1.Controls.Add(this.dressizetextBox);
            this.groupBox1.Controls.Add(this.dressnametextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(462, 316);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // datepurchasedatetime
            // 
            this.datepurchasedatetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepurchasedatetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepurchasedatetime.Location = new System.Drawing.Point(191, 245);
            this.datepurchasedatetime.Name = "datepurchasedatetime";
            this.datepurchasedatetime.Size = new System.Drawing.Size(128, 29);
            this.datepurchasedatetime.TabIndex = 55;
            this.datepurchasedatetime.Value = new System.DateTime(2016, 10, 31, 0, 0, 0, 0);
            // 
            // descriptionrichTextBox
            // 
            this.descriptionrichTextBox.Location = new System.Drawing.Point(191, 153);
            this.descriptionrichTextBox.Name = "descriptionrichTextBox";
            this.descriptionrichTextBox.Size = new System.Drawing.Size(239, 86);
            this.descriptionrichTextBox.TabIndex = 4;
            this.descriptionrichTextBox.Text = "";
            // 
            // QuantitytextBox
            // 
            this.QuantitytextBox.Location = new System.Drawing.Point(191, 121);
            this.QuantitytextBox.Name = "QuantitytextBox";
            this.QuantitytextBox.Size = new System.Drawing.Size(239, 26);
            this.QuantitytextBox.TabIndex = 3;
            this.QuantitytextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantitytextBox_KeyPress);
            // 
            // pricePerItemtextBox
            // 
            this.pricePerItemtextBox.Location = new System.Drawing.Point(191, 89);
            this.pricePerItemtextBox.Name = "pricePerItemtextBox";
            this.pricePerItemtextBox.Size = new System.Drawing.Size(239, 26);
            this.pricePerItemtextBox.TabIndex = 2;
            this.pricePerItemtextBox.TextChanged += new System.EventHandler(this.pricePerItemtextBox_TextChanged);
            this.pricePerItemtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pricePerItemtextBox_KeyPress);
            // 
            // dressizetextBox
            // 
            this.dressizetextBox.Location = new System.Drawing.Point(191, 57);
            this.dressizetextBox.Name = "dressizetextBox";
            this.dressizetextBox.Size = new System.Drawing.Size(239, 26);
            this.dressizetextBox.TabIndex = 1;
            // 
            // dressnametextBox
            // 
            this.dressnametextBox.Location = new System.Drawing.Point(191, 25);
            this.dressnametextBox.Name = "dressnametextBox";
            this.dressnametextBox.Size = new System.Drawing.Size(239, 26);
            this.dressnametextBox.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(36, 246);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Purchase Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(12, 193);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Dress Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(88, 124);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(42, 92);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Price Per Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(68, 60);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dress Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(57, 28);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dress Name";
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EBMS.Properties.Resources._0809122001416642907bjp_dmc_nov_2014_bulletin_021;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(479, 328);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PurchaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseForm";
            this.Load += new System.EventHandler(this.PurchaseForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deleteBotton;
        private System.Windows.Forms.Button insertBotton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker datepurchasedatetime;
        private System.Windows.Forms.RichTextBox descriptionrichTextBox;
        private System.Windows.Forms.TextBox QuantitytextBox;
        private System.Windows.Forms.TextBox pricePerItemtextBox;
        private System.Windows.Forms.TextBox dressizetextBox;
        private System.Windows.Forms.TextBox dressnametextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}