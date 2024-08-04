using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace coursework
{
    public partial class C_login : Form
    {
        string s = "Host=localhost;Port=5432;Username=postgres;Password=YOURPASSWORD;Database=tabor"; // enter your host/password/etc.
        NpgsqlConnection conn;
        public C_login()
        {
            InitializeComponent();
            conn = new NpgsqlConnection(s);
            conn.Open();
            LoadData();
        }

        public void Log_in_Click(object sender, EventArgs e)
        {
            int login1 = Convert.ToInt32(textBoxL.Text);
            string password = textBoxP.Text;

            string query = "SELECT COUNT(1) FROM clients WHERE c_id = @login AND cpassword = @password";

            using (NpgsqlConnection connection = new NpgsqlConnection(s))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@login", login1);
                    command.Parameters.AddWithValue("@password", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        C_main mainForm = new C_main();
                        string loginValue = textBoxL.Text;
                        mainForm.c_login.Text = loginValue;
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login failed. Please check your credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            var Login = new Login();
            Login.Show();
            this.Hide();
        }
        private void LoadData()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(s))
            {
                conn.Open();
            }
        }
        public void textBoxL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
