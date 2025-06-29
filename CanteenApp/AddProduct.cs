using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CanteenLogic;

namespace CanteenApp
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Name.Text) || string.IsNullOrWhiteSpace(OriginalPriceTxt.Text) || comboBox1.SelectedItem == null || string.IsNullOrWhiteSpace(Units.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (!int.TryParse(OriginalPriceTxt.Text, out int original) || original <= 0)
            {
                MessageBox.Show("Invalid original price.");
                return;
            }
            if (!int.TryParse(ForSellPriceTxt.Text, out int sell) || sell <= 0)
            {
                MessageBox.Show("Invalid selling price.");
                return;
            }
            if (!int.TryParse(Units.Text, out int units) || units < 0)
            {
                MessageBox.Show("Please enter a valid number of units in stock (0 or more).");
                return;
            }
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a category.");
                return;
            }
            Product product = new Product
            {
                Title = Name.Text.Trim(),
                OriginalPrice = original,
                ForSellPrice = sell,
                UnitsInStock = units,
                CategoryId = int.TryParse(comboBox1?.SelectedValue?.ToString(), out int categoryId) ? categoryId : 0
            };
            int result = ProductsManager.AddProduct(product);
            if (result > 0)
            {
                MessageBox.Show("Product added successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to add product. Please try again.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DataSource = CategoriesManager.GetCategories().ToList();
        }
    }
}
