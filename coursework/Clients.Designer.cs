namespace coursework
{
    partial class Clients
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.NameSurname = new System.Windows.Forms.TextBox();
            this.PassportNumber = new System.Windows.Forms.TextBox();
            this.ClientIDBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ClientCreate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.PhoneRadio = new System.Windows.Forms.RadioButton();
            this.NameRadio = new System.Windows.Forms.RadioButton();
            this.PassportRadio = new System.Windows.Forms.RadioButton();
            this.EmailRadio = new System.Windows.Forms.RadioButton();
            this.Clear = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Mbutton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Fbutton = new System.Windows.Forms.RadioButton();
            this.RemoveClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name and Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sex";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Passport №";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Client ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(34, 112);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(68, 24);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(132, 112);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(87, 24);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // NameSurname
            // 
            this.NameSurname.Location = new System.Drawing.Point(31, 57);
            this.NameSurname.Name = "NameSurname";
            this.NameSurname.Size = new System.Drawing.Size(188, 26);
            this.NameSurname.TabIndex = 7;
            // 
            // PassportNumber
            // 
            this.PassportNumber.Location = new System.Drawing.Point(34, 168);
            this.PassportNumber.Name = "PassportNumber";
            this.PassportNumber.Size = new System.Drawing.Size(147, 26);
            this.PassportNumber.TabIndex = 8;
            this.PassportNumber.TextChanged += new System.EventHandler(this.PassportNumber_TextChanged);
            // 
            // ClientIDBox
            // 
            this.ClientIDBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientIDBox.Location = new System.Drawing.Point(37, 419);
            this.ClientIDBox.Name = "ClientIDBox";
            this.ClientIDBox.Size = new System.Drawing.Size(141, 26);
            this.ClientIDBox.TabIndex = 9;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(31, 232);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(188, 26);
            this.EmailBox.TabIndex = 11;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(31, 296);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(147, 26);
            this.PhoneBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Phone Number";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(37, 357);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(144, 26);
            this.PasswordBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Password";
            // 
            // ClientCreate
            // 
            this.ClientCreate.Location = new System.Drawing.Point(238, 399);
            this.ClientCreate.Name = "ClientCreate";
            this.ClientCreate.Size = new System.Drawing.Size(188, 46);
            this.ClientCreate.TabIndex = 17;
            this.ClientCreate.Text = "Create Client Account";
            this.ClientCreate.UseVisualStyleBackColor = true;
            this.ClientCreate.Click += new System.EventHandler(this.ClientCreate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(238, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(566, 350);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(806, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Search by:";
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.Location = new System.Drawing.Point(810, 57);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(241, 26);
            this.SearchtextBox.TabIndex = 20;
            // 
            // PhoneRadio
            // 
            this.PhoneRadio.AutoSize = true;
            this.PhoneRadio.Location = new System.Drawing.Point(813, 96);
            this.PhoneRadio.Name = "PhoneRadio";
            this.PhoneRadio.Size = new System.Drawing.Size(80, 24);
            this.PhoneRadio.TabIndex = 22;
            this.PhoneRadio.TabStop = true;
            this.PhoneRadio.Text = "Phone";
            this.PhoneRadio.UseVisualStyleBackColor = true;
            this.PhoneRadio.CheckedChanged += new System.EventHandler(this.PhoneRadio_CheckedChanged);
            // 
            // NameRadio
            // 
            this.NameRadio.AutoSize = true;
            this.NameRadio.Location = new System.Drawing.Point(902, 96);
            this.NameRadio.Name = "NameRadio";
            this.NameRadio.Size = new System.Drawing.Size(76, 24);
            this.NameRadio.TabIndex = 23;
            this.NameRadio.TabStop = true;
            this.NameRadio.Text = "Name";
            this.NameRadio.UseVisualStyleBackColor = true;
            this.NameRadio.CheckedChanged += new System.EventHandler(this.NameRadio_CheckedChanged);
            // 
            // PassportRadio
            // 
            this.PassportRadio.AutoSize = true;
            this.PassportRadio.Location = new System.Drawing.Point(813, 126);
            this.PassportRadio.Name = "PassportRadio";
            this.PassportRadio.Size = new System.Drawing.Size(97, 24);
            this.PassportRadio.TabIndex = 24;
            this.PassportRadio.TabStop = true;
            this.PassportRadio.Text = "Passport";
            this.PassportRadio.UseVisualStyleBackColor = true;
            // 
            // EmailRadio
            // 
            this.EmailRadio.AutoSize = true;
            this.EmailRadio.Location = new System.Drawing.Point(916, 126);
            this.EmailRadio.Name = "EmailRadio";
            this.EmailRadio.Size = new System.Drawing.Size(73, 24);
            this.EmailRadio.TabIndex = 25;
            this.EmailRadio.TabStop = true;
            this.EmailRadio.Text = "Email";
            this.EmailRadio.UseVisualStyleBackColor = true;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(810, 289);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(241, 31);
            this.Clear.TabIndex = 26;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(810, 156);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(237, 42);
            this.Search.TabIndex = 27;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(813, 355);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(237, 42);
            this.Update.TabIndex = 28;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(813, 403);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(241, 42);
            this.Edit.TabIndex = 29;
            this.Edit.Text = "Edit...";
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(823, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Sex";
            // 
            // Mbutton
            // 
            this.Mbutton.AutoSize = true;
            this.Mbutton.Location = new System.Drawing.Point(74, 10);
            this.Mbutton.Name = "Mbutton";
            this.Mbutton.Size = new System.Drawing.Size(47, 24);
            this.Mbutton.TabIndex = 33;
            this.Mbutton.TabStop = true;
            this.Mbutton.Text = "M";
            this.Mbutton.UseVisualStyleBackColor = true;
            this.Mbutton.CheckedChanged += new System.EventHandler(this.Mbutton_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Fbutton);
            this.panel1.Controls.Add(this.Mbutton);
            this.panel1.Location = new System.Drawing.Point(883, 232);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 51);
            this.panel1.TabIndex = 34;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Fbutton
            // 
            this.Fbutton.AutoSize = true;
            this.Fbutton.Location = new System.Drawing.Point(3, 12);
            this.Fbutton.Name = "Fbutton";
            this.Fbutton.Size = new System.Drawing.Size(44, 24);
            this.Fbutton.TabIndex = 34;
            this.Fbutton.TabStop = true;
            this.Fbutton.Text = "F";
            this.Fbutton.UseVisualStyleBackColor = true;
            this.Fbutton.CheckedChanged += new System.EventHandler(this.Fbutton_CheckedChanged);
            // 
            // RemoveClient
            // 
            this.RemoveClient.Location = new System.Drawing.Point(432, 399);
            this.RemoveClient.Name = "RemoveClient";
            this.RemoveClient.Size = new System.Drawing.Size(205, 43);
            this.RemoveClient.TabIndex = 35;
            this.RemoveClient.Text = "Remove Client Account";
            this.RemoveClient.UseVisualStyleBackColor = true;
            this.RemoveClient.Click += new System.EventHandler(this.RemoveClient_Click);
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 460);
            this.Controls.Add(this.RemoveClient);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.EmailRadio);
            this.Controls.Add(this.PassportRadio);
            this.Controls.Add(this.NameRadio);
            this.Controls.Add(this.PhoneRadio);
            this.Controls.Add(this.SearchtextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ClientCreate);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.ClientIDBox);
            this.Controls.Add(this.PassportNumber);
            this.Controls.Add(this.NameSurname);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Clients";
            this.Load += new System.EventHandler(this.Booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox NameSurname;
        private System.Windows.Forms.TextBox PassportNumber;
        private System.Windows.Forms.TextBox ClientIDBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ClientCreate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SearchtextBox;
        private System.Windows.Forms.RadioButton PhoneRadio;
        private System.Windows.Forms.RadioButton NameRadio;
        private System.Windows.Forms.RadioButton PassportRadio;
        private System.Windows.Forms.RadioButton EmailRadio;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton Mbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Fbutton;
        private System.Windows.Forms.Button RemoveClient;
    }
}