using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab2.Classes;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using System.IO;

namespace lab2.Forms
{
    public partial class GOODS_Form : Form
    {
        public GOODS_Form()
        {
            InitializeComponent();
        }

        private void GOODS_Form_Load(object sender, EventArgs e)
        {
            foreach (var pr in Product.Products)
            {
                GOODS_dataGridView.Rows.Add(pr.Name, pr.Number, pr.Size, pr.Weight, pr.Type, pr.Count, pr.Manufacturer, pr.Storekeeper);
            }

            foreach (var m in Manufacturer.Manufacturers)
            {
                MANUFACTURERS_dataGridView.Rows.Add(m.Organisation, m.Country, m.Address, m.Phone);
            }

            foreach (var sk in Storekeeper.Storekeepers)
            {
                STOREKEEPERS_dataGridView.Rows.Add(sk.Name, sk.Experience, sk.Address);
            }

            toolStripStatusLabel1.Text = "Count: " + (GOODS_dataGridView.Rows.Count-1);
            toolStripStatusLabel2.Text = "LastAction: Load";
            toolStripStatusLabel3.Text += DateTime.Now;
        }

        private void NAMESEARCH_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAll();
            NAMESEARCH_groupBox.Visible = true;
        }

        public void HideAll()
        {
            MANUFACTURERS_dataGridView.Visible = false;
            STOREKEEPERS_dataGridView.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            NAMESEARCH_groupBox.Visible = false;
            TYPESEARCH_groupBox.Visible = false;
            SIZESEARCH_groupBox.Visible = false;
        }

        private void SIZESEARCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAll();
            SIZESEARCH_groupBox.Visible = true;
        }

        private void NAMESEARCH_button_Click(object sender, EventArgs e)
        {
            RegexOptions rg;

            if (NAMESEARCH_textBox.Text == "")
            {
                MessageBox.Show("Please, enter anything");
            }
            else
            {
                GOODS_dataGridView.Rows.Clear();
                List<Product> searchResult;

                if (radioButton1.Checked)
                {
                    searchResult = Bloodhound.FindName(NAMESEARCH_textBox.Text, Product.Products, RegexOptions.None, Convert.ToInt32(numericUpDown1.Value));
                }
                else
                {
                    searchResult = Bloodhound.FindName(NAMESEARCH_textBox.Text, Product.Products, RegexOptions.IgnoreCase, Convert.ToInt32(numericUpDown1.Value));
                }

                foreach (var pr in searchResult)
                {
                    GOODS_dataGridView.Rows.Add(pr.Name, pr.Number, pr.Size, pr.Weight, pr.Type, pr.Count, pr.Manufacturer, pr.Storekeeper);
                }

                Serilize("searchName.json", searchResult);
            }

            toolStripStatusLabel1.Text = "Count: " + (GOODS_dataGridView.Rows.Count-1);
            toolStripStatusLabel2.Text = "LastAction: Search";
        }

        private void SIZESEARCH_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAll();
            SIZESEARCH_groupBox.Visible = true;
        }

        private void TYPESEARCH_button_Click(object sender, EventArgs e)
        {
            if (TYPESEARCH_textBox.Text == "")
            {
                MessageBox.Show("Please, enter anything");
            }
            else
            {
                GOODS_dataGridView.Rows.Clear();
                List<Product> searchResult;
                searchResult = Bloodhound.FindType(Product.Products, TYPESEARCH_textBox.Text);

                foreach (var pr in searchResult)
                {
                    GOODS_dataGridView.Rows.Add(pr.Name, pr.Number, pr.Size, pr.Weight, pr.Type, pr.Count, pr.Manufacturer, pr.Storekeeper);
                }

                Serilize("searchType.json", searchResult);
            }

            toolStripStatusLabel1.Text = "Count: " + (GOODS_dataGridView.Rows.Count-1);
            toolStripStatusLabel2.Text = "LastAction: Search";
        }

        private void SIZESEARCH_button_Click(object sender, EventArgs e)
        {
            if (SIZESEARCH_maskedTextBox.Text == "")
            {
                MessageBox.Show("Please, enter anything");
            }
            else
            {
                GOODS_dataGridView.Rows.Clear();
                List<Product> searchResult;
                searchResult = Bloodhound.FindSize(Product.Products, SIZESEARCH_maskedTextBox.Text);

                foreach (var pr in searchResult)
                {
                    GOODS_dataGridView.Rows.Add(pr.Name, pr.Number, pr.Size, pr.Weight, pr.Type, pr.Count, pr.Manufacturer, pr.Storekeeper);
                }

                Serilize("searchSize.json", searchResult);
            }

            toolStripStatusLabel1.Text = "Count: " + (GOODS_dataGridView.Rows.Count-1);
            toolStripStatusLabel2.Text = "LastAction: Search";
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GOODS_dataGridView.Rows.Clear();
            var result = Product.Products.OrderBy(e => e.Name);

            foreach (var pr in result)
            {
                GOODS_dataGridView.Rows.Add(pr.Name, pr.Number, pr.Size, pr.Weight, pr.Type, pr.Count, pr.Manufacturer, pr.Storekeeper);
            }

            Serilize("sortName.json", result);

            toolStripStatusLabel1.Text = "Count: " + (GOODS_dataGridView.Rows.Count-1);
            toolStripStatusLabel2.Text = "LastAction: Sort";
        }

        private void manufacturerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GOODS_dataGridView.Rows.Clear();
            var result = Product.Products.OrderBy(e => e.Manufacturer.Organisation);

            foreach (var pr in result)
            {
                GOODS_dataGridView.Rows.Add(pr.Name, pr.Number, pr.Size, pr.Weight, pr.Type, pr.Count, pr.Manufacturer, pr.Storekeeper);
            }

            Serilize("sortManufacturer.json", result);
            toolStripStatusLabel1.Text = "Count: " + (GOODS_dataGridView.Rows.Count-1);
            toolStripStatusLabel2.Text = "LastAction: Sort";
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GOODS_dataGridView.Rows.Clear();
            var result = Product.Products.OrderBy(e => e.Size);

            foreach (var pr in result)
            {
                GOODS_dataGridView.Rows.Add(pr.Name, pr.Number, pr.Size, pr.Weight, pr.Type, pr.Count, pr.Manufacturer, pr.Storekeeper);
            }

            Serilize("sortSize.json", result);
            toolStripStatusLabel1.Text = "Count: " + (GOODS_dataGridView.Rows.Count-1);
            toolStripStatusLabel2.Text = "LastAction: Sort";
        }

        private void manufacturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MANUFACTURER_Form manufcturer = new MANUFACTURER_Form();
            manufcturer.Show();
            Close();
        }

        public void Serilize(string path, IOrderedEnumerable<Product> result)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(JsonConvert.SerializeObject(result));
            }
        }

        public void Serilize(string path, List<Product> result)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(JsonConvert.SerializeObject(result));
            }
        }

        private void TYPESEARCH_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAll();
            TYPESEARCH_groupBox.Visible = true;
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AnResh\n1.2");
        }

        private void storekeeperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var storekeeper = new STOREKEEPER_Form();
            storekeeper.Show();
            Close();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var product = new PRODUCT_Form();
            product.Show();
            Close();       
        }
    }
}