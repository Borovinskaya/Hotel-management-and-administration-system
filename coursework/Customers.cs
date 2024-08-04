using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace coursework
{
    public partial class Customers : Form
    {
        string s = "Host=localhost;Port=5432;Username=postgres;Password=YOURPASSWORD;Database=tabor"; // enter your host/password/etc.
        NpgsqlConnection conn;
        public Customers()
        {
            InitializeComponent();
            conn = new NpgsqlConnection(s);
            conn.Open();
            LoadData();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            if (PhoneRadio.Checked)
            {
                PhoneRadio.Checked = false;
            }
            if (NameRadio.Checked)
            {
                PhoneRadio.Checked = false;
            }
            LoadData();
        }

        private void IDradio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PhoneRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NameRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SearchtextBox_TextChanged(object sender, EventArgs e)
        {

        }



        public void Search_Click(object sender, EventArgs e)
        {
            string searchColumn = "";

            if (PhoneRadio.Checked)
            {
                searchColumn = "phone";
            }
            if (NameRadio.Checked)
            {
                searchColumn = "fullname";
            }

            string searchText = SearchtextBox.Text;

            using (NpgsqlConnection conn = new NpgsqlConnection(s))
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    string sql = "SELECT * FROM employees WHERE " + searchColumn + " LIKE '%" + searchText + "%'";
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
        private void LoadData()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(s))
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    string sql = "SELECT * FROM employees";
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
                    string sql = "SELECT * FROM employees";
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
        public void EmployeeCreate_Click(object sender, EventArgs e)
        {
            int e_id = Convert.ToInt32(eID.Text);
            string phone = PhonetextBox.Text;
            string name = NametextBox.Text;
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string login = LogintextBox.Text;
            string password = PasswordtextBox.Text;
            string post = postBox.Text;
            string address = AddresstextBox.Text;
            int salary =Convert.ToInt32( SalarytextBox.Text);

            using (NpgsqlConnection conn = new NpgsqlConnection(s))
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    string sql = $"insert into employees (E_ID, fullname, dateofbirth, login, epassword, post, phone, homeaddress, salary) values ({e_id}, '{name}', '{date}', '{login}', '{password}', '{post}', '{phone}', '{address}', {salary})";
                    eID.Clear();
                    PhonetextBox.Clear();
                    NametextBox.Clear();
                    AddresstextBox.Clear();
                    LogintextBox.Clear();
                    SalarytextBox.Clear();
                    PasswordtextBox.Clear();
                    postBox.SelectedIndex=-1;
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("E_ID", e_id);
                        cmd.Parameters.AddWithValue("fullname", name);
                        cmd.Parameters.AddWithValue("phone", phone);
                        cmd.Parameters.AddWithValue("dateofbirth", date);
                        cmd.Parameters.AddWithValue("login", login);
                        cmd.Parameters.AddWithValue("epassword", password);
                        cmd.Parameters.AddWithValue("post", post);
                        cmd.Parameters.AddWithValue("homeaddress", address);
                        cmd.Parameters.AddWithValue("salary", salary);


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

        private void EmployeeDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove this Employee?", "", MessageBoxButtons.OK) == DialogResult.OK) ;
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(s))
                {
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        int e_id = Convert.ToInt16(eID.Text);
                        string sql = $"DELETE FROM employees WHERE e_id = {e_id}";
                        eID.Clear();
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
