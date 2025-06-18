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
        public FormOrderDetails()
        {
            InitializeComponent();
        }
        public FormOrderDetails(Order order)
        {
            InitializeComponent();

            lblCustomerName.Text = $"Customer: {order.CustomerName}";
            lblOrderDate.Text = $"Date: {order.OrderDate:yyyy-MM-dd HH:mm}";
            lblTotal.Text = $"Total: {order.TotalAmount} EGP";

            dataGridViewItems.DataSource = order.Items.Select(i => new
            {
                Product = i.Product?.Title ?? "(Unknown)",
                UnitPrice = i.Product?.Price ?? 0,
                Quantity = i.Quantity,
                Total = i.TotalPrice
            }).ToList();

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
    }
}
