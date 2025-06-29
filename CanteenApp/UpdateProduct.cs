using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CanteenLogic;

namespace CanteenApp
{
    public partial class UpdateProduct : Form
    {
        private Product product;
        public UpdateProduct()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void SetProduct(Product product)
        {
            if (product == null)
            {
                MessageBox.Show("No product selected for update.");
                Close();
                return;
            }

            this.product = product;
            NameTxt.Text = product.Title;
            UnitsTxt.Text = product.UnitsInStock.ToString();
            OriginalPriceTxt.Text = product.OriginalPrice.ToString();
            ForSellPriceTxt.Text = product.ForSellPrice.ToString();
        }
        private void UpdateProduct_Load(object sender, EventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTxt.Text) ||
        string.IsNullOrWhiteSpace(OriginalPriceTxt.Text) ||
        string.IsNullOrWhiteSpace(ForSellPriceTxt.Text) ||
        string.IsNullOrWhiteSpace(UnitsTxt.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!int.TryParse(OriginalPriceTxt.Text, out int originalPrice) || originalPrice <= 0)
            {
                MessageBox.Show("Invalid original price.");
                return;
            }

            if (!int.TryParse(ForSellPriceTxt.Text, out int forSellPrice) || forSellPrice <= 0)
            {
                MessageBox.Show("Invalid selling price.");
                return;
            }

            if (!int.TryParse(UnitsTxt.Text, out int units) || units < 0)
            {
                MessageBox.Show("Invalid number of units in stock.");
                return;
            }

            product.Title = NameTxt.Text.Trim();
            product.OriginalPrice = originalPrice;
            product.ForSellPrice = forSellPrice;
            product.UnitsInStock = units;

            int res = ProductsManager.UpdateProduct(product);
            if (res > 0)
            {
                MessageBox.Show("Product updated successfully!");
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Failed to update product. Please try again.");
            }
        }
    }
}
