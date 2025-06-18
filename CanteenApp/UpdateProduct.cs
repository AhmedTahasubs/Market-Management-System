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
            PriceTxt.Text = product.Price.ToString();
            UnitsTxt.Text = product.UnitsInStock.ToString();
        }
        private void UpdateProduct_Load(object sender, EventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTxt.Text) || string.IsNullOrWhiteSpace(PriceTxt.Text) || string.IsNullOrWhiteSpace(UnitsTxt.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (!int.TryParse(PriceTxt.Text, out int price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price greater than 0.");
                return;
            }
            if (!int.TryParse(UnitsTxt.Text, out int units) || units < 0)
            {
                MessageBox.Show("Please enter a valid number of units in stock (0 or more).");
                return;
            }
            product.Title = NameTxt.Text.Trim();
            product.Price = price;
            product.UnitsInStock = units;
            product.CategoryId = product.CategoryId;
            product.Id = product.Id;
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
