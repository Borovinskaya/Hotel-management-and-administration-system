using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace coursework
{
    public partial class S_main : Form
    {
        public void SetSID(string sid)
        {
            s_idtext.Text = sid;
        }
        public string SID
        {
            get { return s_idtext.Text; }
            set { s_idtext.Text = value; }
        }

        string s = "Host=localhost;Port=5432;Username=postgres;Password=YOURPASSWORD;Database=tabor"; // enter your host/password/etc.
        NpgsqlConnection conn;

        public void LoadData()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(s))
            {
                conn.Open();
                {
                    string e_login = s_idtext.Text;
                    string sql = $"SELECT * FROM orders WHERE e_id IN (SELECT e_id FROM employees WHERE login ='{e_login}');";
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

        public S_main()
        {
            InitializeComponent();
            conn = new NpgsqlConnection(s);
            conn.Open(); 
            LoadData();
        }

        public void S_main_Load(object sender, EventArgs e)
        {

        }

        private void Take_an_order_Click(object sender, EventArgs e)
        {
            string e_log = s_idtext.Text;
            int o_id = Convert.ToInt32(OrdtextBox.Text);

            using (NpgsqlConnection conn = new NpgsqlConnection(s))
            {
                conn.Open();

                if (conn.State == ConnectionState.Open)
                {
                    string sql = $"UPDATE orders SET status = 'In progress' where o_id = {o_id}; " +
                        $"UPDATE orders SET e_id= (SELECT e_id FROM employees WHERE login = '{e_log}') where o_id = 100;";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("s_id", e_log);
                        cmd.Parameters.AddWithValue("o_id", o_id); ;

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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Log_out_Click(object sender, EventArgs e)
        {
            E_login frm = new E_login();
            frm.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        public void s_idText_TextChanged(object sender, EventArgs e)
        {
            s_idtext.ReadOnly = true;
        }

        private void CompletedRadio_CheckedChanged(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(s))
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    string sql = "SELECT * FROM orders WHERE status = 'completed'";
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
                    string sql = "SELECT * FROM orders WHERE status = 'in progress'";
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
            VacantRadio.Checked = false;
        }

        private void myOrders_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(s))
            {
                conn.Open();
                {
                    string e_login = s_idtext.Text;
                    string sql = $"SELECT * FROM orders WHERE e_id IN (SELECT e_id FROM employees WHERE login ='{e_login}') OR status = 'vacant'";
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void VacantRadio_CheckedChanged(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(s))
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    string sql = "SELECT * FROM orders WHERE status = 'vacant'";
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

        private void markCompl_Click(object sender, EventArgs e)
        {
            int o_id = Convert.ToInt32(OrdtextBox.Text);

            using (NpgsqlConnection conn = new NpgsqlConnection(s))
            {
                conn.Open();

                if (conn.State == ConnectionState.Open)
                {
                    string sql = $"UPDATE orders SET status = 'completed' where o_id = {o_id}; ";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("o_id", o_id); ;

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