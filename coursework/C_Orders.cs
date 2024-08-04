using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace coursework
{
    public partial class C_Orders : Form
    {
        private int totalSum = 0;

        string s = "Host=localhost;Port=5432;Username=postgres;Password=YOURPASSWORD;Database=tabor";// enter your host/password/etc.
        NpgsqlConnection conn;

        public C_Orders()
        {
            InitializeComponent();
            totalPrice.Text = "0";
            conn = new NpgsqlConnection(s);
            conn.Open();

            foreach (Control control in this.Controls)
            {
                if (control == comboBox1)
                {
                    continue;
                }
                control.Enabled = false;
            }
        }

        public string SIdText
        {
            get { return c_idBox.Text; }
            set { c_idBox.Text = value; }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                foreach (Control control in this.Controls)
                {
                    control.Enabled = true;
                    OrdersBox.Enabled = false;
                }
                label1.Hide();
                totalPrice.Hide();
                using (NpgsqlConnection conn = new NpgsqlConnection(s))
                {
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        string sql = "SELECT title, price FROM services_catalogue";
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
            if (comboBox1.SelectedIndex == 1)
            {
                label1.Show();
                totalPrice.Show();
                foreach (Control control in this.Controls)
                {
                    control.Enabled = true;
                    CreateOrd.Enabled = true;
                }
                using (NpgsqlConnection conn = new NpgsqlConnection(s))
                {
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        string sql = "SELECT * FROM breakfast";
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

        private void C_Orders_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            O_IdBox.Clear();
            Random rnd = new Random();
            int getID = rnd.Next(10, 100);
            O_IdBox.Text += Convert.ToString(getID);
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var selectedRow = dataGridView1.SelectedRows[0];

                    string itemName = selectedRow.Cells[0].Value.ToString();

                    if (int.TryParse(selectedRow.Cells[1].Value.ToString(), out int itemPrice))
                    {
                        OrdersBox.Text += (OrdersBox.Text.Length > 0 ? ", " : "") + itemName;

                        totalSum += itemPrice;
                        totalPrice.Text = totalSum.ToString();
                    }
                }
            }
            if (comboBox1.SelectedIndex == 0)
            {
                OrdersBox.Clear();
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var selectedRow = dataGridView1.SelectedRows[0];

                    string itemName = selectedRow.Cells[0].Value.ToString();
                    OrdersBox.Text += itemName;
                }
                }
        }

        private void CreateOrd_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                if (O_IdBox.Text == "")
                {
                    MessageBox.Show("please create Order ID");
                }
                label1.Hide();
                totalPrice.Hide();
                string s_title = dataGridView1.CurrentCell.Value.ToString();
                int c_id = Convert.ToInt32(c_idBox.Text);
                int o_id = Convert.ToInt32(O_IdBox.Text);

                using (NpgsqlConnection conn = new NpgsqlConnection(s))
                {
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        string sql = $"INSERT INTO orders (o_id, c_id, status, title) values({o_id}, {c_id}, 'in progress', '{OrdersBox.Text}');" +
                            $" UPDATE orders SET price = sc.price,    s_id = sc.s_id FROM services_catalogue sc WHERE orders.o_id = {o_id}   AND sc.title = '{OrdersBox.Text}';";
                        using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("o_id", o_id);
                            cmd.Parameters.AddWithValue("c_id", c_id);
                            cmd.Parameters.AddWithValue("title", s_title);

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
                if (O_IdBox.Text == "")
                {
                    MessageBox.Show("please create Order ID");
                }
                int c_id = Convert.ToInt32(c_idBox.Text);
                int o_id = Convert.ToInt32(O_IdBox.Text);
                using (NpgsqlConnection conn = new NpgsqlConnection(s))
                {
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        string sql = $"insert into orders (o_id, c_id, status, title, price) values ({o_id}, {c_id}, 'in progress', '{OrdersBox.Text}', {Convert.ToInt32(totalPrice.Text)})";
                        using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("o_id", o_id);
                            cmd.Parameters.AddWithValue("c_id", c_id);

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
        private void buttonBreakf_Click(object sender, EventArgs e)
        {
            
        }

        public void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        public void totalPrice_TextChanged(object sender, EventArgs e)
        {
        }

        private void ClearCart_Click(object sender, EventArgs e)
        {
            OrdersBox.Clear();
            totalPrice.Clear();
            totalSum = 0;
        }
    }
}