namespace coursework
{
    partial class Rooms
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
            this.VButton = new System.Windows.Forms.RadioButton();
            this.OButton = new System.Windows.Forms.RadioButton();
            this.Search = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(577, 359);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // VButton
            // 
            this.VButton.AutoSize = true;
            this.VButton.Location = new System.Drawing.Point(595, 11);
            this.VButton.Name = "VButton";
            this.VButton.Size = new System.Drawing.Size(85, 24);
            this.VButton.TabIndex = 28;
            this.VButton.TabStop = true;
            this.VButton.Text = "Vacant";
            this.VButton.UseVisualStyleBackColor = true;
            this.VButton.CheckedChanged += new System.EventHandler(this.VButton_CheckedChanged);
            // 
            // OButton
            // 
            this.OButton.AutoSize = true;
            this.OButton.Location = new System.Drawing.Point(717, 11);
            this.OButton.Name = "OButton";
            this.OButton.Size = new System.Drawing.Size(101, 24);
            this.OButton.TabIndex = 29;
            this.OButton.TabStop = true;
            this.OButton.Text = "Occupied";
            this.OButton.UseVisualStyleBackColor = true;
            this.OButton.CheckedChanged += new System.EventHandler(this.OButton_CheckedChanged_1);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(595, 175);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(237, 42);
            this.Search.TabIndex = 41;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(595, 47);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(223, 31);
            this.Clear.TabIndex = 40;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "sngl",
            "dbl",
            "twin"});
            this.checkedListBox1.Location = new System.Drawing.Point(595, 96);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(223, 73);
            this.checkedListBox1.TabIndex = 45;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 383);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.OButton);
            this.Controls.Add(this.VButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Rooms";
            this.Text = "rooms";
            this.Load += new System.EventHandler(this.Rooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton VButton;
        private System.Windows.Forms.RadioButton OButton;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}