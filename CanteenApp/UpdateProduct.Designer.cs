namespace CanteenApp
{
    partial class UpdateProduct
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
            UpdateBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            UnitsTxt = new TextBox();
            NameTxt = new TextBox();
            ForSellPriceTxt = new TextBox();
            label3 = new Label();
            OriginalPriceTxt = new TextBox();
            label = new Label();
            SuspendLayout();
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.FromArgb(0, 192, 0);
            UpdateBtn.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateBtn.ForeColor = Color.White;
            UpdateBtn.Location = new Point(93, 135);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(126, 23);
            UpdateBtn.TabIndex = 0;
            UpdateBtn.Text = "Update Product";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 14);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 14);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 2;
            label2.Text = "Units In Stock";
            label2.Click += label2_Click;
            // 
            // UnitsTxt
            // 
            UnitsTxt.Location = new Point(166, 32);
            UnitsTxt.Name = "UnitsTxt";
            UnitsTxt.Size = new Size(126, 23);
            UnitsTxt.TabIndex = 4;
            // 
            // NameTxt
            // 
            NameTxt.Location = new Point(21, 32);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(126, 23);
            NameTxt.TabIndex = 6;
            // 
            // ForSellPriceTxt
            // 
            ForSellPriceTxt.Location = new Point(166, 92);
            ForSellPriceTxt.Name = "ForSellPriceTxt";
            ForSellPriceTxt.Size = new Size(126, 23);
            ForSellPriceTxt.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(166, 74);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 20;
            label3.Text = "For sell Price";
            // 
            // OriginalPriceTxt
            // 
            OriginalPriceTxt.Location = new Point(21, 92);
            OriginalPriceTxt.Name = "OriginalPriceTxt";
            OriginalPriceTxt.Size = new Size(126, 23);
            OriginalPriceTxt.TabIndex = 19;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(21, 74);
            label.Name = "label";
            label.Size = new Size(78, 15);
            label.TabIndex = 18;
            label.Text = "Original Price";
            // 
            // UpdateProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 181);
            Controls.Add(ForSellPriceTxt);
            Controls.Add(label3);
            Controls.Add(OriginalPriceTxt);
            Controls.Add(label);
            Controls.Add(NameTxt);
            Controls.Add(UnitsTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(UpdateBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "UpdateProduct";
            StartPosition = FormStartPosition.CenterParent;
            Text = "UpdateProduct";
            Load += UpdateProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UpdateBtn;
        private Label label1;
        private Label label2;
        private TextBox UnitsTxt;
        private TextBox NameTxt;
        private TextBox ForSellPriceTxt;
        private Label label3;
        private TextBox OriginalPriceTxt;
        private Label label;
    }
}