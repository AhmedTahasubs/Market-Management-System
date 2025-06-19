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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            LoadProductsInDataGrid();
            LoadProductsInComboBox();
            HideCategoriesManagementControls();
            isCategoriesManagementVisible = false;
            HideUsersManagementControls();
            LoadOrdersGrid();
            isUsersManagementVisible = false;
            HideOrdersManagementControls();
            isOrdersManagementVisible = false;
            button4.BackColor = Color.Green;

        }
        bool isProductsManagementVisible = true;
        private void HideProductsManagementControls()
        {
            label5.Hide();
            label1.Hide();
            textBox1.Hide();
            dataGridView1.Hide();
            AddBtn.Hide();
            label2.Hide();
            comboBox1.Hide();
            EditBtn.Hide();
            DeleteBtn.Hide();
        }
        private void ShowProductsManagementControls()
        {
            label5.Show();
            label1.Show();
            textBox1.Show();
            dataGridView1.Show();
            AddBtn.Show();
            label2.Show();
            comboBox1.Show();
            EditBtn.Show();
            DeleteBtn.Show();
        }
        bool isCategoriesManagementVisible = true;
        private void ShowCategoriesManagementControls()
        {
            label6.Show();
            label4.Show();
            textBox2.Show();
            dataGridView2.Show();
            button1.Show();
            label3.Show();
            comboBox2.Show();
            button3.Show();
            button2.Show();
        }
        private void HideCategoriesManagementControls()
        {
            label6.Hide();
            label4.Hide();
            textBox2.Hide();
            dataGridView2.Hide();
            button1.Hide();
            label3.Hide();
            comboBox2.Hide();
            button3.Hide();
            button2.Hide();
        }
        bool isUsersManagementVisible = true;
        private void ShowUsersManagementControls()
        {
            label7.Show();
            label8.Show();
            textBox3.Show();
            dataGridView3.Show();
            button7.Show();
            label9.Show();
            comboBox3.Show();
            button9.Show();
            button8.Show();
        }
        private void HideUsersManagementControls()
        {
            label7.Hide();
            label8.Hide();
            textBox3.Hide();
            dataGridView3.Hide();
            button7.Hide();
            label9.Hide();
            comboBox3.Hide();
            button9.Hide();
            button8.Hide();
        }
        bool isOrdersManagementVisible = true;
        private void HideOrdersManagementControls()
        {
            label10.Hide();
            label12.Hide();
            textBox4.Hide();
            dataGridViewOrders.Hide();
            button10.Hide();
            button11.Hide();
        }
        private void ShowOrdersManagementControls()
        {
            label10.Show();
            label12.Show();
            textBox4.Show();
            dataGridViewOrders.Show();
            button10.Show();
            button11.Show();

        }

        private void LoadProductsInComboBox()
        {
            comboBox1.DataSource = ProductsManager.GetProducts();
            comboBox1.DisplayMember = "Title";
            comboBox1.ValueMember = "Id";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            //---------------------------------------------------
            comboBox2.DataSource = CategoriesManager.GetCategories();
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            //---------------------------------------------------
            comboBox3.DataSource = UsersManager.GetUsers();
            comboBox3.DisplayMember = "Name";
            comboBox3.ValueMember = "Id";
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void LoadProductsInDataGrid()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = ProductsManager.GetProducts();
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["CategoryId"].Visible = false;
            dataGridView1.Columns["Title"].HeaderText = "Product Name";
            dataGridView1.Columns["Price"].HeaderText = "Price (EGP)";
            dataGridView1.Columns["UnitsInStock"].HeaderText = "Available Stock";
            dataGridView1.Columns["IsEmpty"].Visible = false;
            //------------------------------------------------------
            dataGridView2.Columns.Clear();
            dataGridView2.DataSource = CategoriesManager.GetCategories();
            dataGridView2.ReadOnly = true;
            dataGridView2.Columns["Id"].Visible = false;
            dataGridView2.Columns["Name"].HeaderText = "Category Name";
            //------------------------------------------------------
            dataGridView3.Columns.Clear();
            dataGridView3.DataSource = UsersManager.GetUsers();
            dataGridView3.ReadOnly = true;
            dataGridView3.Columns["Id"].Visible = false;
            dataGridView3.Columns["Name"].HeaderText = "User Name";
            dataGridView3.Columns["UserName"].HeaderText = "Email Address";
            dataGridView3.Columns["Role"].HeaderText = "User Role";
            dataGridView3.Columns["Password"].Visible = false; // Hide password column for security
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }
            DialogResult result = MessageBox.Show($"Are you sure you want to delete the selected product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, false);
            if (result != DialogResult.Yes)
            {
                return;
            }
            if (comboBox1.SelectedItem is not Product selectedProduct)
            {
                MessageBox.Show("Invalid product selection.");
                return;
            }
            if (selectedProduct.Id <= 0)
            {
                MessageBox.Show("Invalid product ID.");
                return;
            }
            int x = ProductsManager.DeleteProduct(selectedProduct.Id);
            if (x <= 0)
            {
                MessageBox.Show("Failed to delete product. Please try again.");
                return;
            }
            MessageBox.Show("Product deleted successfully!");
            LoadProductsInComboBox();
            LoadProductsInDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProduct addProductForm = new AddProduct();
            addProductForm.ShowDialog();
            if (addProductForm.DialogResult == DialogResult.OK)
            {
                LoadProductsInComboBox();
                LoadProductsInDataGrid();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                LoadProductsInDataGrid();
            }
            else
            {
                var products = ProductsManager.GetProductsByName(searchText);

                if (products != null && products.Count > 0)
                {
                    dataGridView1.DataSource = null; // Clear previous data source
                    dataGridView1.DataSource = products;
                    dataGridView1.ReadOnly = true;
                    dataGridView1.Columns["Id"].Visible = false;
                    dataGridView1.Columns["CategoryId"].Visible = false;
                    dataGridView1.Columns["Title"].HeaderText = "Product Name";
                    dataGridView1.Columns["Price"].HeaderText = "Price (EGP)";
                    dataGridView1.Columns["UnitsInStock"].HeaderText = "Available Stock";
                    dataGridView1.Columns["IsEmpty"].Visible = false;
                }
                else
                {
                    dataGridView1.DataSource = null;
                    MessageBox.Show("No products found matching the search criteria.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            UpdateProduct updateProductForm = new UpdateProduct();
            if (comboBox1.SelectedItem is Product selectedProduct)
            {
                updateProductForm.SetProduct(selectedProduct);
                updateProductForm.ShowDialog();
                if (updateProductForm.DialogResult == DialogResult.OK)
                {
                    LoadProductsInComboBox();
                    LoadProductsInDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Please select a product to edit.");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                LoadProductsInDataGrid();
            }
            else
            {
                var products = CategoriesManager.GetCategoriesByName(searchText);

                if (products != null && products.Count > 0)
                {
                    dataGridView2.DataSource = null; // Clear previous data source
                    dataGridView2.DataSource = products;
                    dataGridView2.ReadOnly = true;
                    dataGridView2.Columns["Id"].Visible = false;
                    dataGridView2.Columns["Name"].HeaderText = "Category Name";
                }
                else
                {
                    dataGridView2.DataSource = null;
                    MessageBox.Show("No categories found matching the search criteria.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select a category to delete.");
                return;
            }
            DialogResult result = MessageBox.Show($"Are you sure you want to delete the selected category?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, false);
            if (result != DialogResult.Yes)
            {
                return;
            }
            if (comboBox2.SelectedItem is not Category selectedCategory)
            {
                MessageBox.Show("Invalid category selection.");
                return;
            }
            if (selectedCategory.Id <= 0)
            {
                MessageBox.Show("Invalid category ID.");
                return;
            }
            int x = CategoriesManager.DeleteCategory(selectedCategory.Id);
            if (x <= 0)
            {
                MessageBox.Show("Failed to delete category. Please try again.");
                return;
            }
            MessageBox.Show("Category deleted successfully!");
            LoadProductsInComboBox();
            LoadProductsInDataGrid();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddCategory addCategoyForm = new AddCategory();
            addCategoyForm.ShowDialog();
            if (addCategoyForm.DialogResult == DialogResult.OK)
            {
                LoadProductsInComboBox();
                LoadProductsInDataGrid();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateCategoy updateCategoryForm = new UpdateCategoy();
            if (comboBox2.SelectedItem is Category selectedCategory)
            {
                updateCategoryForm.SetCategory(selectedCategory);
                updateCategoryForm.ShowDialog();
                if (updateCategoryForm.DialogResult == DialogResult.OK)
                {
                    LoadProductsInComboBox();
                    LoadProductsInDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Please select a category to edit.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!isProductsManagementVisible && isCategoriesManagementVisible || isUsersManagementVisible || isOrdersManagementVisible)
            {
                button4.BackColor = Color.Green;
                HideCategoriesManagementControls();
                isCategoriesManagementVisible = false;
                HideUsersManagementControls();
                isUsersManagementVisible = false;
                HideOrdersManagementControls();
                isOrdersManagementVisible = false;
                ShowProductsManagementControls();
                isProductsManagementVisible = true;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button13.BackColor = Color.Red;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!isCategoriesManagementVisible && isProductsManagementVisible || isUsersManagementVisible || isOrdersManagementVisible)
            {
                button6.BackColor = Color.Green;
                HideProductsManagementControls();
                isProductsManagementVisible = false;
                HideUsersManagementControls();
                isUsersManagementVisible = false;
                HideOrdersManagementControls();
                isOrdersManagementVisible = false;
                ShowCategoriesManagementControls();
                isCategoriesManagementVisible = true;
                button4.BackColor = Color.Red; // Reset button4 color to default
                button5.BackColor = Color.Red; // Reset button5 color to default
                button13.BackColor = Color.Red;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (!isUsersManagementVisible && isProductsManagementVisible || isCategoriesManagementVisible || isOrdersManagementVisible)
            {
                button5.BackColor = Color.Green;
                HideProductsManagementControls();
                isProductsManagementVisible = false;
                HideCategoriesManagementControls();
                isCategoriesManagementVisible = false;
                HideOrdersManagementControls();
                isOrdersManagementVisible = false;
                ShowUsersManagementControls();
                isUsersManagementVisible = true;
                button4.BackColor = Color.Red; // Reset button4 color to default
                button6.BackColor = Color.Red; // Reset button6 color to default
                button13.BackColor = Color.Red;
            }
            return;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox3.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                LoadProductsInDataGrid();
            }
            else
            {
                var users = UsersManager.GetUsersByName(searchText);

                if (users != null && users.Count > 0)
                {
                    dataGridView3.DataSource = null; // Clear previous data source
                    dataGridView3.DataSource = users;
                    dataGridView3.ReadOnly = true;
                    dataGridView3.Columns["Id"].Visible = false;
                    dataGridView3.Columns["Name"].HeaderText = "Category Name";
                    dataGridView3.Columns["UserName"].HeaderText = "Email Address";
                    dataGridView3.Columns["Role"].HeaderText = "User Role";
                    dataGridView3.Columns["Password"].Visible = false; // Hide password column for security

                }
                else
                {
                    dataGridView3.DataSource = null;
                    MessageBox.Show("No users found matching the search criteria.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem == null)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete the selected user?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.DefaultDesktopOnly,
                false);

            if (result != DialogResult.Yes)
                return;
            if (comboBox3.SelectedItem is not CanteenLogic.User selectedUser)
            {
                MessageBox.Show("Invalid User selection.");
                return;
            }
            if (selectedUser.Id <= 0)
            {
                MessageBox.Show("Invalid User ID.");
                return;
            }

            int x = UsersManager.DeleteUser(selectedUser.Id);
            if (x <= 0)
            {
                MessageBox.Show("Failed to delete user. Please try again.");
                return;
            }

            MessageBox.Show("User deleted successfully!");
            LoadProductsInComboBox();
            LoadProductsInDataGrid();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddUser addUserForm = new AddUser();
            addUserForm.ShowDialog();
            if (addUserForm.DialogResult == DialogResult.OK)
            {
                LoadProductsInComboBox();
                LoadProductsInDataGrid();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            UpdateUser updateUserForm = new UpdateUser();
            if (comboBox3.SelectedItem is CanteenLogic.User selectedCategory)
            {
                updateUserForm.SetUser(selectedCategory);
                updateUserForm.ShowDialog();
                if (updateUserForm.DialogResult == DialogResult.OK)
                {
                    LoadProductsInComboBox();
                    LoadProductsInDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Please select a category to edit.");
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (!isOrdersManagementVisible && isProductsManagementVisible || isCategoriesManagementVisible || isUsersManagementVisible)
            {
                button13.BackColor = Color.Green;
                HideProductsManagementControls();
                isProductsManagementVisible = false;
                HideCategoriesManagementControls();
                isCategoriesManagementVisible = false;
                HideUsersManagementControls();
                isUsersManagementVisible = false;
                ShowOrdersManagementControls();
                isOrdersManagementVisible = true;
                button4.BackColor = Color.Red; // Reset button4 color to default
                button5.BackColor = Color.Red; // Reset button5 color to default
                button6.BackColor = Color.Red; // Reset button6 color to default
            }
        }
        private void LoadOrdersGrid()
        {
            dataGridViewOrders.DataSource = OrdersManager.GetOrdersSummary();
            if (dataGridViewOrders.DataSource == null)
            {
                dataGridViewOrders.DataSource = new List<object>();
            }
            dataGridViewOrders.Columns["Id"].HeaderText = "Order ID";
            dataGridViewOrders.Columns["CustomerName"].HeaderText = "Customer";
            dataGridViewOrders.Columns["OrderDate"].HeaderText = "Date";
            dataGridViewOrders.Columns["TotalAmount"].HeaderText = "Total (EGP)";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox4.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                LoadOrdersGrid();
                return;
            }

            List<Order> orders;

            // Try to parse month number (1–12)
            bool isMonthNumber = int.TryParse(searchText, out int month) && month >= 1 && month <= 12;

            if (isMonthNumber)
            {
                orders = OrdersManager.SearchOrdersByMonth(month);
            }
            else
            {
                orders = OrdersManager.SearchOrdersByCustomerName(searchText);
            }

            if (orders != null && orders.Count > 0)
            {
                dataGridViewOrders.DataSource = null;
                dataGridViewOrders.DataSource = orders.Select(o => new
                {
                    o.Id,
                    o.CustomerName,
                    o.OrderDate,
                    TotalAmount = o.TotalAmount
                }).ToList();

                dataGridViewOrders.Columns["Id"].HeaderText = "Order ID";
                dataGridViewOrders.Columns["CustomerName"].HeaderText = "Customer";
                dataGridViewOrders.Columns["OrderDate"].HeaderText = "Date";
                dataGridViewOrders.Columns["TotalAmount"].HeaderText = "Total (EGP)";
            }
            else
            {
                dataGridViewOrders.DataSource = null;
                MessageBox.Show("No orders found matching the search criteria.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int orderId = Convert.ToInt32(dataGridViewOrders.Rows[e.RowIndex].Cells["Id"].Value);

            var order = OrdersManager.GetOrderById(orderId);
            if (order == null) return;

            // Load order items
            order.Items = OrderItemsManager.GetOrderItems(orderId);

            using var form = new FormOrderDetails(order);
            form.ShowDialog();
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            Hide();
            Login login = new Login();
            login.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.SelectedButton.Hide();
            user.ShowDialog();
            if (user.DialogResult == DialogResult.OK )
            {
                LoadOrdersGrid();  
                LoadProductsInComboBox();
                LoadProductsInDataGrid();
            }
            else
            {
                LoadOrdersGrid();
                LoadProductsInComboBox();
                LoadProductsInDataGrid();
            }
        }
    }
}
