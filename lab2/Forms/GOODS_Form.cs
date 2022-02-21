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
        }
    }
}
