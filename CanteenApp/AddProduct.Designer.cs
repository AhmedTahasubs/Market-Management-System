namespace CanteenApp
{
    partial class AddProduct
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
            Name = new TextBox();
            Price = new TextBox();
            Units = new TextBox();
            label3 = new Label();
            label2 = new Label();
            NameTxt = new Label();
            UpdateBtn = new Button();
            label4 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // Name
            // 
            Name.Location = new Point(21, 46);
            Name.Name = "Name";
            Name.Size = new Size(126, 23);
            Name.TabIndex = 13;
            // 
            // Price
            // 
            Price.Location = new Point(166, 46);
            Price.Name = "Price";
            Price.Size = new Size(126, 23);
            Price.TabIndex = 12;
            // 
            // Units
            // 
            Units.Location = new Point(21, 95);
            Units.Name = "Units";
            Units.Size = new Size(126, 23);
            Units.TabIndex = 11;
            Units.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(166, 28);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 10;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 77);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 9;
            label2.Text = "Category";
            // 
            // NameTxt
            // 
            NameTxt.AutoSize = true;
            NameTxt.Location = new Point(21, 28);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(39, 15);
            NameTxt.TabIndex = 8;
            NameTxt.Text = "Name";
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.FromArgb(0, 192, 0);
            UpdateBtn.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateBtn.ForeColor = Color.White;
            UpdateBtn.Location = new Point(94, 143);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(126, 23);
            UpdateBtn.TabIndex = 7;
            UpdateBtn.Text = "Add Product";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 77);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 14;
            label4.Text = "Units In Stock";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(166, 95);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(126, 23);
            comboBox1.TabIndex = 15;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 209);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(Name);
            Controls.Add(Price);
            Controls.Add(Units);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(NameTxt);
            Controls.Add(UpdateBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddProduct";
            Load += AddProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Name;
        private TextBox Price;
        private TextBox Units;
        private Label label3;
        private Label label2;
        private Label NameTxt;
        private Button UpdateBtn;
        private Label label4;
        private ComboBox comboBox1;
    }
}