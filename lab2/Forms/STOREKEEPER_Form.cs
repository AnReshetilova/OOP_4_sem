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

namespace lab2
{
    public partial class STOREKEEPER_Form : Form
    {
        public STOREKEEPER_Form()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = "EXPERINECE " + trackBar1.Value;
        }

        private void ADD_button_Click(object sender, EventArgs e)
        {
            if (NAME_textBox.Text == "" || ADDRESS_textBox.Text == "")
            {
                MessageBox.Show("Are there any empty fields?");
            }
            else
            {
                Storekeeper storekeeper = new Storekeeper(NAME_textBox.Text, trackBar1.Value, ADDRESS_textBox.Text);
                Storekeeper.Storekeepers.Add(storekeeper);
                NAME_textBox.Text = "";
                ADDRESS_textBox.Text = "";
                trackBar1.Value = 0;
                label2.Text = "EXPERINECE 0";
            }
        }
    }
}
