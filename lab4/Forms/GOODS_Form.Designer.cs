
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
            this.pipidastr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Experience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NAMESEARCH_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TYPESEARCH_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SIZESEARCH_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manufacturerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storekeeperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manufacturerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NAMESEARCH_groupBox = new System.Windows.Forms.GroupBox();
            this.NAMESEARCH_button = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.NAMESEARCH_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SIZESEARCH_groupBox = new System.Windows.Forms.GroupBox();
            this.SIZESEARCH_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SIZESEARCH_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TYPESEARCH_groupBox = new System.Windows.Forms.GroupBox();
            this.TYPESEARCH_textBox = new System.Windows.Forms.TextBox();
            this.TYPESEARCH_button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.GOODS_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MANUFACTURERS_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.STOREKEEPERS_dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.NAMESEARCH_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SIZESEARCH_groupBox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.TYPESEARCH_groupBox.SuspendLayout();
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
            this.label1.BackColor = System.Drawing.Color.Transparent;
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.addToolStripMenuItem,
            this.sortByToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.statusBarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(706, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NAMESEARCH_ToolStripMenuItem,
            this.TYPESEARCH_ToolStripMenuItem,
            this.SIZESEARCH_ToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // NAMESEARCH_ToolStripMenuItem
            // 
            this.NAMESEARCH_ToolStripMenuItem.Name = "NAMESEARCH_ToolStripMenuItem";
            this.NAMESEARCH_ToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.NAMESEARCH_ToolStripMenuItem.Text = "Name";
            this.NAMESEARCH_ToolStripMenuItem.Click += new System.EventHandler(this.NAMESEARCH_ToolStripMenuItem_Click);
            // 
            // TYPESEARCH_ToolStripMenuItem
            // 
            this.TYPESEARCH_ToolStripMenuItem.Name = "TYPESEARCH_ToolStripMenuItem";
            this.TYPESEARCH_ToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.TYPESEARCH_ToolStripMenuItem.Text = "Type";
            this.TYPESEARCH_ToolStripMenuItem.Click += new System.EventHandler(this.TYPESEARCH_ToolStripMenuItem_Click);
            // 
            // SIZESEARCH_ToolStripMenuItem
            // 
            this.SIZESEARCH_ToolStripMenuItem.Name = "SIZESEARCH_ToolStripMenuItem";
            this.SIZESEARCH_ToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.SIZESEARCH_ToolStripMenuItem.Text = "Weight";
            this.SIZESEARCH_ToolStripMenuItem.Click += new System.EventHandler(this.SIZESEARCH_ToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manufacturerToolStripMenuItem,
            this.storekeeperToolStripMenuItem,
            this.productToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // manufacturerToolStripMenuItem
            // 
            this.manufacturerToolStripMenuItem.Name = "manufacturerToolStripMenuItem";
            this.manufacturerToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.manufacturerToolStripMenuItem.Text = "Manufacturer";
            this.manufacturerToolStripMenuItem.Click += new System.EventHandler(this.manufacturerToolStripMenuItem_Click);
            // 
            // storekeeperToolStripMenuItem
            // 
            this.storekeeperToolStripMenuItem.Name = "storekeeperToolStripMenuItem";
            this.storekeeperToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.storekeeperToolStripMenuItem.Text = "Storekeeper";
            this.storekeeperToolStripMenuItem.Click += new System.EventHandler(this.storekeeperToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // sortByToolStripMenuItem
            // 
            this.sortByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripMenuItem,
            this.manufacturerToolStripMenuItem1,
            this.sizeToolStripMenuItem});
            this.sortByToolStripMenuItem.Name = "sortByToolStripMenuItem";
            this.sortByToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.sortByToolStripMenuItem.Text = "SortBy";
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.nameToolStripMenuItem.Text = "Name";
            this.nameToolStripMenuItem.Click += new System.EventHandler(this.nameToolStripMenuItem_Click);
            // 
            // manufacturerToolStripMenuItem1
            // 
            this.manufacturerToolStripMenuItem1.Name = "manufacturerToolStripMenuItem1";
            this.manufacturerToolStripMenuItem1.Size = new System.Drawing.Size(180, 26);
            this.manufacturerToolStripMenuItem1.Text = "Manufacturer";
            this.manufacturerToolStripMenuItem1.Click += new System.EventHandler(this.manufacturerToolStripMenuItem1_Click);
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.sizeToolStripMenuItem.Text = "Size";
            this.sizeToolStripMenuItem.Click += new System.EventHandler(this.sizeToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // NAMESEARCH_groupBox
            // 
            this.NAMESEARCH_groupBox.Controls.Add(this.NAMESEARCH_button);
            this.NAMESEARCH_groupBox.Controls.Add(this.radioButton2);
            this.NAMESEARCH_groupBox.Controls.Add(this.radioButton1);
            this.NAMESEARCH_groupBox.Controls.Add(this.label6);
            this.NAMESEARCH_groupBox.Controls.Add(this.numericUpDown1);
            this.NAMESEARCH_groupBox.Controls.Add(this.label5);
            this.NAMESEARCH_groupBox.Controls.Add(this.NAMESEARCH_textBox);
            this.NAMESEARCH_groupBox.Controls.Add(this.label4);
            this.NAMESEARCH_groupBox.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NAMESEARCH_groupBox.Location = new System.Drawing.Point(13, 296);
            this.NAMESEARCH_groupBox.Name = "NAMESEARCH_groupBox";
            this.NAMESEARCH_groupBox.Size = new System.Drawing.Size(683, 276);
            this.NAMESEARCH_groupBox.TabIndex = 7;
            this.NAMESEARCH_groupBox.TabStop = false;
            this.NAMESEARCH_groupBox.Text = "NameSearch";
            this.NAMESEARCH_groupBox.Visible = false;
            // 
            // NAMESEARCH_button
            // 
            this.NAMESEARCH_button.Location = new System.Drawing.Point(90, 158);
            this.NAMESEARCH_button.Name = "NAMESEARCH_button";
            this.NAMESEARCH_button.Size = new System.Drawing.Size(279, 85);
            this.NAMESEARCH_button.TabIndex = 12;
            this.NAMESEARCH_button.Text = "SEARCH";
            this.NAMESEARCH_button.UseVisualStyleBackColor = true;
            this.NAMESEARCH_button.Click += new System.EventHandler(this.NAMESEARCH_button_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(510, 204);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 29);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.Text = "no";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(510, 169);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 29);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "yes";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(451, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 38);
            this.label6.TabIndex = 9;
            this.label6.Text = "check register?";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(543, 70);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(95, 32);
            this.numericUpDown1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(335, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 38);
            this.label5.TabIndex = 7;
            this.label5.Text = "choose length";
            // 
            // NAMESEARCH_textBox
            // 
            this.NAMESEARCH_textBox.Location = new System.Drawing.Point(6, 80);
            this.NAMESEARCH_textBox.Name = "NAMESEARCH_textBox";
            this.NAMESEARCH_textBox.Size = new System.Drawing.Size(280, 32);
            this.NAMESEARCH_textBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 38);
            this.label4.TabIndex = 5;
            this.label4.Text = "enter part of a name";
            // 
            // SIZESEARCH_groupBox
            // 
            this.SIZESEARCH_groupBox.Controls.Add(this.SIZESEARCH_maskedTextBox);
            this.SIZESEARCH_groupBox.Controls.Add(this.SIZESEARCH_button);
            this.SIZESEARCH_groupBox.Controls.Add(this.label7);
            this.SIZESEARCH_groupBox.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SIZESEARCH_groupBox.Location = new System.Drawing.Point(12, 296);
            this.SIZESEARCH_groupBox.Name = "SIZESEARCH_groupBox";
            this.SIZESEARCH_groupBox.Size = new System.Drawing.Size(684, 276);
            this.SIZESEARCH_groupBox.TabIndex = 14;
            this.SIZESEARCH_groupBox.TabStop = false;
            this.SIZESEARCH_groupBox.Text = "WeightSearch";
            this.SIZESEARCH_groupBox.Visible = false;
            // 
            // SIZESEARCH_maskedTextBox
            // 
            this.SIZESEARCH_maskedTextBox.Location = new System.Drawing.Point(302, 121);
            this.SIZESEARCH_maskedTextBox.Mask = "000-000";
            this.SIZESEARCH_maskedTextBox.Name = "SIZESEARCH_maskedTextBox";
            this.SIZESEARCH_maskedTextBox.Size = new System.Drawing.Size(70, 32);
            this.SIZESEARCH_maskedTextBox.TabIndex = 13;
            // 
            // SIZESEARCH_button
            // 
            this.SIZESEARCH_button.Location = new System.Drawing.Point(212, 171);
            this.SIZESEARCH_button.Name = "SIZESEARCH_button";
            this.SIZESEARCH_button.Size = new System.Drawing.Size(280, 85);
            this.SIZESEARCH_button.TabIndex = 12;
            this.SIZESEARCH_button.Text = "SEARCH";
            this.SIZESEARCH_button.UseVisualStyleBackColor = true;
            this.SIZESEARCH_button.Click += new System.EventHandler(this.SIZESEARCH_button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(274, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 38);
            this.label7.TabIndex = 5;
            this.label7.Text = "enter weight";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 577);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(706, 26);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(51, 20);
            this.toolStripStatusLabel1.Text = "Count:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(81, 20);
            this.toolStripStatusLabel2.Text = "LastAction:";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(48, 20);
            this.toolStripStatusLabel3.Text = "Date: ";
            // 
            // TYPESEARCH_groupBox
            // 
            this.TYPESEARCH_groupBox.Controls.Add(this.TYPESEARCH_textBox);
            this.TYPESEARCH_groupBox.Controls.Add(this.TYPESEARCH_button);
            this.TYPESEARCH_groupBox.Controls.Add(this.label8);
            this.TYPESEARCH_groupBox.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TYPESEARCH_groupBox.Location = new System.Drawing.Point(10, 296);
            this.TYPESEARCH_groupBox.Name = "TYPESEARCH_groupBox";
            this.TYPESEARCH_groupBox.Size = new System.Drawing.Size(684, 276);
            this.TYPESEARCH_groupBox.TabIndex = 15;
            this.TYPESEARCH_groupBox.TabStop = false;
            this.TYPESEARCH_groupBox.Text = "TypeSearch";
            this.TYPESEARCH_groupBox.Visible = false;
            // 
            // TYPESEARCH_textBox
            // 
            this.TYPESEARCH_textBox.Location = new System.Drawing.Point(212, 118);
            this.TYPESEARCH_textBox.Name = "TYPESEARCH_textBox";
            this.TYPESEARCH_textBox.Size = new System.Drawing.Size(280, 32);
            this.TYPESEARCH_textBox.TabIndex = 13;
            // 
            // TYPESEARCH_button
            // 
            this.TYPESEARCH_button.Location = new System.Drawing.Point(212, 171);
            this.TYPESEARCH_button.Name = "TYPESEARCH_button";
            this.TYPESEARCH_button.Size = new System.Drawing.Size(280, 85);
            this.TYPESEARCH_button.TabIndex = 12;
            this.TYPESEARCH_button.Text = "SEARCH";
            this.TYPESEARCH_button.UseVisualStyleBackColor = true;
            this.TYPESEARCH_button.Click += new System.EventHandler(this.TYPESEARCH_button_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(274, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 38);
            this.label8.TabIndex = 5;
            this.label8.Text = "enter type";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(18, 20);
            this.toolStripStatusLabel4.Text = "X";
            this.toolStripStatusLabel4.Click += new System.EventHandler(this.toolStripStatusLabel4_Click);
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.statusBarToolStripMenuItem.Text = "View";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.statusBarToolStripMenuItem_Click);
            // 
            // GOODS_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 603);
            this.Controls.Add(this.TYPESEARCH_groupBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.SIZESEARCH_groupBox);
            this.Controls.Add(this.NAMESEARCH_groupBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.STOREKEEPERS_dataGridView);
            this.Controls.Add(this.MANUFACTURERS_dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GOODS_dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(724, 650);
            this.MinimumSize = new System.Drawing.Size(724, 631);
            //this.Name = "GOODS_Form";
            this.Text = "GOODS_Form";
            this.Load += new System.EventHandler(this.GOODS_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GOODS_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MANUFACTURERS_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.STOREKEEPERS_dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.NAMESEARCH_groupBox.ResumeLayout(false);
            this.NAMESEARCH_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.SIZESEARCH_groupBox.ResumeLayout(false);
            this.SIZESEARCH_groupBox.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.TYPESEARCH_groupBox.ResumeLayout(false);
            this.TYPESEARCH_groupBox.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NAMESEARCH_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manufacturerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storekeeperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.GroupBox NAMESEARCH_groupBox;
        private System.Windows.Forms.Button NAMESEARCH_button;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NAMESEARCH_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem TYPESEARCH_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SIZESEARCH_ToolStripMenuItem;
        private System.Windows.Forms.GroupBox SIZESEARCH_groupBox;
        private System.Windows.Forms.Button SIZESEARCH_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox SIZESEARCH_maskedTextBox;
        private System.Windows.Forms.ToolStripMenuItem sortByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manufacturerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.GroupBox TYPESEARCH_groupBox;
        private System.Windows.Forms.Button TYPESEARCH_button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TYPESEARCH_textBox;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
    }
}