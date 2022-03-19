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
using System.ComponentModel.DataAnnotations;
using lab2.Builder;

namespace lab2
{
    public partial class PRODUCT_Form : Form
    {
        public PRODUCT_Form()
        {
            InitializeComponent();
            TYPE_comboBox.SelectedItem = TYPE_comboBox.Items[0];
            foreach (var el in Manufacturer.Manufacturers)
            {
                MANUFACTURER_comboBox.Items.Add(el);
            }

            foreach (var el in Storekeeper.Storekeepers)
            {
                STOREKEEPER_comboBox.Items.Add(el);
            }
        }

        private void WEIGTH_maskedTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(WEIGTH_maskedTextBox.Text) <= 100)
                {
                    progressBar1.Value = int.Parse(WEIGTH_maskedTextBox.Text);
                }
                else
                {
                    progressBar1.Value = 100;
                }
            }
            catch
            {
                progressBar1.Value = 0;
            }
        }

        private void ADD_button_Click(object sender, EventArgs e)
        {
            var productBuilder = new FullProductBuilder();
            if (NAME_textBox.Text == "" || NUMBER_maskedTextBox.Text == "" || SIZE_maskedTextBox.Text == "" || 
                    WEIGTH_maskedTextBox.Text == "" || MANUFACTURER_comboBox.SelectedItem == null || STOREKEEPER_comboBox.SelectedItem == null)
            {
                MessageBox.Show("Are there any empty fields?");
            }
            else
            {
                productBuilder.SetName(NAME_textBox.Text);
                productBuilder.SetParam(Convert.ToInt32(NUMBER_maskedTextBox.Text), Convert.ToInt32(SIZE_maskedTextBox.Text), Convert.ToInt32(WEIGTH_maskedTextBox.Text), TYPE_comboBox.SelectedItem.ToString(), (int)COUNT_numericUpDown.Value);
                productBuilder.SetManufacturer(Manufacturer.FindManufacturer(MANUFACTURER_comboBox.SelectedItem.ToString()));
                productBuilder.SetStorekeeper(Storekeeper.FindStorekeeper(STOREKEEPER_comboBox.SelectedItem.ToString()));

                Product product = productBuilder.Build();

                ValidationContext context = new ValidationContext(product, null, null);
                IList<ValidationResult> errors = new List<ValidationResult>();

                if (!Validator.TryValidateObject(product, context, errors, true))
                {
                    foreach (ValidationResult result in errors)
                        MessageBox.Show(result.ErrorMessage);
                }
                else
                {
                    MessageBox.Show("Validated");
                    Product.Products.Add(product);
                }

                foreach (Control c in Controls)
                {
                    if (c.GetType() == typeof(TextBox) || c.GetType() == typeof(MaskedTextBox))
                    {
                        c.Text = "";
                    }
                }
                TYPE_comboBox.SelectedItem = TYPE_comboBox.Items[0];
            }
        }

        private void ADDMANUFACT_label_Click(object sender, EventArgs e)
        {
            MANUFACTURER_Form manufacturer = new MANUFACTURER_Form();
            manufacturer.Show();
            this.Close();
        }

        private void ADD_STOREKEEPlabel_Click(object sender, EventArgs e)
        {
            STOREKEEPER_Form storekeeper = new STOREKEEPER_Form();
            storekeeper.Show();
            this.Close();
        }
    }
}
