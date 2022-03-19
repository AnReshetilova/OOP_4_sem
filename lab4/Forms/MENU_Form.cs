using System;
using System.Windows.Forms;
using lab2.Forms;
using lab2.Classes;
using lab2.Singleton;

namespace lab2
{
    public partial class MENU_Form : Form
    {
        public MENU_Form()
        {
            InitializeComponent();
            Manufacturer.Deserialize();
            Storekeeper.Deserialize();
            Product.Deserialize();
            this.BackColor = MenuFormSingleton.Instance.Color;                              //singleton
            Storekeeper.Storekeepers.Add((Storekeeper)Storekeeper.Storekeepers[0].Clone()); //prototype
        }

        private void ADDMANUFACTURER_button_Click(object sender, EventArgs e)
        {
            MANUFACTURER_Form manufcturer = new MANUFACTURER_Form();
            manufcturer.Show();
        }

        private void ADDPRODUCT_button_Click(object sender, EventArgs e)
        {
            PRODUCT_Form product = new PRODUCT_Form();
            product.Show();
        }

        private void ADDSTOREKEEPER_button_Click(object sender, EventArgs e)
        {
            STOREKEEPER_Form storekeeper = new STOREKEEPER_Form();
            storekeeper.Show();
        }

        private void VIEWGOODS_button_Click(object sender, EventArgs e)
        {
            GOODS_Form goods = new GOODS_Form();
            goods.Show();
        }

        private void MENU_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Product.Serialize();
            Manufacturer.Serialize();
            Storekeeper.Serialize();
        }
    }
}
