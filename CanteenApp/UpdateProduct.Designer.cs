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
            label3 = new Label();
            UnitsTxt = new TextBox();
            PriceTxt = new TextBox();
            NameTxt = new TextBox();
            SuspendLayout();
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.FromArgb(0, 192, 0);
            UpdateBtn.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateBtn.ForeColor = Color.White;
            UpdateBtn.Location = new Point(93, 165);
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
            label1.Location = new Point(93, 30);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 118);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 2;
            label2.Text = "Units In Stock";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 74);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 3;
            label3.Text = "Price";
            // 
            // UnitsTxt
            // 
            UnitsTxt.Location = new Point(93, 136);
            UnitsTxt.Name = "UnitsTxt";
            UnitsTxt.Size = new Size(126, 23);
            UnitsTxt.TabIndex = 4;
            // 
            // PriceTxt
            // 
            PriceTxt.Location = new Point(93, 92);
            PriceTxt.Name = "PriceTxt";
            PriceTxt.Size = new Size(126, 23);
            PriceTxt.TabIndex = 5;
            // 
            // NameTxt
            // 
            NameTxt.Location = new Point(93, 48);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(126, 23);
            NameTxt.TabIndex = 6;
            // 
            // UpdateProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 243);
            Controls.Add(NameTxt);
            Controls.Add(PriceTxt);
            Controls.Add(UnitsTxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(UpdateBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "UpdateProduct";
            Text = "UpdateProduct";
            Load += UpdateProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UpdateBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox UnitsTxt;
        private TextBox PriceTxt;
        private TextBox NameTxt;
    }
}