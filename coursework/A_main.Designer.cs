namespace coursework
{
    partial class A_main
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
            this.Log_out = new System.Windows.Forms.Button();
            this.Arooms = new System.Windows.Forms.Button();
            this.Aclients = new System.Windows.Forms.Button();
            this.Abookings = new System.Windows.Forms.Button();
            this.Acustomers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Log_out
            // 
            this.Log_out.Location = new System.Drawing.Point(47, 156);
            this.Log_out.Name = "Log_out";
            this.Log_out.Size = new System.Drawing.Size(125, 32);
            this.Log_out.TabIndex = 0;
            this.Log_out.Text = "Log Out";
            this.Log_out.UseVisualStyleBackColor = true;
            this.Log_out.Click += new System.EventHandler(this.Log_out_Click);
            // 
            // Arooms
            // 
            this.Arooms.Location = new System.Drawing.Point(47, 12);
            this.Arooms.Name = "Arooms";
            this.Arooms.Size = new System.Drawing.Size(125, 30);
            this.Arooms.TabIndex = 1;
            this.Arooms.Text = "Rooms";
            this.Arooms.UseVisualStyleBackColor = true;
            this.Arooms.Click += new System.EventHandler(this.Arooms_Click);
            // 
            // Aclients
            // 
            this.Aclients.Location = new System.Drawing.Point(47, 48);
            this.Aclients.Name = "Aclients";
            this.Aclients.Size = new System.Drawing.Size(125, 30);
            this.Aclients.TabIndex = 2;
            this.Aclients.Text = "Clients";
            this.Aclients.UseVisualStyleBackColor = true;
            this.Aclients.Click += new System.EventHandler(this.Aclients_Click);
            // 
            // Abookings
            // 
            this.Abookings.Location = new System.Drawing.Point(47, 84);
            this.Abookings.Name = "Abookings";
            this.Abookings.Size = new System.Drawing.Size(125, 30);
            this.Abookings.TabIndex = 3;
            this.Abookings.Text = "Bookings";
            this.Abookings.UseVisualStyleBackColor = true;
            this.Abookings.Click += new System.EventHandler(this.Abookings_Click);
            // 
            // Acustomers
            // 
            this.Acustomers.Location = new System.Drawing.Point(47, 120);
            this.Acustomers.Name = "Acustomers";
            this.Acustomers.Size = new System.Drawing.Size(125, 30);
            this.Acustomers.TabIndex = 4;
            this.Acustomers.Text = "Customers";
            this.Acustomers.UseVisualStyleBackColor = true;
            this.Acustomers.Click += new System.EventHandler(this.Acustomers_Click);
            // 
            // A_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 202);
            this.Controls.Add(this.Acustomers);
            this.Controls.Add(this.Abookings);
            this.Controls.Add(this.Aclients);
            this.Controls.Add(this.Arooms);
            this.Controls.Add(this.Log_out);
            this.Name = "A_main";
            this.Load += new System.EventHandler(this.A_main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Log_out;
        private System.Windows.Forms.Button Arooms;
        private System.Windows.Forms.Button Aclients;
        private System.Windows.Forms.Button Abookings;
        private System.Windows.Forms.Button Acustomers;
    }
}