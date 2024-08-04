namespace coursework
{
    partial class C_login
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
            this.Back = new System.Windows.Forms.Button();
            this.Log_in = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxL = new System.Windows.Forms.TextBox();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(30, 312);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(155, 47);
            this.Back.TabIndex = 9;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Log_in
            // 
            this.Log_in.Location = new System.Drawing.Point(30, 259);
            this.Log_in.Name = "Log_in";
            this.Log_in.Size = new System.Drawing.Size(155, 47);
            this.Log_in.TabIndex = 8;
            this.Log_in.Text = "Log in";
            this.Log_in.UseVisualStyleBackColor = true;
            this.Log_in.Click += new System.EventHandler(this.Log_in_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Login (Your ID)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login as Client";
            // 
            // textBoxL
            // 
            this.textBoxL.Location = new System.Drawing.Point(26, 112);
            this.textBoxL.Name = "textBoxL";
            this.textBoxL.Size = new System.Drawing.Size(159, 26);
            this.textBoxL.TabIndex = 10;
            this.textBoxL.TextChanged += new System.EventHandler(this.textBoxL_TextChanged);
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(26, 180);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.PasswordChar = '*';
            this.textBoxP.Size = new System.Drawing.Size(159, 26);
            this.textBoxP.TabIndex = 11;
            // 
            // C_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 387);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.textBoxL);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Log_in);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "C_login";
            this.Text = "C_login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Log_in;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxL;
        private System.Windows.Forms.TextBox textBoxP;
    }
}