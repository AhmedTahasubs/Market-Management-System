namespace CanteenApp
{
    partial class UpdateUser
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
            Units = new TextBox();
            label3 = new Label();
            label2 = new Label();
            NameTxt = new Label();
            UpdateBtn = new Button();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 84);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 23;
            label4.Text = "User Name";
            label4.Click += label4_Click;
            // 
            // Name
            // 
            Name.Location = new Point(19, 53);
            Name.Name = "Name";
            Name.Size = new Size(126, 23);
            Name.TabIndex = 22;
            // 
            // Units
            // 
            Units.Location = new Point(19, 102);
            Units.Name = "Units";
            Units.Size = new Size(126, 23);
            Units.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(164, 35);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 19;
            label3.Text = "Role";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 84);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 18;
            label2.Text = "Password";
            // 
            // NameTxt
            // 
            NameTxt.AutoSize = true;
            NameTxt.Location = new Point(19, 35);
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
            UpdateBtn.Location = new Point(92, 150);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(126, 23);
            UpdateBtn.TabIndex = 16;
            UpdateBtn.Text = "Update User";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(164, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(126, 23);
            textBox1.TabIndex = 24;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(164, 53);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(126, 23);
            comboBox1.TabIndex = 25;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // UpdateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 209);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(Name);
            Controls.Add(Units);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(NameTxt);
            Controls.Add(UpdateBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "UpdateUser";
            Load += UpdateUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private TextBox Name;
        private TextBox Units;
        private Label label3;
        private Label label2;
        private Label NameTxt;
        private Button UpdateBtn;
        private TextBox textBox1;
        private ComboBox comboBox1;
    }
}