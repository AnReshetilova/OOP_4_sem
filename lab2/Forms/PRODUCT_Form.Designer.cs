
namespace lab2
{
    partial class PRODUCT_Form
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NAME_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SIZE_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.WEIGTH_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TYPE_comboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MANUFACTURER_comboBox = new System.Windows.Forms.ComboBox();
            this.ADDMANUFACT_label = new System.Windows.Forms.Label();
            this.ADD_STOREKEEPlabel = new System.Windows.Forms.Label();
            this.STOREKEEPER_comboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ADD_button = new System.Windows.Forms.Button();
            this.COUNT_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NUMBER_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.COUNT_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::lab2.Properties.Resources.ae9609d69b7c95ba20b950517ab84e6b_806420064129548979;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // NAME_textBox
            // 
            this.NAME_textBox.Location = new System.Drawing.Point(147, 41);
            this.NAME_textBox.Name = "NAME_textBox";
            this.NAME_textBox.Size = new System.Drawing.Size(158, 27);
            this.NAME_textBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(146, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(146, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "NUMBER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(242, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "SIZE";
            // 
            // SIZE_maskedTextBox
            // 
            this.SIZE_maskedTextBox.Location = new System.Drawing.Point(242, 105);
            this.SIZE_maskedTextBox.Mask = "00000";
            this.SIZE_maskedTextBox.Name = "SIZE_maskedTextBox";
            this.SIZE_maskedTextBox.Size = new System.Drawing.Size(63, 27);
            this.SIZE_maskedTextBox.TabIndex = 10;
            this.SIZE_maskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SIZE_maskedTextBox.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "WEIGHT";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 178);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(292, 29);
            this.progressBar1.TabIndex = 12;
            // 
            // WEIGTH_maskedTextBox
            // 
            this.WEIGTH_maskedTextBox.Location = new System.Drawing.Point(102, 148);
            this.WEIGTH_maskedTextBox.Mask = "000";
            this.WEIGTH_maskedTextBox.Name = "WEIGTH_maskedTextBox";
            this.WEIGTH_maskedTextBox.Size = new System.Drawing.Size(51, 27);
            this.WEIGTH_maskedTextBox.TabIndex = 13;
            this.WEIGTH_maskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WEIGTH_maskedTextBox.ValidatingType = typeof(int);
            this.WEIGTH_maskedTextBox.TextChanged += new System.EventHandler(this.WEIGTH_maskedTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(161, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "COUNT";
            // 
            // TYPE_comboBox
            // 
            this.TYPE_comboBox.FormattingEnabled = true;
            this.TYPE_comboBox.Items.AddRange(new object[] {
            "food",
            "garden",
            "housing",
            "appliances",
            "chemicals"});
            this.TYPE_comboBox.Location = new System.Drawing.Point(102, 210);
            this.TYPE_comboBox.Name = "TYPE_comboBox";
            this.TYPE_comboBox.Size = new System.Drawing.Size(203, 28);
            this.TYPE_comboBox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "TYPE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(13, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "MANUFACTURER";
            // 
            // MANUFACTURER_comboBox
            // 
            this.MANUFACTURER_comboBox.FormattingEnabled = true;
            this.MANUFACTURER_comboBox.Location = new System.Drawing.Point(173, 244);
            this.MANUFACTURER_comboBox.Name = "MANUFACTURER_comboBox";
            this.MANUFACTURER_comboBox.Size = new System.Drawing.Size(131, 28);
            this.MANUFACTURER_comboBox.TabIndex = 19;
            // 
            // ADDMANUFACT_label
            // 
            this.ADDMANUFACT_label.AutoSize = true;
            this.ADDMANUFACT_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.ADDMANUFACT_label.Location = new System.Drawing.Point(178, 275);
            this.ADDMANUFACT_label.Name = "ADDMANUFACT_label";
            this.ADDMANUFACT_label.Size = new System.Drawing.Size(127, 20);
            this.ADDMANUFACT_label.TabIndex = 20;
            this.ADDMANUFACT_label.Text = "add manufacturer";
            this.ADDMANUFACT_label.Click += new System.EventHandler(this.ADDMANUFACT_label_Click);
            // 
            // ADD_STOREKEEPlabel
            // 
            this.ADD_STOREKEEPlabel.AutoSize = true;
            this.ADD_STOREKEEPlabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.ADD_STOREKEEPlabel.Location = new System.Drawing.Point(178, 335);
            this.ADD_STOREKEEPlabel.Name = "ADD_STOREKEEPlabel";
            this.ADD_STOREKEEPlabel.Size = new System.Drawing.Size(117, 20);
            this.ADD_STOREKEEPlabel.TabIndex = 23;
            this.ADD_STOREKEEPlabel.Text = "add storekeeper";
            this.ADD_STOREKEEPlabel.Click += new System.EventHandler(this.ADD_STOREKEEPlabel_Click);
            // 
            // STOREKEEPER_comboBox
            // 
            this.STOREKEEPER_comboBox.FormattingEnabled = true;
            this.STOREKEEPER_comboBox.Location = new System.Drawing.Point(173, 304);
            this.STOREKEEPER_comboBox.Name = "STOREKEEPER_comboBox";
            this.STOREKEEPER_comboBox.Size = new System.Drawing.Size(131, 28);
            this.STOREKEEPER_comboBox.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(13, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 25);
            this.label10.TabIndex = 21;
            this.label10.Text = "STOREKEEPER";
            // 
            // ADD_button
            // 
            this.ADD_button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ADD_button.Location = new System.Drawing.Point(8, 358);
            this.ADD_button.MaximumSize = new System.Drawing.Size(296, 48);
            this.ADD_button.MinimumSize = new System.Drawing.Size(296, 48);
            this.ADD_button.Name = "ADD_button";
            this.ADD_button.Size = new System.Drawing.Size(296, 48);
            this.ADD_button.TabIndex = 24;
            this.ADD_button.Text = "ADD";
            this.ADD_button.UseVisualStyleBackColor = true;
            this.ADD_button.Click += new System.EventHandler(this.ADD_button_Click);
            // 
            // COUNT_numericUpDown
            // 
            this.COUNT_numericUpDown.Location = new System.Drawing.Point(242, 148);
            this.COUNT_numericUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.COUNT_numericUpDown.Name = "COUNT_numericUpDown";
            this.COUNT_numericUpDown.Size = new System.Drawing.Size(63, 27);
            this.COUNT_numericUpDown.TabIndex = 25;
            // 
            // NUMBER_maskedTextBox
            // 
            this.NUMBER_maskedTextBox.Location = new System.Drawing.Point(149, 105);
            this.NUMBER_maskedTextBox.Mask = "00000";
            this.NUMBER_maskedTextBox.Name = "NUMBER_maskedTextBox";
            this.NUMBER_maskedTextBox.Size = new System.Drawing.Size(63, 27);
            this.NUMBER_maskedTextBox.TabIndex = 26;
            this.NUMBER_maskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUMBER_maskedTextBox.ValidatingType = typeof(int);
            // 
            // PRODUCT_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 418);
            this.Controls.Add(this.NUMBER_maskedTextBox);
            this.Controls.Add(this.COUNT_numericUpDown);
            this.Controls.Add(this.ADD_button);
            this.Controls.Add(this.ADD_STOREKEEPlabel);
            this.Controls.Add(this.STOREKEEPER_comboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ADDMANUFACT_label);
            this.Controls.Add(this.MANUFACTURER_comboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TYPE_comboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.WEIGTH_maskedTextBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SIZE_maskedTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NAME_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PRODUCT_Form";
            this.Text = "PRODUCT_Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.COUNT_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox NAME_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox SIZE_maskedTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.MaskedTextBox WEIGTH_maskedTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TYPE_comboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox MANUFACTURER_comboBox;
        private System.Windows.Forms.Label ADDMANUFACT_label;
        private System.Windows.Forms.Label ADD_STOREKEEPlabel;
        private System.Windows.Forms.ComboBox STOREKEEPER_comboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ADD_button;
        private System.Windows.Forms.NumericUpDown COUNT_numericUpDown;
        private System.Windows.Forms.MaskedTextBox NUMBER_maskedTextBox;
    }
}