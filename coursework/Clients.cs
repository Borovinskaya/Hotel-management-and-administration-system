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

namespace coursework
{
    public partial class Clients : Form
    {
        string s = "Host=localhost;Port=5432;Username=postgres;Password=YOURPASSWORD;Database=tabor"; // enter your host/password/etc.
        NpgsqlConnection conn;
        public Clients()
        {
            InitializeComponent();
            conn = new NpgsqlConnection(s);
            conn.Open();
            LoadData();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PassportNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Booking_Load(object sender, EventArgs e)
        {

        }

        private void ClientCreate_Click(object sender, EventArgs e)
        {
            int c_id = Convert.ToInt32(ClientIDBox.Text);
            string name = NameSurname.Text;
            string passport = PassportNumber.Text;
            string email = EmailBox.Text;
            string phone = PhoneBox.Text;
            string password = PasswordBox.Text;
            string sex = "";
            if (radioButton1.Checked)
            {
                sex = "m";
            }
            if (radioButton2.Checked)
            {
                sex = "f";
            }
            using (NpgsqlConnection conn = new NpgsqlConnection(s))
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    string sql = $"INSERT INTO clients (C_ID, fullname, sex, passport, email, cpassword, phone) VALUES ({c_id}, '{name}', '{sex}', '{passport}', '{email}', '{password}', '{phone}')";
                    NameSurname.Clear();
                    PassportNumber.Clear();
                    EmailBox.Clear();
                    PhoneBox.Clear();
                    PasswordBox.Clear();
                    PassportNumber.Clear();
                    ClientIDBox.Clear();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("C_ID", c_id);
                        cmd.Parameters.AddWithValue("fullname", name);
                        cmd.Parameters.AddWithValue("sex", sex);
                        cmd.Parameters.AddWithValue("passport", passport);
                        cmd.Parameters.AddWithValue("email", email);
                        cmd.Parameters.AddWithValue("cpassword", password);
                        cmd.Parameters.AddWithValue("phone", phone);

                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadData()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(s))
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    string sql = "SELECT * FROM clients";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                    {
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string searchText = SearchtextBox.Text;
            string searchColumn = "";
            if (PhoneRadio.Checked)
            {
                searchColumn = "phone";
            }
            if (NameRadio.Checked)
            {
                searchColumn = "fullname";
            }
            if (PassportRadio.Checked)
            {
                searchColumn = "passport";
            }


            using (NpgsqlConnection conn = new NpgsqlConnection(s))
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    string sql = "SELECT * FROM clients WHERE " + searchColumn + " LIKE '%" + searchText + "%'";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                    {
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
    }

        private void Clear_Click(object sender, EventArgs e)
        {
            Mbutton.Checked= false;
            Fbutton.Checked = false;
            PhoneRadio.Checked = false;
            PhoneRadio.Checked = false;
            PassportRadio.Checked = false;
            SearchtextBox.Clear();
            LoadData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Mbutton_CheckedChanged(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(s))
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    string sql = "SELECT * FROM clients WHERE sex = 'm'";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                    {
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
        }

        private void Fbutton_CheckedChanged(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(s))
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    string sql = "SELECT * FROM clients WHERE sex = 'f'";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                    {
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(s))
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    string sql = "SELECT * FROM clients";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                    {
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
        }

        private void PhoneRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NameRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RemoveClient_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove this Client?", "", MessageBoxButtons.OK)==DialogResult.OK);
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(s))
                {
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        int c_id = Convert.ToInt32(ClientIDBox.Text);
                        string sql = $"DELETE FROM clients WHERE C_ID = {c_id}";
                        ClientIDBox.Clear();
                        using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                        {
                            using (NpgsqlDataReader dr = cmd.ExecuteReader())
                            {
                                DataTable dt = new DataTable();
                                dt.Load(dr);
                                dataGridView1.DataSource = dt;
                            }
                        }
                    }
                }
            }
            
        }
    }
}
