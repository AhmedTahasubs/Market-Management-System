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
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            var user = UsersManager.GetUserByUsernameAndPassword(textBox2.Text, textBox1.Text);

            if (user != null)
            {
                string role = user.Role?.ToLower();
                string logDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
                Directory.CreateDirectory(logDir); // يتأكد ان الفولدر موجود او ينشئه
                string fileName = DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
                string filePath = Path.Combine(logDir, fileName);
                string logLine = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - Username: {user.Name}, Role: {role} logged in.";

                File.AppendAllText(filePath, logLine + Environment.NewLine); // يكتب السطر في الملف

                MessageBox.Show("Login successful!");

                if (role == "admin")
                {
                    Admin admin = new Admin();
                    admin.Show();
                }
                else if (role == "user")
                {
                    User userForm = new User();
                    userForm.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

    }
}
