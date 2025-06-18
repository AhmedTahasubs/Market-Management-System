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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CanteenApp
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Name.Text) || string.IsNullOrWhiteSpace(userName.Text) || role.SelectedItem == null || string.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (role.SelectedItem == null)
            {
                MessageBox.Show("Please select a category.");
                return;
            }
            //if(UsersManager.CheckUserNameExists(userName.Text))
            //{
            //    MessageBox.Show("Please select another User Name.");
            //    return;
            //}
            var user = new CanteenLogic.User
            {
                Name = Name.Text.Trim(),
                UserName = userName.Text.Trim(),
                Role = role.SelectedItem.ToString(),
                Password = password.Text.Trim()
            };

            int result = UsersManager.AddUser(user);
            if (result > 0)
            {
                MessageBox.Show("user added successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to add user. Please try again.");
            }
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

            role.Items.Add("Admin");
            role.Items.Add("User");
            role.SelectedIndex = 1;
        }
    }
}
