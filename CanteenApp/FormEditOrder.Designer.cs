namespace CanteenApp
{
    partial class FormEditOrder
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
            dataGridViewItems = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            txtCustomerName = new TextBox();
            btnPlaceOrder = new Button();
            button1 = new Button();
            LblGrandTotal = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewItems
            // 
            dataGridViewItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItems.Location = new Point(0, 36);
            dataGridViewItems.Name = "dataGridViewItems";
            dataGridViewItems.RowHeadersWidth = 51;
            dataGridViewItems.Size = new Size(555, 165);
            dataGridViewItems.TabIndex = 13;
            dataGridViewItems.CellEndEdit += dataGridViewItems_CellEndEdit;
            dataGridViewItems.SelectionChanged += dataGridViewItems_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(208, 1);
            label2.Name = "label2";
            label2.Size = new Size(140, 32);
            label2.TabIndex = 14;
            label2.Text = "Order Items";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 207);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 19;
            label3.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(12, 229);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(173, 23);
            txtCustomerName.TabIndex = 18;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.BackColor = Color.Red;
            btnPlaceOrder.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnPlaceOrder.ForeColor = Color.White;
            btnPlaceOrder.Location = new Point(445, 268);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(98, 40);
            btnPlaceOrder.TabIndex = 20;
            btnPlaceOrder.Text = "Cancel";
            btnPlaceOrder.UseVisualStyleBackColor = false;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(13, 268);
            button1.Name = "button1";
            button1.Size = new Size(172, 40);
            button1.TabIndex = 21;
            button1.Text = "Save Changes";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LblGrandTotal
            // 
            LblGrandTotal.AutoSize = true;
            LblGrandTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblGrandTotal.Location = new Point(365, 214);
            LblGrandTotal.Name = "LblGrandTotal";
            LblGrandTotal.Size = new Size(117, 25);
            LblGrandTotal.TabIndex = 22;
            LblGrandTotal.Text = "Total: 0 EGP";
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(233, 212);
            button2.Name = "button2";
            button2.Size = new Size(101, 27);
            button2.TabIndex = 23;
            button2.Text = "Delete Item";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FormEditOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 320);
            Controls.Add(button2);
            Controls.Add(LblGrandTotal);
            Controls.Add(button1);
            Controls.Add(btnPlaceOrder);
            Controls.Add(label3);
            Controls.Add(txtCustomerName);
            Controls.Add(label2);
            Controls.Add(dataGridViewItems);
            MaximizeBox = false;
            Name = "FormEditOrder";
            Text = "FormEditOrder";
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewItems;
        private Label label2;
        private Label label3;
        private TextBox txtCustomerName;
        private Button btnPlaceOrder;
        private Button button1;
        private Label LblGrandTotal;
        private Button button2;
    }
}