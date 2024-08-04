namespace coursework
{
    partial class E_login
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
            this.Log_in = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.textBoxL = new System.Windows.Forms.TextBox();
            this.radioB_A = new System.Windows.Forms.RadioButton();
            this.radioB_S = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login as...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // Log_in
            // 
            this.Log_in.Location = new System.Drawing.Point(20, 267);
            this.Log_in.Name = "Log_in";
            this.Log_in.Size = new System.Drawing.Size(230, 47);
            this.Log_in.TabIndex = 3;
            this.Log_in.Text = "Log in";
            this.Log_in.UseVisualStyleBackColor = true;
            this.Log_in.Click += new System.EventHandler(this.Log_in_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(20, 320);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(230, 47);
            this.Back.TabIndex = 4;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(20, 207);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.PasswordChar = '*';
            this.textBoxP.Size = new System.Drawing.Size(230, 26);
            this.textBoxP.TabIndex = 13;
            this.textBoxP.TextChanged += new System.EventHandler(this.textBoxP_TextChanged);
            // 
            // textBoxL
            // 
            this.textBoxL.Location = new System.Drawing.Point(20, 136);
            this.textBoxL.Name = "textBoxL";
            this.textBoxL.Size = new System.Drawing.Size(230, 26);
            this.textBoxL.TabIndex = 12;
            this.textBoxL.TextChanged += new System.EventHandler(this.textBoxL_TextChanged);
            // 
            // radioB_A
            // 
            this.radioB_A.AutoSize = true;
            this.radioB_A.Location = new System.Drawing.Point(20, 71);
            this.radioB_A.Name = "radioB_A";
            this.radioB_A.Size = new System.Drawing.Size(128, 24);
            this.radioB_A.TabIndex = 14;
            this.radioB_A.TabStop = true;
            this.radioB_A.Text = "Administrator";
            this.radioB_A.UseVisualStyleBackColor = true;
            this.radioB_A.CheckedChanged += new System.EventHandler(this.radioB_A_CheckedChanged);
            // 
            // radioB_S
            // 
            this.radioB_S.AutoSize = true;
            this.radioB_S.Location = new System.Drawing.Point(164, 71);
            this.radioB_S.Name = "radioB_S";
            this.radioB_S.Size = new System.Drawing.Size(86, 24);
            this.radioB_S.TabIndex = 15;
            this.radioB_S.TabStop = true;
            this.radioB_S.Text = "Service";
            this.radioB_S.UseVisualStyleBackColor = true;
            // 
            // E_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 379);
            this.Controls.Add(this.radioB_S);
            this.Controls.Add(this.radioB_A);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.textBoxL);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Log_in);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "E_login";
            this.Text = "E_login";
            this.Load += new System.EventHandler(this.E_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Log_in;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.TextBox textBoxL;
        private System.Windows.Forms.RadioButton radioB_A;
        private System.Windows.Forms.RadioButton radioB_S;
    }
}