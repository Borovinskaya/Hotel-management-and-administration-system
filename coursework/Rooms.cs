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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace coursework
{
    public partial class Rooms : Form
    {
        string s = "Host=localhost;Port=5432;Username=postgres;Password=YOURPASSWORD;Database=tabor"; // enter your host/password/etc.
        NpgsqlConnection conn;
        public Rooms()
        {
            InitializeComponent();
            conn = new NpgsqlConnection(s);
            conn.Open();
            LoadData();
        }

        private void Rooms_Load(object sender, EventArgs e)
        {

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
                    string sql = "SELECT * FROM rooms";
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

        private void VButton_CheckedChanged(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(s))
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    string sql = "SELECT * FROM rooms WHERE status = 0";
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

        private void OButton_CheckedChanged_1(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(s))
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    string sql = "SELECT * FROM rooms WHERE status = 1";
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

        private void snglCheck_CheckedChanged(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(s))
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    string sql = "SELECT * FROM rooms WHERE type = 'sngl'";
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

        private void twinCheck_CheckedChanged(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(s))
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    string sql = "SELECT * FROM rooms WHERE type = 'twin'";
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
            VButton.Checked = false;
            OButton.Checked = false;
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }
            LoadData();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Search_Click(object sender, EventArgs e)
        {
            List<string> selectedTypes = new List<string>();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    selectedTypes.Add(checkedListBox1.Items[i] as string);
                }
            }

            string query = "SELECT * FROM rooms";
            if (selectedTypes.Count > 0)
            {
                query += " WHERE type IN (";
                query += "'" + string.Join("', '", selectedTypes) + "'";
                query += ")";
            }

            NpgsqlCommand command = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}

