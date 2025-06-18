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
    public partial class UpdateCategoy : Form
    {
        private Category category;
        public UpdateCategoy()
        {
            InitializeComponent();
        }
        public void SetCategory(Category category)
        {
            if (category == null)
            {
                MessageBox.Show("No category selected for update.");
                Close();
                return;
            }
            this.category = category;
            textBox1.Text = category.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please fill in the category name.");
                return;
            }
            if (textBox1.Text.Length < 3)
            {
                MessageBox.Show("Category name must be at least 3 characters long.");
                return;
            }
            if (textBox1.Text.Length > 50)
            {
                MessageBox.Show("Category name must not exceed 50 characters.");
                return;
            }
            category.Name = textBox1.Text.Trim();
            category.Id = category.Id;
            int res = CategoriesManager.UpdateCategory(category);
            if (res > 0)
            {
                MessageBox.Show("Category updated successfully.");
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Failed to update category. Please try again.");
            }

        }
    }
}
