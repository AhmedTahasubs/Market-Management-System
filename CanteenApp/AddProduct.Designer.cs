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
            OriginalPriceTxt = new TextBox();
            Units = new TextBox();
            label = new Label();
            label2 = new Label();
            NameTxt = new Label();
            UpdateBtn = new Button();
            label4 = new Label();
            comboBox1 = new ComboBox();
            ForSellPriceTxt = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Name
            // 
            Name.Location = new Point(21, 46);
            Name.Name = "Name";
            Name.Size = new Size(126, 23);
            Name.TabIndex = 13;
            // 
            // OriginalPriceTxt
            // 
            OriginalPriceTxt.Location = new Point(21, 95);
            OriginalPriceTxt.Name = "OriginalPriceTxt";
            OriginalPriceTxt.Size = new Size(126, 23);
            OriginalPriceTxt.TabIndex = 12;
            // 
            // Units
            // 
            Units.Location = new Point(166, 46);
            Units.Name = "Units";
            Units.Size = new Size(126, 23);
            Units.TabIndex = 11;
            Units.TextChanged += textBox1_TextChanged;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(21, 77);
            label.Name = "label";
            label.Size = new Size(78, 15);
            label.TabIndex = 10;
            label.Text = "Original Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 128);
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
            UpdateBtn.Location = new Point(93, 189);
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
            label4.Location = new Point(166, 28);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 14;
            label4.Text = "Units In Stock";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(93, 146);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(126, 23);
            comboBox1.TabIndex = 15;
            // 
            // ForSellPriceTxt
            // 
            ForSellPriceTxt.Location = new Point(166, 95);
            ForSellPriceTxt.Name = "ForSellPriceTxt";
            ForSellPriceTxt.Size = new Size(126, 23);
            ForSellPriceTxt.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 77);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 16;
            label1.Text = "For sell Price";
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 249);
            Controls.Add(ForSellPriceTxt);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(Name);
            Controls.Add(OriginalPriceTxt);
            Controls.Add(Units);
            Controls.Add(label);
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
        private TextBox OriginalPriceTxt;
        private TextBox Units;
        private Label label;
        private Label label2;
        private Label NameTxt;
        private Button UpdateBtn;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox ForSellPriceTxt;
        private Label label1;
    }
}