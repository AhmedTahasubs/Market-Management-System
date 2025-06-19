namespace CanteenApp
{
    partial class Admin
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
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            EditBtn = new Button();
            DeleteBtn = new Button();
            AddBtn = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            comboBox2 = new ComboBox();
            dataGridView2 = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label7 = new Label();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label8 = new Label();
            label9 = new Label();
            textBox3 = new TextBox();
            comboBox3 = new ComboBox();
            dataGridView3 = new DataGridView();
            label10 = new Label();
            button10 = new Button();
            label12 = new Label();
            textBox4 = new TextBox();
            dataGridViewOrders = new DataGridView();
            button13 = new Button();
            Logoutbtn = new Button();
            button11 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 130);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(421, 165);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(220, 318);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(190, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 83);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 3;
            label1.Text = "Search By Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(220, 298);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 4;
            label2.Text = "Select to Edit or Delete";
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.FromArgb(0, 192, 0);
            EditBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditBtn.ForeColor = Color.White;
            EditBtn.Location = new Point(220, 347);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(75, 23);
            EditBtn.TabIndex = 5;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Red;
            DeleteBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(335, 347);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(75, 23);
            DeleteBtn.TabIndex = 6;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.FromArgb(0, 192, 0);
            AddBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(23, 309);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(142, 39);
            AddBtn.TabIndex = 7;
            AddBtn.Text = "Add new Product";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += button1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(23, 309);
            button1.Name = "button1";
            button1.Size = new Size(142, 39);
            button1.TabIndex = 15;
            button1.Text = "Add new Category";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(335, 347);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 192, 0);
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(220, 347);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 13;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(220, 298);
            label3.Name = "label3";
            label3.Size = new Size(125, 15);
            label3.TabIndex = 12;
            label3.Text = "Select to Edit or Delete";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(162, 83);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 11;
            label4.Text = "Search By Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(122, 101);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(173, 23);
            textBox2.TabIndex = 10;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(220, 318);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(190, 23);
            comboBox2.TabIndex = 9;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(0, 130);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(421, 165);
            dataGridView2.TabIndex = 8;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(109, 50);
            label5.Name = "label5";
            label5.Size = new Size(201, 30);
            label5.TabIndex = 16;
            label5.Text = "Prodcts Managment";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(103, 50);
            label6.Name = "label6";
            label6.Size = new Size(230, 30);
            label6.TabIndex = 17;
            label6.Text = "Categories Managment";
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(23, 12);
            button4.Name = "button4";
            button4.Size = new Size(75, 27);
            button4.TabIndex = 18;
            button4.Text = "Products";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(228, 12);
            button5.Name = "button5";
            button5.Size = new Size(75, 27);
            button5.TabIndex = 19;
            button5.Text = "Users";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Red;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(128, 12);
            button6.Name = "button6";
            button6.Size = new Size(75, 27);
            button6.TabIndex = 20;
            button6.Text = "Categories";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(103, 50);
            label7.Name = "label7";
            label7.Size = new Size(182, 30);
            label7.TabIndex = 29;
            label7.Text = "Users Managment";
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(0, 192, 0);
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Location = new Point(23, 309);
            button7.Name = "button7";
            button7.Size = new Size(142, 39);
            button7.TabIndex = 28;
            button7.Text = "Add new User";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Red;
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.White;
            button8.Location = new Point(335, 347);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 27;
            button8.Text = "Delete";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(0, 192, 0);
            button9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.White;
            button9.Location = new Point(220, 347);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 26;
            button9.Text = "Edit";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(220, 298);
            label8.Name = "label8";
            label8.Size = new Size(125, 15);
            label8.TabIndex = 25;
            label8.Text = "Select to Edit or Delete";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(162, 83);
            label9.Name = "label9";
            label9.Size = new Size(93, 15);
            label9.TabIndex = 24;
            label9.Text = "Search By Name";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(122, 101);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(173, 23);
            textBox3.TabIndex = 23;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(220, 318);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(190, 23);
            comboBox3.TabIndex = 22;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(0, 130);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(421, 165);
            dataGridView3.TabIndex = 21;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(103, 50);
            label10.Name = "label10";
            label10.Size = new Size(194, 30);
            label10.TabIndex = 38;
            label10.Text = "Orders Managment";
            // 
            // button10
            // 
            button10.BackColor = Color.GreenYellow;
            button10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.ForeColor = Color.Black;
            button10.Location = new Point(23, 366);
            button10.Name = "button10";
            button10.Size = new Size(142, 39);
            button10.TabIndex = 37;
            button10.Text = "Print Order";
            button10.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(132, 83);
            label12.Name = "label12";
            label12.Size = new Size(148, 15);
            label12.TabIndex = 33;
            label12.Text = "Search By Customer Name";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(122, 101);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(173, 23);
            textBox4.TabIndex = 32;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Location = new Point(0, 130);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.RowHeadersWidth = 51;
            dataGridViewOrders.Size = new Size(421, 165);
            dataGridViewOrders.TabIndex = 30;
            dataGridViewOrders.CellContentClick += dataGridViewOrders_CellContentClick;
            dataGridViewOrders.CellDoubleClick += dataGridViewOrders_CellDoubleClick;
            // 
            // button13
            // 
            button13.BackColor = Color.Red;
            button13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button13.ForeColor = Color.White;
            button13.Location = new Point(324, 12);
            button13.Name = "button13";
            button13.Size = new Size(75, 27);
            button13.TabIndex = 39;
            button13.Text = "Orders";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // Logoutbtn
            // 
            Logoutbtn.BackColor = Color.Red;
            Logoutbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Logoutbtn.ForeColor = Color.White;
            Logoutbtn.Location = new Point(295, 391);
            Logoutbtn.Name = "Logoutbtn";
            Logoutbtn.Size = new Size(116, 29);
            Logoutbtn.TabIndex = 40;
            Logoutbtn.Text = "Logout";
            Logoutbtn.UseVisualStyleBackColor = false;
            Logoutbtn.Click += Logoutbtn_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(0, 192, 0);
            button11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.ForeColor = Color.White;
            button11.Location = new Point(23, 308);
            button11.Name = "button11";
            button11.Size = new Size(142, 39);
            button11.TabIndex = 41;
            button11.Text = "Place Order";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 430);
            Controls.Add(button11);
            Controls.Add(Logoutbtn);
            Controls.Add(button13);
            Controls.Add(label10);
            Controls.Add(button10);
            Controls.Add(label12);
            Controls.Add(textBox4);
            Controls.Add(dataGridViewOrders);
            Controls.Add(label7);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(textBox3);
            Controls.Add(comboBox3);
            Controls.Add(dataGridView3);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(comboBox2);
            Controls.Add(dataGridView2);
            Controls.Add(AddBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(EditBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += Admin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button EditBtn;
        private Button DeleteBtn;
        private Button AddBtn;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private ComboBox comboBox2;
        private DataGridView dataGridView2;
        private Label label5;
        private Label label6;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label7;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label8;
        private Label label9;
        private TextBox textBox3;
        private ComboBox comboBox3;
        private DataGridView dataGridView3;
        private Label label10;
        private Button button10;
        private Label label12;
        private TextBox textBox4;
        private DataGridView dataGridViewOrders;
        private Button button13;
        private Button Logoutbtn;
        private Button button11;
    }
}