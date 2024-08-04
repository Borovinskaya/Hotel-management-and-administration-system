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

namespace coursework
{
    public partial class C_main : Form
    {
        string s = "Host=localhost;Port=5432;Username=postgres;Password=YOURPASSWORD;Database=tabor"; // enter your host/password/etc.
        NpgsqlConnection conn;
        public C_main()
        {
            InitializeComponent();
            conn = new NpgsqlConnection(s);
            conn.Open();
        }

        public void SetCID(string cid)
        {
            c_login.Text = cid;
        }
        public string SID
        {
            get { return c_login.Text; }
            set { c_login.Text = value; }
        }

        private void C_main_Load(object sender, EventArgs e)
        { 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            C_Orders c_Orders = new C_Orders();
            c_Orders.SIdText = c_login.Text;
            c_Orders.Show();
        }

        private void LogOutB_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["C_Orders"] != null)
            {
                Form ordersForm = Application.OpenForms["C_Orders"];
                ordersForm.Hide();
            }
            C_login c_Login = new C_login();
            c_Login.Show();
            this.Hide();
        }

        private void CompletedRadio_CheckedChanged(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(s))
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    int c_log = Convert.ToInt32(c_login.Text);
                    string sql = $"SELECT * FROM orders WHERE status = 'completed' AND c_id = {c_log}";
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

        private void InPRadio_CheckedChanged(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(s))
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    int c_log = Convert.ToInt32(c_login.Text);
                    string sql = $"SELECT * FROM orders WHERE status = 'in progress' AND c_id = {c_log}";
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
            InPRadio.Checked = false;
            CompletedRadio.Checked = false;
            using (NpgsqlConnection conn = new NpgsqlConnection(s))
            {
                conn.Open();
                {
                    int c_log = Convert.ToInt32(c_login.Text);
                    string sql = $"SELECT * FROM orders WHERE c_id= {c_log}";
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

        private void c_login_TextChanged(object sender, EventArgs e)
        {
            c_login.ReadOnly = true;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(s))
            {
                conn.Open();
                {
                    int c_log = Convert.ToInt32(c_login.Text);
                    string sql = $"SELECT * FROM orders WHERE c_id= {c_log}";
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
