namespace coursework
{
    partial class C_main
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
            this.CrObutton = new System.Windows.Forms.Button();
            this.LogOutB = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CompletedRadio = new System.Windows.Forms.RadioButton();
            this.InPRadio = new System.Windows.Forms.RadioButton();
            this.Clear = new System.Windows.Forms.Button();
            this.c_login = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CrObutton
            // 
            this.CrObutton.Location = new System.Drawing.Point(12, 89);
            this.CrObutton.Name = "CrObutton";
            this.CrObutton.Size = new System.Drawing.Size(146, 36);
            this.CrObutton.TabIndex = 1;
            this.CrObutton.Text = "Create an order...";
            this.CrObutton.UseVisualStyleBackColor = true;
            this.CrObutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // LogOutB
            // 
            this.LogOutB.Location = new System.Drawing.Point(12, 325);
            this.LogOutB.Name = "LogOutB";
            this.LogOutB.Size = new System.Drawing.Size(146, 32);
            this.LogOutB.TabIndex = 2;
            this.LogOutB.Text = "Log Out";
            this.LogOutB.UseVisualStyleBackColor = true;
            this.LogOutB.Click += new System.EventHandler(this.LogOutB_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(164, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(558, 345);
            this.dataGridView1.TabIndex = 3;
            // 
            // CompletedRadio
            // 
            this.CompletedRadio.AutoSize = true;
            this.CompletedRadio.Location = new System.Drawing.Point(728, 12);
            this.CompletedRadio.Name = "CompletedRadio";
            this.CompletedRadio.Size = new System.Drawing.Size(111, 24);
            this.CompletedRadio.TabIndex = 4;
            this.CompletedRadio.TabStop = true;
            this.CompletedRadio.Text = "Completed";
            this.CompletedRadio.UseVisualStyleBackColor = true;
            this.CompletedRadio.CheckedChanged += new System.EventHandler(this.CompletedRadio_CheckedChanged);
            // 
            // InPRadio
            // 
            this.InPRadio.AutoSize = true;
            this.InPRadio.Location = new System.Drawing.Point(728, 42);
            this.InPRadio.Name = "InPRadio";
            this.InPRadio.Size = new System.Drawing.Size(115, 24);
            this.InPRadio.TabIndex = 5;
            this.InPRadio.TabStop = true;
            this.InPRadio.Text = "In Progress";
            this.InPRadio.UseVisualStyleBackColor = true;
            this.InPRadio.CheckedChanged += new System.EventHandler(this.InPRadio_CheckedChanged);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(728, 72);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(142, 31);
            this.Clear.TabIndex = 28;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // c_login
            // 
            this.c_login.Location = new System.Drawing.Point(12, 12);
            this.c_login.Name = "c_login";
            this.c_login.Size = new System.Drawing.Size(146, 26);
            this.c_login.TabIndex = 29;
            this.c_login.TextChanged += new System.EventHandler(this.c_login_TextChanged);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(728, 109);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(142, 33);
            this.buttonUpdate.TabIndex = 30;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // C_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 365);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.c_login);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.InPRadio);
            this.Controls.Add(this.CompletedRadio);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LogOutB);
            this.Controls.Add(this.CrObutton);
            this.Name = "C_main";
            this.Text = "C_main";
            this.Load += new System.EventHandler(this.C_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CrObutton;
        private System.Windows.Forms.Button LogOutB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton CompletedRadio;
        private System.Windows.Forms.RadioButton InPRadio;
        private System.Windows.Forms.Button Clear;
        public System.Windows.Forms.TextBox c_login;
        private System.Windows.Forms.Button buttonUpdate;
    }
}