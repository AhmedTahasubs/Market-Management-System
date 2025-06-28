namespace CanteenApp
{
    partial class User
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
            label1 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label2 = new Label();
            lblTotal = new Label();
            btnPlaceOrder = new Button();
            txtCustomerName = new TextBox();
            label3 = new Label();
            Logoutbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 3);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 11;
            label1.Text = "Search By Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(88, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 23);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(370, 165);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(375, 50);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(555, 165);
            dataGridView2.TabIndex = 12;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            dataGridView2.CellDoubleClick += dataGridView2_CellDoubleClick_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(524, 12);
            label2.Name = "label2";
            label2.Size = new Size(122, 32);
            label2.TabIndex = 13;
            label2.Text = "Cart Items";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(375, 264);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(65, 32);
            lblTotal.TabIndex = 14;
            lblTotal.Text = "Total";
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.BackColor = Color.Green;
            btnPlaceOrder.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnPlaceOrder.ForeColor = Color.White;
            btnPlaceOrder.Location = new Point(375, 298);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(172, 40);
            btnPlaceOrder.TabIndex = 15;
            btnPlaceOrder.Text = "Order";
            btnPlaceOrder.UseVisualStyleBackColor = false;
            btnPlaceOrder.Click += btnPlaceOrder_Click_1;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(375, 240);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(173, 23);
            txtCustomerName.TabIndex = 16;
            txtCustomerName.TextChanged += txtCustomerName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(375, 218);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 17;
            label3.Text = "Customer Name";
            // 
            // Logoutbtn
            // 
            Logoutbtn.BackColor = Color.Red;
            Logoutbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Logoutbtn.ForeColor = Color.White;
            Logoutbtn.Location = new Point(788, 322);
            Logoutbtn.Name = "Logoutbtn";
            Logoutbtn.Size = new Size(116, 29);
            Logoutbtn.TabIndex = 41;
            Logoutbtn.Text = "Logout";
            Logoutbtn.UseVisualStyleBackColor = false;
            Logoutbtn.Click += Logoutbtn_Click;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 363);
            Controls.Add(Logoutbtn);
            Controls.Add(label3);
            Controls.Add(txtCustomerName);
            Controls.Add(btnPlaceOrder);
            Controls.Add(lblTotal);
            Controls.Add(label2);
            Controls.Add(dataGridView2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
            Load += User_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label2;
        private Label lblTotal;
        private Button btnPlaceOrder;
        private TextBox txtCustomerName;
        private Label label3;
        private Button Logoutbtn;
    }
}