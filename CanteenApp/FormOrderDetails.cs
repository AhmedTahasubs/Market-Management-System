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
    public partial class FormOrderDetails : Form
    {
        private Order currentOrder;

        public FormOrderDetails()
        {
            InitializeComponent();
        }
        public FormOrderDetails(Order order)
        {
            InitializeComponent();
            currentOrder = order;
            UpdateOrderDetailsView();
            dataGridViewItems.ReadOnly = true;
            dataGridViewItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void UpdateOrderDetailsView()
        {
            lblCustomerName.Text = $"Customer: {currentOrder.CustomerName}";
            lblOrderDate.Text = $"Date: {currentOrder.OrderDate:yyyy-MM-dd HH:mm}";
            lblTotal.Text = $"Total: {currentOrder.TotalAmount} EGP";

            dataGridViewItems.DataSource = currentOrder.Items.Select(i => new
            {
                Product = i.Product?.Title ?? "(Unknown)",
                UnitPrice = i.Product?.Price ?? 0,
                Quantity = i.Quantity,
                Total = i.TotalPrice
            }).ToList();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            using var editForm = new FormEditOrder(currentOrder); // pass the current order
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                // Refresh details in this form after editing
                currentOrder = OrdersManager.GetOrderById(currentOrder.Id);
                currentOrder.Items = OrderItemsManager.GetOrderItems(currentOrder.Id);
                UpdateOrderDetailsView();
            }
        }
    }
}
