using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanteenApp
{
    public partial class FormAddQuantity : Form
    {
        //public FormAddQuantity()
        //{
        //    InitializeComponent();
        //}

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public int SelectedQuantity { get; private set; } = 0;

        public FormAddQuantity(int productId, string productName, int price, int stock)
        {
            InitializeComponent();

            lblProductName.Text = $"Product: {productName} ({price} EGP)";
            lblStock.Text = $"Available Stock: {stock}";

            nudQuantity.Minimum = 1;
            nudQuantity.Maximum = stock;
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            SelectedQuantity = (int)nudQuantity.Value;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
