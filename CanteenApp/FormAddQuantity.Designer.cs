namespace CanteenApp
{
    partial class FormAddQuantity
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
            lblProductName = new Label();
            lblStock = new Label();
            nudQuantity = new NumericUpDown();
            btnCancel = new Button();
            btnOK = new Button();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            SuspendLayout();
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 12F);
            lblProductName.Location = new Point(74, 9);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(52, 21);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Name";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 12F);
            lblStock.Location = new Point(74, 33);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(47, 21);
            lblStock.TabIndex = 1;
            lblStock.Text = "Stock";
            lblStock.Click += label2_Click;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(74, 68);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(169, 23);
            nudQuantity.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(168, 114);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 35);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.Green;
            btnOK.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOK.ForeColor = Color.White;
            btnOK.Location = new Point(74, 114);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 35);
            btnOK.TabIndex = 4;
            btnOK.Text = "Ok";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click_1;
            // 
            // FormAddQuantity
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 161);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            Controls.Add(nudQuantity);
            Controls.Add(lblStock);
            Controls.Add(lblProductName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormAddQuantity";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormAddQuantity";
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductName;
        private Label lblStock;
        private NumericUpDown nudQuantity;
        private Button btnCancel;
        private Button btnOK;
    }
}