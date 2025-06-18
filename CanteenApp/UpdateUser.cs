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
    public partial class UpdateUser : Form
    {
        private CanteenLogic.User user;
        public UpdateUser()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void SetUser(CanteenLogic.User User)
        {
            if (User == null)
            {
                MessageBox.Show("No User selected for update.");
                Close();
                return;
            }
            this.user = User;
            Name.Text = user.Name;
            Units.Text = user.UserName;
            textBox1.Text = user.Password;
            comboBox1.SelectedItem = user.Role;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("User");
            if (user?.Role?.ToLower() == "admin")
            {
                comboBox1.SelectedIndex = 0; // Default to first item
            }
            else if (user?.Role?.ToLower() == "user")
            {
                comboBox1.SelectedIndex = 1; // Default to second item
            }
            else
            {
                comboBox1.SelectedIndex = -1; // No selection
            }

        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTxt.Text) || string.IsNullOrWhiteSpace(Units.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a role.");
                return;
            }
            if (string.IsNullOrWhiteSpace(user.UserName) || user.UserName.Length < 3)
            {
                MessageBox.Show("Please enter a valid User Name (at least 3 characters).");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox1.Text) || textBox1.Text.Length < 6)
            {
                MessageBox.Show("Please enter a valid password (at least 6 characters).");
                return;
            }
            user.Name = Name.Text.Trim();
            user.UserName = Units.Text.Trim();
            user.Password = textBox1.Text.Trim();
            user.Role = comboBox1.SelectedItem.ToString();
            int res = UsersManager.UpdateUser(user);
            if (res > 0)
            {
                MessageBox.Show("User updated successfully!");
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Failed to update user. Please try again.");
            }
        }
    }
}
