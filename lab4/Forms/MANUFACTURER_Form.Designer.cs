
namespace lab2
{
    partial class MANUFACTURER_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ORGANISATION_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.COUNTRY_comboBox = new System.Windows.Forms.ComboBox();
            this.ADDRESS_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PHONE_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ADD_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(146, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ORGANISATION";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::lab2.Properties.Resources._0efd0157d28c63fb0ac5fc2ca8882797_5519221311532516672;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ORGANISATION_textBox
            // 
            this.ORGANISATION_textBox.Location = new System.Drawing.Point(147, 41);
            this.ORGANISATION_textBox.Name = "ORGANISATION_textBox";
            this.ORGANISATION_textBox.Size = new System.Drawing.Size(158, 27);
            this.ORGANISATION_textBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(147, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "COUNTRY";
            // 
            // COUNTRY_comboBox
            // 
            this.COUNTRY_comboBox.FormattingEnabled = true;
            this.COUNTRY_comboBox.Items.AddRange(new object[] {
            "Belarus",
            "Russia",
            "Ukraine",
            "USA",
            "UK"});
            this.COUNTRY_comboBox.Location = new System.Drawing.Point(147, 112);
            this.COUNTRY_comboBox.Name = "COUNTRY_comboBox";
            this.COUNTRY_comboBox.Size = new System.Drawing.Size(158, 28);
            this.COUNTRY_comboBox.TabIndex = 4;
            // 
            // ADDRESS_textBox
            // 
            this.ADDRESS_textBox.Location = new System.Drawing.Point(12, 186);
            this.ADDRESS_textBox.Name = "ADDRESS_textBox";
            this.ADDRESS_textBox.Size = new System.Drawing.Size(177, 27);
            this.ADDRESS_textBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "ADDRESS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "PHONE";
            // 
            // PHONE_maskedTextBox
            // 
            this.PHONE_maskedTextBox.Location = new System.Drawing.Point(12, 256);
            this.PHONE_maskedTextBox.Mask = "+375 (00) 000-0000";
            this.PHONE_maskedTextBox.Name = "PHONE_maskedTextBox";
            this.PHONE_maskedTextBox.Size = new System.Drawing.Size(177, 27);
            this.PHONE_maskedTextBox.TabIndex = 8;
            this.PHONE_maskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ADD_button
            // 
            this.ADD_button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ADD_button.Location = new System.Drawing.Point(199, 158);
            this.ADD_button.Name = "ADD_button";
            this.ADD_button.Size = new System.Drawing.Size(106, 125);
            this.ADD_button.TabIndex = 9;
            this.ADD_button.Text = "ADD";
            this.ADD_button.UseVisualStyleBackColor = true;
            this.ADD_button.Click += new System.EventHandler(this.ADD_button_Click);
            // 
            // MANUFACTURER_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 300);
            this.Controls.Add(this.ADD_button);
            this.Controls.Add(this.PHONE_maskedTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ADDRESS_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.COUNTRY_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ORGANISATION_textBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(343, 347);
            this.MinimumSize = new System.Drawing.Size(343, 347);
            this.Name = "MANUFACTURER_Form";
            this.Text = "MANUFACTURER_Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ORGANISATION_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox COUNTRY_comboBox;
        private System.Windows.Forms.TextBox ADDRESS_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox PHONE_maskedTextBox;
        private System.Windows.Forms.Button ADD_button;
    }
}