
namespace lab2
{
    partial class MENU_Form
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
            this.ADDPRODUCT_button = new System.Windows.Forms.Button();
            this.ADDSTOREKEEPER_button = new System.Windows.Forms.Button();
            this.ADDMANUFACTURER_button = new System.Windows.Forms.Button();
            this.VIEWGOODS_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ADDPRODUCT_button
            // 
            this.ADDPRODUCT_button.Location = new System.Drawing.Point(302, 201);
            this.ADDPRODUCT_button.Name = "ADDPRODUCT_button";
            this.ADDPRODUCT_button.Size = new System.Drawing.Size(273, 83);
            this.ADDPRODUCT_button.TabIndex = 0;
            this.ADDPRODUCT_button.Text = "ADD PRODUCT\r\n";
            this.ADDPRODUCT_button.UseVisualStyleBackColor = true;
            this.ADDPRODUCT_button.Click += new System.EventHandler(this.ADDPRODUCT_button_Click);
            // 
            // ADDSTOREKEEPER_button
            // 
            this.ADDSTOREKEEPER_button.Location = new System.Drawing.Point(12, 303);
            this.ADDSTOREKEEPER_button.Name = "ADDSTOREKEEPER_button";
            this.ADDSTOREKEEPER_button.Size = new System.Drawing.Size(273, 83);
            this.ADDSTOREKEEPER_button.TabIndex = 1;
            this.ADDSTOREKEEPER_button.Text = "ADD STOREKEEPER";
            this.ADDSTOREKEEPER_button.UseVisualStyleBackColor = true;
            this.ADDSTOREKEEPER_button.Click += new System.EventHandler(this.ADDSTOREKEEPER_button_Click);
            // 
            // ADDMANUFACTURER_button
            // 
            this.ADDMANUFACTURER_button.Location = new System.Drawing.Point(12, 201);
            this.ADDMANUFACTURER_button.Name = "ADDMANUFACTURER_button";
            this.ADDMANUFACTURER_button.Size = new System.Drawing.Size(273, 83);
            this.ADDMANUFACTURER_button.TabIndex = 2;
            this.ADDMANUFACTURER_button.Text = "ADD MANUFACTURER";
            this.ADDMANUFACTURER_button.UseVisualStyleBackColor = true;
            this.ADDMANUFACTURER_button.Click += new System.EventHandler(this.ADDMANUFACTURER_button_Click);
            // 
            // VIEWGOODS_button
            // 
            this.VIEWGOODS_button.Location = new System.Drawing.Point(302, 303);
            this.VIEWGOODS_button.Name = "VIEWGOODS_button";
            this.VIEWGOODS_button.Size = new System.Drawing.Size(273, 83);
            this.VIEWGOODS_button.TabIndex = 3;
            this.VIEWGOODS_button.Text = "VIEW GOODS\n";
            this.VIEWGOODS_button.UseVisualStyleBackColor = true;
            this.VIEWGOODS_button.Click += new System.EventHandler(this.VIEWGOODS_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::lab2.Properties.Resources.genshin_impact_mora_moneda_gastar;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(563, 163);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MENU_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 400);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.VIEWGOODS_button);
            this.Controls.Add(this.ADDMANUFACTURER_button);
            this.Controls.Add(this.ADDSTOREKEEPER_button);
            this.Controls.Add(this.ADDPRODUCT_button);
            this.Name = "MENU_Form";
            this.Text = "SHOP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MENU_Form_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ADDPRODUCT_button;
        private System.Windows.Forms.Button ADDSTOREKEEPER_button;
        private System.Windows.Forms.Button ADDMANUFACTURER_button;
        private System.Windows.Forms.Button VIEWGOODS_button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

