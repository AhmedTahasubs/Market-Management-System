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
    public partial class FormEditOrder : Form
    {
        private Order currentOrder;
        private List<OrderItem> updatedItems;
        public FormEditOrder(Order order)
        {
            InitializeComponent();
            currentOrder = order;
            updatedItems = order.Items.Select(i => new OrderItem
            {
                Id = i.Id,
                OrderId = i.OrderId,
                ProductId = i.ProductId,
                Product = i.Product,
                Quantity = i.Quantity,
                UnitPrice = i.UnitPrice
            }).ToList();

            txtCustomerName.Text = order.CustomerName;
            LoadGrid();
        }
        BindingList<OrderItem> bindingList;
        private void UpdateGrandTotal()
        {
            decimal total = updatedItems.Sum(item => item.Quantity * (item.Product?.Price ?? 0));
            LblGrandTotal.Text = $"Total: {total:0.00} EGP";
        }
        private void LoadGrid()
        {
            bindingList = new BindingList<OrderItem>(updatedItems);
            dataGridViewItems.AutoGenerateColumns = false;
            dataGridViewItems.AllowUserToAddRows = false;
            // Clear BEFORE setting data source
            dataGridViewItems.Columns.Clear();
            dataGridViewItems.DataSource = bindingList;
            // Define editable Quantity column
            dataGridViewItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductTitle",
                HeaderText = "Product",
                ReadOnly = true
            });

            dataGridViewItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Quantity",
                HeaderText = "Quantity",
                ReadOnly = false
            });

            dataGridViewItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UnitPrice",
                HeaderText = "Unit Price",
                ReadOnly = true
            });

            dataGridViewItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalPrice",
                HeaderText = "Total",
                ReadOnly = true
            });
            button2.Enabled = dataGridViewItems.CurrentRow != null && dataGridViewItems.CurrentRow.Index >= 0;
            UpdateGrandTotal();
        }
        private void button1_Click(object sender, EventArgs e)
        {
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
            currentOrder.CustomerName = customerName;
            OrdersManager.UpdateOrder(currentOrder);

            // Get the original order items from DB again
            var originalItems = OrderItemsManager.GetOrderItems(currentOrder.Id);

            // Handle stock adjustment based on quantity changes
            foreach (var originalItem in originalItems)
            {
                var updatedItem = updatedItems.FirstOrDefault(i => i.ProductId == originalItem.ProductId);

                if (updatedItem != null)
                {
                    int quantityDiff = originalItem.Quantity - updatedItem.Quantity;

                    // Positive means return to stock, negative means take from stock
                    if (quantityDiff != 0)
                    {
                        ProductsManager.UpdateUnitsInStock(updatedItem.ProductId, quantityDiff);
                    }
                }
                else
                {
                    // Item was removed completely => restore full quantity
                    ProductsManager.UpdateUnitsInStock(originalItem.ProductId, originalItem.Quantity);
                }
            }

            // Delete old items and add updated ones
            OrderItemsManager.DeleteItemsByOrderId(currentOrder.Id);
            foreach (var item in updatedItems)
            {
                item.OrderId = currentOrder.Id;
                OrderItemsManager.AddOrderItem(item);
            }

            // تحديد مسار الملف حسب تاريخ اليوم
            string logDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
            Directory.CreateDirectory(logDir);
            string fileName = DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
            string filePath = Path.Combine(logDir, fileName);

            // بناء محتوى اللوج لتعديل أوردر
            List<string> logLines = new List<string>();
            logLines.Add("--------------------------------------------------");
            logLines.Add("[UPDATED ORDER]");
            logLines.Add($"Order ID: {currentOrder.Id}");
            logLines.Add($"Update Time: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
            logLines.Add($"Customer Name: {currentOrder.CustomerName}");
            logLines.Add("Updated Order Details:");

            decimal totalAmount = 0;
            foreach (var item in updatedItems)
            {
                string productName = item.Product.Title;
                int quantity = item.Quantity;
                decimal price = item.UnitPrice;
                decimal subtotal = quantity * price;
                totalAmount += subtotal;

                logLines.Add($"- {productName} x{quantity} @ {price:0.00} EGP = {subtotal:0.00} EGP");
            }

            logLines.Add($"Total Amount: {totalAmount:0.00} EGP");
            logLines.Add("--------------------------------------------------");

            // الكتابة في الملف
            File.AppendAllLines(filePath, logLines);


            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Make sure it's the Quantity column
            if (e.RowIndex < 0 || dataGridViewItems.Columns[e.ColumnIndex].DataPropertyName != "Quantity")
                return;

            // Prevent adding new rows
            if (e.RowIndex >= updatedItems.Count)
            {
                MessageBox.Show("Adding new items is not allowed here.");
                dataGridViewItems.Rows.RemoveAt(e.RowIndex);
                return;
            }

            // Validate quantity input
            if (!int.TryParse(dataGridViewItems.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString(), out int qty) || qty <= 0)
            {
                MessageBox.Show("Invalid quantity. It must be a positive number.");
                dataGridViewItems.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = updatedItems[e.RowIndex].Quantity; // restore old value
            }
            else
            {
                updatedItems[e.RowIndex].Quantity = qty;
            }

            // Refresh to update TotalPrice
            dataGridViewItems.Refresh();
            UpdateGrandTotal();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewItems.CurrentRow == null)
            {
                MessageBox.Show("Please select an item to delete.");
                return;
            }

            int rowIndex = dataGridViewItems.CurrentRow.Index;

            if (rowIndex >= 0 && rowIndex < updatedItems.Count)
            {
                var confirm = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm != DialogResult.Yes)
                    return;

                updatedItems.RemoveAt(rowIndex);

                // Refresh grid and clear selection
                LoadGrid();
                dataGridViewItems.ClearSelection();
                button2.Enabled = false;
            }
        }

        private void dataGridViewItems_SelectionChanged(object sender, EventArgs e)
        {
            button2.Enabled = dataGridViewItems.CurrentRow != null && dataGridViewItems.CurrentRow.Index >= 0;

        }
    }
}
