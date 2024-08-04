using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace coursework
{
    public partial class CreateABook : Form
    {
        string s = "Host=localhost;Port=5432;Username=postgres;Password=YOURPASSWORD;Database=tabor"; // enter your host/password/etc.
        NpgsqlConnection conn;
        public CreateABook()
        {
            InitializeComponent();
            conn = new NpgsqlConnection(s);
            conn.Open();
            LoadData();
        }
        private void LoadData()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(s))
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    string sql = "SELECT * FROM bookings";
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

        private void monthCalendar1_BackColorChanged(object sender, EventArgs e)
        {
           

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label2.Hide();
                clientIDBox2.Hide();
                B_id2.Hide();
                label11.Hide();
                R_ID.Items.Clear();
                R_ID.Items.AddRange(new string[] { "102", "103", "105", "107" });
            }
            else 
            {
                B_id2.Show();
                label11.Show();
                label2.Show();
                clientIDBox2.Show();
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "dbl":
                        R_ID.Items.Clear();
                        R_ID.Items.Add("104");
                        break;
                    case "twin":
                        R_ID.Items.Clear();
                        R_ID.Items.AddRange(new string[] { "101", "106" });
                        break;
                    default:
                        break;
                }
            }
            }

        public void ChooseBooking_Click(object sender, EventArgs e)
        {
            int c_id1 = Convert.ToInt32(clientIDBox1.Text);
            int b_id1 = Convert.ToInt32(B_id1.Text);
            string datein = dateIn.Value.ToString("yyyy-MM-dd");
            string dateout = dateOut.Value.ToString("yyyy-MM-dd");
            int r_id = Convert.ToInt32(R_ID.Text);
            int paysngl = 2700*(dateOut.Value-dateIn.Value).Days;
            int paydbl = 6000 * (dateOut.Value - dateIn.Value).Days;
            int paytwin = 6500 * (dateOut.Value - dateIn.Value).Days;
            int ch_id = Convert.ToInt32(Cheque.Text);

            if (comboBox1.SelectedIndex == 0)
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(s))
                {
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        string sql = $"insert into bookings (c_id, R_ID, bookin, bookout, B_ID, payment, cheque_id) values ({c_id1}, {r_id}, '{datein}', '{dateout}', {b_id1}, {paydbl}, {ch_id})";
                        using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("c_id", c_id1);
                            cmd.Parameters.AddWithValue("b_id", b_id1);
                            cmd.Parameters.AddWithValue("r_id", r_id);
                            cmd.Parameters.AddWithValue("bookin", datein);
                            cmd.Parameters.AddWithValue("bookout", dateout);
                            cmd.Parameters.AddWithValue("payment", paysngl);



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
            if (comboBox1.SelectedIndex == 1)
            {
                int c_id2 = Convert.ToInt32(clientIDBox2.Text);
                int b_id2 = Convert.ToInt32(B_id2.Text);

                using (NpgsqlConnection conn = new NpgsqlConnection(s))
                {
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        string sql = $"insert into bookings (c_id, R_ID, bookin, bookout, B_ID, payment, cheque_id) values ({c_id2}, {r_id}, '{datein}', '{dateout}', {b_id2}, {paydbl}, {ch_id}), ({c_id1}, {r_id}, '{datein}', '{dateout}', {b_id1}, {paydbl}, {ch_id})";
                        clientIDBox1.Clear();
                        using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("c_id", c_id1);
                            cmd.Parameters.AddWithValue("c_id", c_id2);
                            cmd.Parameters.AddWithValue("b_id", b_id1);
                            cmd.Parameters.AddWithValue("b_id", b_id2);
                            cmd.Parameters.AddWithValue("r_id", r_id);
                            cmd.Parameters.AddWithValue("bookin", datein);
                            cmd.Parameters.AddWithValue("bookout", dateout);
                            cmd.Parameters.AddWithValue("payment", paydbl);

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
            if (comboBox1.SelectedIndex == 2)
            {
                int c_id2 = Convert.ToInt32(clientIDBox2.Text);
                int b_id2 = Convert.ToInt32(B_id2.Text);

                using (NpgsqlConnection conn = new NpgsqlConnection(s))
                {
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        string sql = $"insert into bookings (c_id, R_ID, bookin, bookout, B_ID, payment, cheque_id) values ({c_id1}, {r_id}, '{datein}', '{dateout}', {b_id1}, {paytwin}, {ch_id}), ({c_id2}, {r_id}, '{datein}', '{dateout}', {b_id2}, {paytwin}, {ch_id}); UPDATE rooms SET status = 1 WHERE r_id={r_id}";
                        using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("c_id", c_id1);
                            cmd.Parameters.AddWithValue("c_id", c_id2);
                            cmd.Parameters.AddWithValue("b_id", b_id1);
                            cmd.Parameters.AddWithValue("b_id", b_id2);
                            cmd.Parameters.AddWithValue("r_id", r_id);
                            cmd.Parameters.AddWithValue("bookin", datein);
                            cmd.Parameters.AddWithValue("bookout", dateout);
                            cmd.Parameters.AddWithValue("payment", paytwin);

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

        private void Update_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(s))
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    string sql = "SELECT * FROM bookings";
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

        private void Remove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove this booking?", "", MessageBoxButtons.OK) == DialogResult.OK)
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(s))
                {
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        int ch_id = Convert.ToInt32(Cheque.Text);
                        string sql = $"DELETE FROM bookings WHERE cheque_id = {ch_id}";
                        Cheque.Clear();
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


        private void Clear_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            LoadData();
        }

        private void Search_Click(object sender, EventArgs e)
        {

        }
    }
}
