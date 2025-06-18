namespace CanteenApp
{
    partial class FormOrderDetails
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
            lblCustomerName = new Label();
            lblOrderDate = new Label();
            lblTotal = new Label();
            dataGridViewItems = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).BeginInit();
            SuspendLayout();
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerName.Location = new Point(12, 4);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(57, 21);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "label1";
            lblCustomerName.Click += label1_Click;
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrderDate.Location = new Point(12, 35);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(43, 17);
            lblOrderDate.TabIndex = 1;
            lblOrderDate.Text = "label2";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.DarkGreen;
            lblTotal.Location = new Point(12, 63);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(51, 20);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "label3";
            // 
            // dataGridViewItems
            // 
            dataGridViewItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItems.Location = new Point(12, 86);
            dataGridViewItems.Name = "dataGridViewItems";
            dataGridViewItems.Size = new Size(410, 150);
            dataGridViewItems.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(332, 242);
            button1.Name = "button1";
            button1.Size = new Size(90, 38);
            button1.TabIndex = 4;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormOrderDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(434, 292);
            Controls.Add(button1);
            Controls.Add(dataGridViewItems);
            Controls.Add(lblTotal);
            Controls.Add(lblOrderDate);
            Controls.Add(lblCustomerName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormOrderDetails";
            Text = "FormOrderDetails";
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomerName;
        private Label lblOrderDate;
        private Label lblTotal;
        private DataGridView dataGridViewItems;
        private Button button1;
    }
}