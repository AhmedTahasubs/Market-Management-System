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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }
            var user = UsersManager.GetUserByUsernameAndPassword(textBox2.Text, textBox1.Text);
            if (user != null && user.Role?.ToLower() =="admin")
            {
                MessageBox.Show("Login successful!");
                Admin admin = new Admin();
                admin.Show();
                this.Hide();
            }
            else if (user != null && user.Role?.ToLower() == "user")
            {
                MessageBox.Show("Login successful!");
                User userForm = new User();
                userForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }
    }
}
