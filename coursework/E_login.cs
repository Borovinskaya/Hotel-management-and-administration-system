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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Npgsql;

namespace coursework
{
    public partial class E_login : Form 
    {
        string s = "Host=localhost;Port=5432;Username=postgres;Password=YOURPASSWORD;Database=tabor"; // enter your host/password/etc.
        NpgsqlConnection conn;
        public E_login()
        {
            InitializeComponent();
            conn = new NpgsqlConnection(s);
            conn.Open();
            LoadData();
        }
        
        public  void E_login_Load(object sender, EventArgs e)
        {


        }

        private void Back_Click(object sender, EventArgs e)
        {
            var Login = new Login();
            Login.Show();
            this.Hide();
        }

        private void radioB_A_CheckedChanged(object sender, EventArgs e)
        {
        }

        public void Log_in_Click(object sender, EventArgs e)
        {
            if (radioB_A.Checked)
            {
                string login = textBoxL.Text;
                string password = textBoxP.Text;

                string query = "SELECT COUNT(1) FROM employees WHERE login = @login AND epassword = @password AND post = 'administrator'";

                using (NpgsqlConnection connection = new NpgsqlConnection(s))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@password", password);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            A_main frm = new A_main();
                            frm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Login failed. Please check your credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
            if (radioB_S.Checked)
            {

                string slogin = textBoxL.Text;
                    string password = textBoxP.Text;

                    string query = "SELECT COUNT(1) FROM employees WHERE login = @login AND epassword = @password AND post = 'service'";

                    using (NpgsqlConnection connection = new NpgsqlConnection(s))
                    {
                        connection.Open();

                        using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@login", slogin);
                            command.Parameters.AddWithValue("@password", password);

                            int count = Convert.ToInt32(command.ExecuteScalar());

                            if (count > 0)
                            {

                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            S_main mainForm = new S_main();
                            string loginValue = textBoxL.Text;
                            mainForm.s_idtext.Text = loginValue;
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
        }

        public void textBoxL_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxP_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(s))
            {
                conn.Open();
            }
        }
    }
}
