namespace coursework
{
    partial class S_main
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderTake = new System.Windows.Forms.Button();
            this.Log_out = new System.Windows.Forms.Button();
            this.InPRadio = new System.Windows.Forms.RadioButton();
            this.CompletedRadio = new System.Windows.Forms.RadioButton();
            this.Clear = new System.Windows.Forms.Button();
            this.s_idtext = new System.Windows.Forms.TextBox();
            this.OrdtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.myOrders = new System.Windows.Forms.Button();
            this.VacantRadio = new System.Windows.Forms.RadioButton();
            this.markCompl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(160, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(743, 406);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // orderTake
            // 
            this.orderTake.Location = new System.Drawing.Point(8, 110);
            this.orderTake.Name = "orderTake";
            this.orderTake.Size = new System.Drawing.Size(142, 41);
            this.orderTake.TabIndex = 1;
            this.orderTake.Text = "Take an order";
            this.orderTake.UseVisualStyleBackColor = true;
            this.orderTake.Click += new System.EventHandler(this.Take_an_order_Click);
            // 
            // Log_out
            // 
            this.Log_out.Location = new System.Drawing.Point(12, 429);
            this.Log_out.Name = "Log_out";
            this.Log_out.Size = new System.Drawing.Size(142, 32);
            this.Log_out.TabIndex = 5;
            this.Log_out.Text = "Log Out";
            this.Log_out.UseVisualStyleBackColor = true;
            this.Log_out.Click += new System.EventHandler(this.Log_out_Click);
            // 
            // InPRadio
            // 
            this.InPRadio.AutoSize = true;
            this.InPRadio.Location = new System.Drawing.Point(8, 275);
            this.InPRadio.Name = "InPRadio";
            this.InPRadio.Size = new System.Drawing.Size(115, 24);
            this.InPRadio.TabIndex = 7;
            this.InPRadio.TabStop = true;
            this.InPRadio.Text = "In Progress";
            this.InPRadio.UseVisualStyleBackColor = true;
            this.InPRadio.CheckedChanged += new System.EventHandler(this.InPRadio_CheckedChanged);
            // 
            // CompletedRadio
            // 
            this.CompletedRadio.AutoSize = true;
            this.CompletedRadio.Location = new System.Drawing.Point(8, 247);
            this.CompletedRadio.Name = "CompletedRadio";
            this.CompletedRadio.Size = new System.Drawing.Size(111, 24);
            this.CompletedRadio.TabIndex = 6;
            this.CompletedRadio.TabStop = true;
            this.CompletedRadio.Text = "Completed";
            this.CompletedRadio.UseVisualStyleBackColor = true;
            this.CompletedRadio.CheckedChanged += new System.EventHandler(this.CompletedRadio_CheckedChanged);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(8, 315);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(142, 31);
            this.Clear.TabIndex = 27;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // s_idtext
            // 
            this.s_idtext.Location = new System.Drawing.Point(160, 23);
            this.s_idtext.Name = "s_idtext";
            this.s_idtext.Size = new System.Drawing.Size(124, 26);
            this.s_idtext.TabIndex = 29;
            this.s_idtext.TextChanged += new System.EventHandler(this.s_idText_TextChanged);
            // 
            // OrdtextBox
            // 
            this.OrdtextBox.Location = new System.Drawing.Point(8, 78);
            this.OrdtextBox.Name = "OrdtextBox";
            this.OrdtextBox.Size = new System.Drawing.Size(142, 26);
            this.OrdtextBox.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Order ID";
            // 
            // myOrders
            // 
            this.myOrders.Location = new System.Drawing.Point(290, 15);
            this.myOrders.Name = "myOrders";
            this.myOrders.Size = new System.Drawing.Size(121, 34);
            this.myOrders.TabIndex = 33;
            this.myOrders.Text = "My orders";
            this.myOrders.UseVisualStyleBackColor = true;
            this.myOrders.Click += new System.EventHandler(this.myOrders_Click);
            // 
            // VacantRadio
            // 
            this.VacantRadio.AutoSize = true;
            this.VacantRadio.Location = new System.Drawing.Point(8, 222);
            this.VacantRadio.Name = "VacantRadio";
            this.VacantRadio.Size = new System.Drawing.Size(85, 24);
            this.VacantRadio.TabIndex = 35;
            this.VacantRadio.TabStop = true;
            this.VacantRadio.Text = "Vacant";
            this.VacantRadio.UseVisualStyleBackColor = true;
            this.VacantRadio.CheckedChanged += new System.EventHandler(this.VacantRadio_CheckedChanged);
            // 
            // markCompl
            // 
            this.markCompl.Location = new System.Drawing.Point(8, 158);
            this.markCompl.Name = "markCompl";
            this.markCompl.Size = new System.Drawing.Size(142, 58);
            this.markCompl.TabIndex = 36;
            this.markCompl.Text = "Mark as completed";
            this.markCompl.UseVisualStyleBackColor = true;
            this.markCompl.Click += new System.EventHandler(this.markCompl_Click);
            // 
            // S_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 481);
            this.Controls.Add(this.markCompl);
            this.Controls.Add(this.VacantRadio);
            this.Controls.Add(this.myOrders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrdtextBox);
            this.Controls.Add(this.s_idtext);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.InPRadio);
            this.Controls.Add(this.CompletedRadio);
            this.Controls.Add(this.Log_out);
            this.Controls.Add(this.orderTake);
            this.Controls.Add(this.dataGridView1);
            this.Name = "S_main";
            this.Text = "S_main";
            this.Load += new System.EventHandler(this.S_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button orderTake;
        private System.Windows.Forms.Button Log_out;
        private System.Windows.Forms.RadioButton InPRadio;
        private System.Windows.Forms.RadioButton CompletedRadio;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox OrdtextBox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox s_idtext;
        private System.Windows.Forms.Button myOrders;
        private System.Windows.Forms.RadioButton VacantRadio;
        private System.Windows.Forms.Button markCompl;
    }
}