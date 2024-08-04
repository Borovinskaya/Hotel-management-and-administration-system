namespace coursework
{
    partial class Login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.asEmployee = new System.Windows.Forms.Button();
            this.asClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login as...";
            // 
            // asEmployee
            // 
            this.asEmployee.Location = new System.Drawing.Point(23, 68);
            this.asEmployee.Name = "asEmployee";
            this.asEmployee.Size = new System.Drawing.Size(150, 51);
            this.asEmployee.TabIndex = 2;
            this.asEmployee.Text = "Employee";
            this.asEmployee.UseVisualStyleBackColor = true;
            this.asEmployee.Click += new System.EventHandler(this.asEmployee_Click);
            // 
            // asClient
            // 
            this.asClient.Location = new System.Drawing.Point(179, 68);
            this.asClient.Name = "asClient";
            this.asClient.Size = new System.Drawing.Size(150, 51);
            this.asClient.TabIndex = 3;
            this.asClient.Text = "Client";
            this.asClient.UseVisualStyleBackColor = true;
            this.asClient.Click += new System.EventHandler(this.asClient_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 141);
            this.Controls.Add(this.asClient);
            this.Controls.Add(this.asEmployee);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button asEmployee;
        private System.Windows.Forms.Button asClient;
    }
}

