namespace coursework
{
    partial class C_Orders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.ClearCart = new System.Windows.Forms.Button();
            this.OrdersBox = new System.Windows.Forms.TextBox();
            this.CreateOrd = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.O_IdBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GenbButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.c_idBox = new System.Windows.Forms.TextBox();
            this.totalPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(576, 360);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(594, 354);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(144, 32);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // ClearCart
            // 
            this.ClearCart.Location = new System.Drawing.Point(594, 316);
            this.ClearCart.Name = "ClearCart";
            this.ClearCart.Size = new System.Drawing.Size(144, 32);
            this.ClearCart.TabIndex = 4;
            this.ClearCart.Text = "Clear cart";
            this.ClearCart.UseVisualStyleBackColor = true;
            this.ClearCart.Click += new System.EventHandler(this.ClearCart_Click);
            // 
            // OrdersBox
            // 
            this.OrdersBox.Location = new System.Drawing.Point(594, 68);
            this.OrdersBox.Multiline = true;
            this.OrdersBox.Name = "OrdersBox";
            this.OrdersBox.ReadOnly = true;
            this.OrdersBox.Size = new System.Drawing.Size(144, 163);
            this.OrdersBox.TabIndex = 7;
            // 
            // CreateOrd
            // 
            this.CreateOrd.Location = new System.Drawing.Point(594, 392);
            this.CreateOrd.Name = "CreateOrd";
            this.CreateOrd.Size = new System.Drawing.Size(144, 32);
            this.CreateOrd.TabIndex = 12;
            this.CreateOrd.Text = "Create an order";
            this.CreateOrd.UseVisualStyleBackColor = true;
            this.CreateOrd.Click += new System.EventHandler(this.CreateOrd_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "service",
            "breakfast"});
            this.comboBox1.Location = new System.Drawing.Point(12, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // O_IdBox
            // 
            this.O_IdBox.Location = new System.Drawing.Point(512, 29);
            this.O_IdBox.Name = "O_IdBox";
            this.O_IdBox.ReadOnly = true;
            this.O_IdBox.Size = new System.Drawing.Size(127, 26);
            this.O_IdBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Order\'s ID";
            // 
            // GenbButton
            // 
            this.GenbButton.Location = new System.Drawing.Point(648, 30);
            this.GenbButton.Name = "GenbButton";
            this.GenbButton.Size = new System.Drawing.Size(90, 32);
            this.GenbButton.TabIndex = 16;
            this.GenbButton.Text = "Generate";
            this.GenbButton.UseVisualStyleBackColor = true;
            this.GenbButton.Click += new System.EventHandler(this.button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Client";
            // 
            // c_idBox
            // 
            this.c_idBox.Location = new System.Drawing.Point(223, 32);
            this.c_idBox.Name = "c_idBox";
            this.c_idBox.ReadOnly = true;
            this.c_idBox.Size = new System.Drawing.Size(115, 26);
            this.c_idBox.TabIndex = 17;
            this.c_idBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // totalPrice
            // 
            this.totalPrice.Location = new System.Drawing.Point(648, 263);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(89, 26);
            this.totalPrice.TabIndex = 19;
            this.totalPrice.TextChanged += new System.EventHandler(this.totalPrice_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(652, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Total price:";
            // 
            // C_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.c_idBox);
            this.Controls.Add(this.GenbButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.O_IdBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CreateOrd);
            this.Controls.Add(this.OrdersBox);
            this.Controls.Add(this.ClearCart);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "C_Orders";
            this.Load += new System.EventHandler(this.C_Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button ClearCart;
        private System.Windows.Forms.TextBox OrdersBox;
        private System.Windows.Forms.Button CreateOrd;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox O_IdBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GenbButton;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox c_idBox;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox totalPrice;
        private System.Windows.Forms.Label label1;
    }
}