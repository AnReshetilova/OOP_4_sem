
namespace lab2.Forms
{
    partial class GOODS_Form
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
            this.GOODS_dataGridView = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManufacturerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StorekeeperName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.MANUFACTURERS_dataGridView = new System.Windows.Forms.DataGridView();
            this.Organisation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STOREKEEPERS_dataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pipidastr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Experience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GOODS_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MANUFACTURERS_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.STOREKEEPERS_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GOODS_dataGridView
            // 
            this.GOODS_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GOODS_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GOODS_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Number,
            this.Size,
            this.Weight,
            this.Type,
            this.Count,
            this.ManufacturerName,
            this.StorekeeperName});
            this.GOODS_dataGridView.Location = new System.Drawing.Point(12, 62);
            this.GOODS_dataGridView.Name = "GOODS_dataGridView";
            this.GOODS_dataGridView.ReadOnly = true;
            this.GOODS_dataGridView.RowHeadersVisible = false;
            this.GOODS_dataGridView.RowHeadersWidth = 51;
            this.GOODS_dataGridView.RowTemplate.Height = 29;
            this.GOODS_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GOODS_dataGridView.Size = new System.Drawing.Size(684, 213);
            this.GOODS_dataGridView.TabIndex = 0;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 80;
            // 
            // Number
            // 
            this.Number.HeaderText = "Number";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 80;
            // 
            // Size
            // 
            this.Size.HeaderText = "Size";
            this.Size.MinimumWidth = 6;
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            this.Size.Width = 60;
            // 
            // Weight
            // 
            this.Weight.HeaderText = "Weight";
            this.Weight.MinimumWidth = 6;
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            this.Weight.Width = 80;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 80;
            // 
            // Count
            // 
            this.Count.HeaderText = "Count";
            this.Count.MinimumWidth = 6;
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Width = 60;
            // 
            // ManufacturerName
            // 
            this.ManufacturerName.HeaderText = "Manufacturer";
            this.ManufacturerName.MinimumWidth = 6;
            this.ManufacturerName.Name = "ManufacturerName";
            this.ManufacturerName.ReadOnly = true;
            this.ManufacturerName.Width = 120;
            // 
            // StorekeeperName
            // 
            this.StorekeeperName.HeaderText = "Storekeeper";
            this.StorekeeperName.MinimumWidth = 6;
            this.StorekeeperName.Name = "StorekeeperName";
            this.StorekeeperName.ReadOnly = true;
            this.StorekeeperName.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(286, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "GOODS";
            // 
            // MANUFACTURERS_dataGridView
            // 
            this.MANUFACTURERS_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MANUFACTURERS_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MANUFACTURERS_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Organisation,
            this.Country,
            this.Address,
            this.Phone});
            this.MANUFACTURERS_dataGridView.Location = new System.Drawing.Point(12, 359);
            this.MANUFACTURERS_dataGridView.Name = "MANUFACTURERS_dataGridView";
            this.MANUFACTURERS_dataGridView.ReadOnly = true;
            this.MANUFACTURERS_dataGridView.RowHeadersVisible = false;
            this.MANUFACTURERS_dataGridView.RowHeadersWidth = 51;
            this.MANUFACTURERS_dataGridView.RowTemplate.Height = 29;
            this.MANUFACTURERS_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MANUFACTURERS_dataGridView.Size = new System.Drawing.Size(370, 213);
            this.MANUFACTURERS_dataGridView.TabIndex = 2;
            // 
            // Organisation
            // 
            this.Organisation.HeaderText = "Organisation";
            this.Organisation.MinimumWidth = 6;
            this.Organisation.Name = "Organisation";
            this.Organisation.ReadOnly = true;
            this.Organisation.Width = 125;
            // 
            // Country
            // 
            this.Country.HeaderText = "Country";
            this.Country.MinimumWidth = 6;
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            this.Country.Width = 80;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 80;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 80;
            // 
            // STOREKEEPERS_dataGridView
            // 
            this.STOREKEEPERS_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.STOREKEEPERS_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.STOREKEEPERS_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pipidastr,
            this.Experience,
            this.dataGridViewTextBoxColumn2});
            this.STOREKEEPERS_dataGridView.Location = new System.Drawing.Point(407, 359);
            this.STOREKEEPERS_dataGridView.Name = "STOREKEEPERS_dataGridView";
            this.STOREKEEPERS_dataGridView.ReadOnly = true;
            this.STOREKEEPERS_dataGridView.RowHeadersVisible = false;
            this.STOREKEEPERS_dataGridView.RowHeadersWidth = 51;
            this.STOREKEEPERS_dataGridView.RowTemplate.Height = 29;
            this.STOREKEEPERS_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.STOREKEEPERS_dataGridView.Size = new System.Drawing.Size(289, 213);
            this.STOREKEEPERS_dataGridView.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 50);
            this.label2.TabIndex = 4;
            this.label2.Text = "MANUFACTURERS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(407, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "STOREKEEPERS";
            // 
            // pipidastr
            // 
            this.pipidastr.HeaderText = "Name";
            this.pipidastr.MinimumWidth = 6;
            this.pipidastr.Name = "pipidastr";
            this.pipidastr.ReadOnly = true;
            this.pipidastr.Width = 80;
            // 
            // Experience
            // 
            this.Experience.HeaderText = "Experience";
            this.Experience.MinimumWidth = 6;
            this.Experience.Name = "Experience";
            this.Experience.ReadOnly = true;
            this.Experience.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Address";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // GOODS_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 584);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.STOREKEEPERS_dataGridView);
            this.Controls.Add(this.MANUFACTURERS_dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GOODS_dataGridView);
            this.MaximumSize = new System.Drawing.Size(728, 631);
            this.MinimumSize = new System.Drawing.Size(728, 631);
            this.Name = "GOODS_Form";
            this.Text = "GOODS_Form";
            this.Load += new System.EventHandler(this.GOODS_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GOODS_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MANUFACTURERS_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.STOREKEEPERS_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GOODS_dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView MANUFACTURERS_dataGridView;
        private System.Windows.Forms.DataGridView STOREKEEPERS_dataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Organisation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufacturerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StorekeeperName;
        private System.Windows.Forms.DataGridViewTextBoxColumn pipidastr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Experience;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}