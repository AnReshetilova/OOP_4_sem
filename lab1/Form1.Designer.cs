
namespace lab1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CALC_groupBox = new System.Windows.Forms.GroupBox();
            this.RESET_button = new System.Windows.Forms.Button();
            this.NOT_button = new System.Windows.Forms.Button();
            this.OR_button = new System.Windows.Forms.Button();
            this.AND_button = new System.Windows.Forms.Button();
            this.NULL_button = new System.Windows.Forms.Button();
            this.ONE_button = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.GO_button = new System.Windows.Forms.Button();
            this.style_groupBox = new System.Windows.Forms.GroupBox();
            this.hexadecimal_radioButton = new System.Windows.Forms.RadioButton();
            this.decimal_radioButton = new System.Windows.Forms.RadioButton();
            this.octal_radioButton = new System.Windows.Forms.RadioButton();
            this.binary_radioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CALC_groupBox.SuspendLayout();
            this.style_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CALC_groupBox
            // 
            this.CALC_groupBox.Controls.Add(this.RESET_button);
            this.CALC_groupBox.Controls.Add(this.NOT_button);
            this.CALC_groupBox.Controls.Add(this.OR_button);
            this.CALC_groupBox.Controls.Add(this.AND_button);
            this.CALC_groupBox.Controls.Add(this.NULL_button);
            this.CALC_groupBox.Controls.Add(this.ONE_button);
            this.CALC_groupBox.Controls.Add(this.textBox);
            this.CALC_groupBox.Location = new System.Drawing.Point(12, 12);
            this.CALC_groupBox.Name = "CALC_groupBox";
            this.CALC_groupBox.Size = new System.Drawing.Size(447, 332);
            this.CALC_groupBox.TabIndex = 0;
            this.CALC_groupBox.TabStop = false;
            this.CALC_groupBox.Text = "Calculator (:";
            // 
            // RESET_button
            // 
            this.RESET_button.Location = new System.Drawing.Point(313, 220);
            this.RESET_button.Name = "RESET_button";
            this.RESET_button.Size = new System.Drawing.Size(128, 104);
            this.RESET_button.TabIndex = 7;
            this.RESET_button.Text = "RESET";
            this.RESET_button.UseVisualStyleBackColor = true;
            this.RESET_button.Click += new System.EventHandler(this.RESET_button_Click);
            // 
            // NOT_button
            // 
            this.NOT_button.Location = new System.Drawing.Point(8, 275);
            this.NOT_button.Name = "NOT_button";
            this.NOT_button.Size = new System.Drawing.Size(299, 49);
            this.NOT_button.TabIndex = 5;
            this.NOT_button.Text = "NOT";
            this.NOT_button.UseVisualStyleBackColor = true;
            this.NOT_button.Click += new System.EventHandler(this.NOT_button_Click);
            // 
            // OR_button
            // 
            this.OR_button.Location = new System.Drawing.Point(8, 220);
            this.OR_button.Name = "OR_button";
            this.OR_button.Size = new System.Drawing.Size(299, 49);
            this.OR_button.TabIndex = 4;
            this.OR_button.Text = "OR";
            this.OR_button.UseVisualStyleBackColor = true;
            this.OR_button.Click += new System.EventHandler(this.OR_button_Click);
            // 
            // AND_button
            // 
            this.AND_button.Location = new System.Drawing.Point(7, 165);
            this.AND_button.Name = "AND_button";
            this.AND_button.Size = new System.Drawing.Size(299, 49);
            this.AND_button.TabIndex = 3;
            this.AND_button.Text = "AND";
            this.AND_button.UseVisualStyleBackColor = true;
            this.AND_button.Click += new System.EventHandler(this.AND_button_Click);
            // 
            // NULL_button
            // 
            this.NULL_button.Location = new System.Drawing.Point(159, 70);
            this.NULL_button.Name = "NULL_button";
            this.NULL_button.Size = new System.Drawing.Size(147, 88);
            this.NULL_button.TabIndex = 2;
            this.NULL_button.Text = "0";
            this.NULL_button.UseVisualStyleBackColor = true;
            this.NULL_button.Click += new System.EventHandler(this.NULL_button_Click);
            // 
            // ONE_button
            // 
            this.ONE_button.Location = new System.Drawing.Point(6, 70);
            this.ONE_button.Name = "ONE_button";
            this.ONE_button.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ONE_button.Size = new System.Drawing.Size(147, 88);
            this.ONE_button.TabIndex = 1;
            this.ONE_button.Text = "1";
            this.ONE_button.UseVisualStyleBackColor = true;
            this.ONE_button.Click += new System.EventHandler(this.ONE_button_Click);
            // 
            // textBox
            // 
            this.textBox.Enabled = false;
            this.textBox.Location = new System.Drawing.Point(6, 37);
            this.textBox.MaxLength = 20;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(435, 27);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "00000000000000000000";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GO_button
            // 
            this.GO_button.Location = new System.Drawing.Point(324, 82);
            this.GO_button.Name = "GO_button";
            this.GO_button.Size = new System.Drawing.Size(129, 144);
            this.GO_button.TabIndex = 6;
            this.GO_button.Text = "GO!";
            this.GO_button.UseVisualStyleBackColor = true;
            this.GO_button.Click += new System.EventHandler(this.GO_button_Click);
            // 
            // style_groupBox
            // 
            this.style_groupBox.Controls.Add(this.hexadecimal_radioButton);
            this.style_groupBox.Controls.Add(this.decimal_radioButton);
            this.style_groupBox.Controls.Add(this.octal_radioButton);
            this.style_groupBox.Controls.Add(this.binary_radioButton);
            this.style_groupBox.Location = new System.Drawing.Point(459, 198);
            this.style_groupBox.Name = "style_groupBox";
            this.style_groupBox.Size = new System.Drawing.Size(189, 146);
            this.style_groupBox.TabIndex = 7;
            this.style_groupBox.TabStop = false;
            this.style_groupBox.Text = "Style";
            // 
            // hexadecimal_radioButton
            // 
            this.hexadecimal_radioButton.AutoSize = true;
            this.hexadecimal_radioButton.Location = new System.Drawing.Point(6, 107);
            this.hexadecimal_radioButton.Name = "hexadecimal_radioButton";
            this.hexadecimal_radioButton.Size = new System.Drawing.Size(46, 24);
            this.hexadecimal_radioButton.TabIndex = 3;
            this.hexadecimal_radioButton.Text = "16";
            this.hexadecimal_radioButton.UseVisualStyleBackColor = true;
            this.hexadecimal_radioButton.CheckedChanged += new System.EventHandler(this.hexadecimal_radioButton_CheckedChanged);
            // 
            // decimal_radioButton
            // 
            this.decimal_radioButton.AutoSize = true;
            this.decimal_radioButton.Location = new System.Drawing.Point(7, 80);
            this.decimal_radioButton.Name = "decimal_radioButton";
            this.decimal_radioButton.Size = new System.Drawing.Size(46, 24);
            this.decimal_radioButton.TabIndex = 2;
            this.decimal_radioButton.Text = "10";
            this.decimal_radioButton.UseVisualStyleBackColor = true;
            this.decimal_radioButton.CheckedChanged += new System.EventHandler(this.decimal_radioButton_CheckedChanged);
            // 
            // octal_radioButton
            // 
            this.octal_radioButton.AutoSize = true;
            this.octal_radioButton.Location = new System.Drawing.Point(7, 53);
            this.octal_radioButton.Name = "octal_radioButton";
            this.octal_radioButton.Size = new System.Drawing.Size(38, 24);
            this.octal_radioButton.TabIndex = 1;
            this.octal_radioButton.Text = "8";
            this.octal_radioButton.UseVisualStyleBackColor = true;
            this.octal_radioButton.CheckedChanged += new System.EventHandler(this.octal_radioButton_CheckedChanged);
            // 
            // binary_radioButton
            // 
            this.binary_radioButton.AutoSize = true;
            this.binary_radioButton.Checked = true;
            this.binary_radioButton.Location = new System.Drawing.Point(7, 27);
            this.binary_radioButton.Name = "binary_radioButton";
            this.binary_radioButton.Size = new System.Drawing.Size(38, 24);
            this.binary_radioButton.TabIndex = 0;
            this.binary_radioButton.TabStop = true;
            this.binary_radioButton.Text = "2";
            this.binary_radioButton.UseVisualStyleBackColor = true;
            this.binary_radioButton.CheckedChanged += new System.EventHandler(this.binary_radioButton_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::lab1.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(486, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 166);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 353);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.style_groupBox);
            this.Controls.Add(this.GO_button);
            this.Controls.Add(this.CALC_groupBox);
            this.MaximumSize = new System.Drawing.Size(684, 400);
            this.MinimumSize = new System.Drawing.Size(684, 400);
            this.Name = "Form1";
            this.Text = "Paimon\'s calculator";
            this.CALC_groupBox.ResumeLayout(false);
            this.CALC_groupBox.PerformLayout();
            this.style_groupBox.ResumeLayout(false);
            this.style_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CALC_groupBox;
        private System.Windows.Forms.Button GO_button;
        private System.Windows.Forms.Button NOT_button;
        private System.Windows.Forms.Button OR_button;
        private System.Windows.Forms.Button AND_button;
        private System.Windows.Forms.Button NULL_button;
        private System.Windows.Forms.Button ONE_button;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button RESET_button;
        private System.Windows.Forms.GroupBox style_groupBox;
        private System.Windows.Forms.RadioButton hexadecimal_radioButton;
        private System.Windows.Forms.RadioButton decimal_radioButton;
        private System.Windows.Forms.RadioButton octal_radioButton;
        private System.Windows.Forms.RadioButton binary_radioButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

