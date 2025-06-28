using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CanteenLogic;
using CanteenLogic.Entities;

namespace CanteenApp
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        public Button SelectedButton
        {
            get { return Logoutbtn; }
        }
        public Button ALlOrdersButton
        {
            get { return Orders; }
        }
        public Button CloseButton
        {
            get { return CloseBtn; }
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
        }

        private void User_Load(object sender, EventArgs e)
        {
            LoadProductsInDataGrid();

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        List<OrderItem> cartItems = new();
        private void AddOrderItemToCart(int productId, int quantity)
        {
            var product = ProductsManager.GetProductById(productId);
            if (product == null) return;

            var existing = cartItems.FirstOrDefault(i => i.ProductId == productId);
            if (existing != null)
            {
                int totalQty = existing.Quantity + quantity;
                if (totalQty > product.UnitsInStock)
                {
                    MessageBox.Show("Not enough stock available.");
                    return;
                }
                existing.Quantity = totalQty;
            }
            else
            {
                if (quantity > product.UnitsInStock)
                {
                    MessageBox.Show("Not enough stock.");
                    return;
                }

                cartItems.Add(new OrderItem
                {
                    ProductId = productId,
                    Product = product,
                    Quantity = quantity
                });
            }

            RefreshCartGrid();
            UpdateTotalLabel();
        }
        private void RefreshCartGrid()
        {
            dataGridView2.Columns.Clear(); // Clear previous setup

            dataGridView2.DataSource = cartItems.Select(i => new
            {
                ProductId = i.ProductId,
                Product = i.Product.Title,
                Quantity = i.Quantity,
                UnitPrice = i.Product.Price,
                Total = i.TotalPrice
            }).ToList();

            dataGridView2.Columns["ProductId"].Visible = false;

            dataGridView2.Columns["Product"].HeaderText = "Product";
            dataGridView2.Columns["Quantity"].HeaderText = "Qty";
            dataGridView2.Columns["UnitPrice"].HeaderText = "Unit Price";
            dataGridView2.Columns["Total"].HeaderText = "Total Price";

            // Add delete button column (only once)
            if (!dataGridView2.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
                btnCol.Name = "Delete";
                btnCol.HeaderText = "Remove";
                btnCol.Text = "❌";
                btnCol.UseColumnTextForButtonValue = true;
                dataGridView2.Columns.Add(btnCol);
            }
        }
        private void UpdateTotalLabel()
        {
            int total = cartItems.Sum(i => i.TotalPrice);
            lblTotal.Text = $"Total: {total} EGP";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected product from the clicked row
                var row = dataGridView1.Rows[e.RowIndex];
                int productId = Convert.ToInt32(row.Cells["Id"].Value);
                string productName = row.Cells["Title"].Value.ToString();
                int price = Convert.ToInt32(row.Cells["Price"].Value);
                int stock = Convert.ToInt32(row.Cells["UnitsInStock"].Value);

                // Open your popup form and pass the product info
                var addForm = new FormAddQuantity(productId, productName, price, stock);
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    int quantity = addForm.SelectedQuantity;

                    //Add to cart or update cart grid(your logic here)
                    AddOrderItemToCart(productId, quantity);
                }
            }

        }
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnPlaceOrder_Click_1(object sender, EventArgs e)
        {
            if (cartItems.Count == 0)
            {
                MessageBox.Show("Cart is empty.");
                return;
            }
            string customerName = txtCustomerName.Text.Trim();
            if (!Regex.IsMatch(customerName, @"^[a-zA-Z\s]+$"))
            {
                // Invalid: contains characters other than letters or space
                MessageBox.Show("Customer name must contain only letters.");
                return;
            }
            if (string.IsNullOrEmpty(customerName))
            {
                MessageBox.Show("Please enter customer name.");
                return;
            }
            var order = new Order
            {
                CustomerName = customerName,
                OrderDate = DateTime.Now
            };

            int orderId = OrdersManager.AddOrder(order);

            foreach (var item in cartItems)
            {
                item.OrderId = orderId;
                OrderItemsManager.AddOrderItem(item);
                ProductsManager.DecreaseStock(item.ProductId, item.Quantity); // optional
            }
            // تحديد مسار الملف حسب تاريخ اليوم
            string logDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
            Directory.CreateDirectory(logDir);
            string fileName = DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
            string filePath = Path.Combine(logDir, fileName);

            // بناء محتوى اللوج
            List<string> logLines = new List<string>();
            logLines.Add("--------------------------------------------------");
            logLines.Add($"Order Time: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
            logLines.Add($"Customer Name: {customerName}");
            logLines.Add("Order Details:");

            decimal totalAmount = 0;
            foreach (var item in cartItems)
            {
                string productName = item.Product.Title;
                int quantity = item.Quantity;
                decimal price = item.Product.Price;
                decimal subtotal = quantity * price;
                totalAmount += subtotal;

                logLines.Add($"- {productName} x{quantity} @ {price:0.00} EGP = {subtotal:0.00} EGP");
            }

            logLines.Add($"Total Amount: {totalAmount:0.00} EGP");
            logLines.Add("--------------------------------------------------");

            // الكتابة في الملف
            File.AppendAllLines(filePath, logLines);


            MessageBox.Show("Order placed!");
            cartItems.Clear();
            RefreshCartGrid();
            UpdateTotalLabel();
            txtCustomerName.Clear();
            LoadProductsInDataGrid();
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            Hide();
            Login login = new Login();
            login.Show();
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            // Get selected product title from cart grid
            string productTitle = dataGridView2.Rows[e.RowIndex].Cells["Product"].Value.ToString();

            // Find item in cartItems list
            var item = cartItems.FirstOrDefault(i => i.Product.Title == productTitle);
            if (item == null) return;

            // Show the same quantity popup to allow user to change
            var editForm = new FormAddQuantity(item.ProductId, item.Product.Title, item.Product.Price, item.Product.UnitsInStock + item.Quantity); // allow full stock back

            // Set current quantity as default
            editForm.Controls.OfType<NumericUpDown>().FirstOrDefault()?.Select();
            editForm.Controls.OfType<NumericUpDown>().FirstOrDefault()!.Value = item.Quantity;

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                int newQuantity = editForm.SelectedQuantity;

                if (newQuantity == 0)
                {
                    // Optionally delete from cart if quantity is 0
                    cartItems.Remove(item);
                }
                else
                {
                    item.Quantity = newQuantity;
                }

                RefreshCartGrid();
                UpdateTotalLabel();

            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView2.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                string productName = dataGridView2.Rows[e.RowIndex].Cells["Product"].Value.ToString();

                var confirm = MessageBox.Show($"Remove '{productName}' from cart?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    var item = cartItems.FirstOrDefault(i => i.Product.Title == productName);
                    if (item != null)
                    {
                        cartItems.Remove(item);
                        RefreshCartGrid();
                        UpdateTotalLabel();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create instance of Admin form
            Admin adminForm = new Admin();

            // Hook to its Load event so we can control visibility AFTER it fully loads
            adminForm.Load += (s, args) =>
            {
                // Hide everything first
                foreach (Control control in adminForm.Controls)
                {
                    control.Hide();
                }

                // Show only Order Management controls
                Control? label = adminForm.Controls.Find("label10", true).FirstOrDefault();      // Label "Order Management"
                Control? textbox = adminForm.Controls.Find("textBox4", true).FirstOrDefault();   // Search textbox
                Control? grid = adminForm.Controls.Find("dataGridViewOrders", true).FirstOrDefault(); // Orders Grid

                if (label != null) label.Show();
                if (textbox != null) textbox.Show();
                if (grid != null) grid.Show();
                // Optionally, you can also show the Close button
                adminForm.CloseButton.Visible = true;
            };

            adminForm.ShowDialog();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
