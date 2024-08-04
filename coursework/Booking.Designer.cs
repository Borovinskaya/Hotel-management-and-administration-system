namespace coursework
{
    partial class CreateABook
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
            this.AddBooking = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientIDBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateIn = new System.Windows.Forms.DateTimePicker();
            this.dateOut = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clientIDBox2 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.Cheque = new System.Windows.Forms.TextBox();
            this.Update = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.R_ID = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.B_id1 = new System.Windows.Forms.TextBox();
            this.B_id2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBooking
            // 
            this.AddBooking.Location = new System.Drawing.Point(344, 357);
            this.AddBooking.Name = "AddBooking";
            this.AddBooking.Size = new System.Drawing.Size(121, 34);
            this.AddBooking.TabIndex = 1;
            this.AddBooking.Text = "Add";
            this.AddBooking.UseVisualStyleBackColor = true;
            this.AddBooking.Click += new System.EventHandler(this.ChooseBooking_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(340, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(491, 307);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clientIDBox1
            // 
            this.clientIDBox1.Location = new System.Drawing.Point(182, 51);
            this.clientIDBox1.Name = "clientIDBox1";
            this.clientIDBox1.Size = new System.Drawing.Size(109, 26);
            this.clientIDBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Client ID 1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "sngl",
            "dbl",
            "twin"});
            this.comboBox1.Location = new System.Drawing.Point(24, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(855, 51);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(241, 26);
            this.textBox3.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(851, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Search by:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Chek In date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Chek out date";
            // 
            // dateIn
            // 
            this.dateIn.Location = new System.Drawing.Point(24, 169);
            this.dateIn.Name = "dateIn";
            this.dateIn.Size = new System.Drawing.Size(294, 26);
            this.dateIn.TabIndex = 28;
            // 
            // dateOut
            // 
            this.dateOut.Location = new System.Drawing.Point(24, 236);
            this.dateOut.Name = "dateOut";
            this.dateOut.Size = new System.Drawing.Size(294, 26);
            this.dateOut.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Room\'s type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Client ID 2";
            // 
            // clientIDBox2
            // 
            this.clientIDBox2.Location = new System.Drawing.Point(182, 112);
            this.clientIDBox2.Name = "clientIDBox2";
            this.clientIDBox2.Size = new System.Drawing.Size(109, 26);
            this.clientIDBox2.TabIndex = 31;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(960, 89);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 24);
            this.radioButton1.TabIndex = 35;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Name";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(859, 89);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 24);
            this.radioButton2.TabIndex = 34;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Room";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Cheque_ID";
            // 
            // Cheque
            // 
            this.Cheque.Location = new System.Drawing.Point(28, 361);
            this.Cheque.Name = "Cheque";
            this.Cheque.Size = new System.Drawing.Size(109, 26);
            this.Cheque.TabIndex = 36;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(855, 265);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(237, 42);
            this.Update.TabIndex = 40;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(855, 163);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(237, 42);
            this.Search.TabIndex = 39;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(855, 126);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(237, 31);
            this.Clear.TabIndex = 38;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(517, 357);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(121, 34);
            this.Remove.TabIndex = 41;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 43;
            this.label9.Text = "Room\'s ID";
            // 
            // R_ID
            // 
            this.R_ID.FormattingEnabled = true;
            this.R_ID.Items.AddRange(new object[] {
            "sngl",
            "dbl",
            "twin"});
            this.R_ID.Location = new System.Drawing.Point(28, 108);
            this.R_ID.Name = "R_ID";
            this.R_ID.Size = new System.Drawing.Size(121, 28);
            this.R_ID.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 20);
            this.label10.TabIndex = 44;
            this.label10.Text = "BookingID1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(178, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 20);
            this.label11.TabIndex = 45;
            this.label11.Text = "BookingID2";
            // 
            // B_id1
            // 
            this.B_id1.Location = new System.Drawing.Point(28, 309);
            this.B_id1.Name = "B_id1";
            this.B_id1.Size = new System.Drawing.Size(100, 26);
            this.B_id1.TabIndex = 46;
            // 
            // B_id2
            // 
            this.B_id2.Location = new System.Drawing.Point(182, 309);
            this.B_id2.Name = "B_id2";
            this.B_id2.Size = new System.Drawing.Size(100, 26);
            this.B_id2.TabIndex = 47;
            // 
            // CreateABook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 427);
            this.Controls.Add(this.B_id2);
            this.Controls.Add(this.B_id1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.R_ID);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Cheque);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientIDBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateOut);
            this.Controls.Add(this.dateIn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientIDBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddBooking);
            this.Name = "CreateABook";
            this.Text = "CreateABook";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddBooking;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox clientIDBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateIn;
        private System.Windows.Forms.DateTimePicker dateOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clientIDBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Cheque;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox R_ID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox B_id1;
        private System.Windows.Forms.TextBox B_id2;
    }
}