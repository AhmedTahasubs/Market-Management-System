namespace CanteenApp
{
    partial class AddUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label4 = new Label();
            Name = new TextBox();
            userName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            NameTxt = new Label();
            UpdateBtn = new Button();
            password = new TextBox();
            role = new ComboBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 81);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 23;
            label4.Text = "User Name";
            // 
            // Name
            // 
            Name.Location = new Point(21, 50);
            Name.Name = "Name";
            Name.Size = new Size(126, 23);
            Name.TabIndex = 22;
            // 
            // userName
            // 
            userName.Location = new Point(21, 99);
            userName.Name = "userName";
            userName.Size = new Size(126, 23);
            userName.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(166, 32);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 19;
            label3.Text = "Role";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 81);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 18;
            label2.Text = "Password";
            // 
            // NameTxt
            // 
            NameTxt.AutoSize = true;
            NameTxt.Location = new Point(21, 32);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(39, 15);
            NameTxt.TabIndex = 17;
            NameTxt.Text = "Name";
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.FromArgb(0, 192, 0);
            UpdateBtn.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateBtn.ForeColor = Color.White;
            UpdateBtn.Location = new Point(94, 147);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(126, 23);
            UpdateBtn.TabIndex = 16;
            UpdateBtn.Text = "Add User";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // password
            // 
            password.Location = new Point(166, 99);
            password.Name = "password";
            password.Size = new Size(126, 23);
            password.TabIndex = 25;
            // 
            // role
            // 
            role.FormattingEnabled = true;
            role.Location = new Point(166, 50);
            role.Name = "role";
            role.Size = new Size(126, 23);
            role.TabIndex = 26;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 209);
            Controls.Add(role);
            Controls.Add(password);
            Controls.Add(label4);
            Controls.Add(Name);
            Controls.Add(userName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(NameTxt);
            Controls.Add(UpdateBtn);
            MaximizeBox = false;
            Name = "AddUser";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddUser";
            Load += AddUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private TextBox Name;
        private TextBox userName;
        private Label label3;
        private Label label2;
        private Label NameTxt;
        private Button UpdateBtn;
        private TextBox password;
        private ComboBox role;
    }
}