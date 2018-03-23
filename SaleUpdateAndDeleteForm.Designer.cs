namespace EBMS
{
    partial class SaleUpdateAndDeleteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleUpdateAndDeleteForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteBotton = new System.Windows.Forms.Button();
            this.insertBotton = new System.Windows.Forms.Button();
            this.pricePerItemtextBox = new System.Windows.Forms.TextBox();
            this.dressnametextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.QuantitytextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.deleteBotton);
            this.groupBox1.Controls.Add(this.insertBotton);
            this.groupBox1.Controls.Add(this.QuantitytextBox);
            this.groupBox1.Controls.Add(this.pricePerItemtextBox);
            this.groupBox1.Controls.Add(this.dressnametextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(401, 171);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // deleteBotton
            // 
            this.deleteBotton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBotton.Location = new System.Drawing.Point(288, 122);
            this.deleteBotton.Name = "deleteBotton";
            this.deleteBotton.Size = new System.Drawing.Size(105, 36);
            this.deleteBotton.TabIndex = 4;
            this.deleteBotton.Text = "Delete";
            this.deleteBotton.UseVisualStyleBackColor = true;
            this.deleteBotton.Click += new System.EventHandler(this.deleteBotton_Click);
            // 
            // insertBotton
            // 
            this.insertBotton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBotton.Location = new System.Drawing.Point(154, 122);
            this.insertBotton.Name = "insertBotton";
            this.insertBotton.Size = new System.Drawing.Size(116, 36);
            this.insertBotton.TabIndex = 3;
            this.insertBotton.Text = "&Update";
            this.insertBotton.UseVisualStyleBackColor = true;
            this.insertBotton.Click += new System.EventHandler(this.insertBotton_Click);
            // 
            // pricePerItemtextBox
            // 
            this.pricePerItemtextBox.Location = new System.Drawing.Point(154, 53);
            this.pricePerItemtextBox.Name = "pricePerItemtextBox";
            this.pricePerItemtextBox.Size = new System.Drawing.Size(239, 26);
            this.pricePerItemtextBox.TabIndex = 1;
            // 
            // dressnametextBox
            // 
            this.dressnametextBox.Location = new System.Drawing.Point(154, 19);
            this.dressnametextBox.Name = "dressnametextBox";
            this.dressnametextBox.Size = new System.Drawing.Size(239, 26);
            this.dressnametextBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(51, 88);
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
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(5, 56);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Price Per Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dress Name";
            // 
            // QuantitytextBox
            // 
            this.QuantitytextBox.Location = new System.Drawing.Point(154, 85);
            this.QuantitytextBox.Name = "QuantitytextBox";
            this.QuantitytextBox.Size = new System.Drawing.Size(239, 26);
            this.QuantitytextBox.TabIndex = 2;
            // 
            // SaleUpdateAndDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EBMS.Properties.Resources.saleDetail;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(424, 191);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SaleUpdateAndDeleteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaleUpdateAndDeleteForm";
            this.Load += new System.EventHandler(this.SaleUpdateAndDeleteForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteBotton;
        private System.Windows.Forms.Button insertBotton;
        private System.Windows.Forms.TextBox pricePerItemtextBox;
        private System.Windows.Forms.TextBox dressnametextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox QuantitytextBox;
    }
}