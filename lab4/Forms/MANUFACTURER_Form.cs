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
using lab2.Interfaces;
using lab2.AbstractFactory;

namespace lab2
{
    public partial class MANUFACTURER_Form : Form
    {
        public MANUFACTURER_Form()
        {
            InitializeComponent();
            COUNTRY_comboBox.SelectedItem = COUNTRY_comboBox.Items[0];
        }

        private void ADD_button_Click(object sender, EventArgs e)
        {
            var factory = new SimpleProjectFactory();
            if (ORGANISATION_textBox.Text == "" || ADDRESS_textBox.Text == "")
            {
                MessageBox.Show("Are there any empty fields?");
            }
            else
            {
                var manufacturer = factory.CreateManufacturer(ORGANISATION_textBox.Text, COUNTRY_comboBox.SelectedItem.ToString(), ADDRESS_textBox.Text, PHONE_maskedTextBox.Text);
                Manufacturer.Manufacturers.Add((Manufacturer)manufacturer);
                ORGANISATION_textBox.Text = "";
                ADDRESS_textBox.Text = "";
                PHONE_maskedTextBox.Text = "";
                COUNTRY_comboBox.SelectedItem = COUNTRY_comboBox.Items[0];
            }
        }
    }
}
