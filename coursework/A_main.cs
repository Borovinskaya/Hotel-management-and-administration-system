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
    public partial class A_main : Form
    {
        public A_main()
        {
            InitializeComponent();
            string s = "Host=localhost;Port=5432;Username=postgres;Password=YOURPASSWORD;Database=minimarket"; // enter your host/password/etc.
            NpgsqlConnection conn;
        }


        private void Log_out_Click(object sender, EventArgs e)
        {
            var E_login = new E_login();
            E_login.Show();
            this.Hide();
            if (Application.OpenForms["Rooms"] != null)
            {
                Form roomsForm = Application.OpenForms["Rooms"];
                roomsForm.Hide();
            }
            if (Application.OpenForms["Clients"] != null)
            {
                Form clientsForm = Application.OpenForms["Clients"];
                clientsForm.Hide();
            }
            if (Application.OpenForms["CreateABook"] != null)
            {
                Form bookingForm = Application.OpenForms["CreateABook"];
                bookingForm.Hide();
            }
            if (Application.OpenForms["Customers"] != null)
            {
                Form customersForm = Application.OpenForms["Customers"];
                customersForm.Hide();
            }
        }

        private void Arooms_Click(object sender, EventArgs e)
        {
            var Rooms = new Rooms();
            Rooms.Show();
        }

        private void Aclients_Click(object sender, EventArgs e)
        {
            var Clients = new Clients();
            Clients.Show();
        }

        private void Abookings_Click(object sender, EventArgs e)
        {
        var Booking = new CreateABook();
            Booking.Show();
        }

        private void Acustomers_Click(object sender, EventArgs e)
        {
            var Customers = new Customers();
            Customers.Show();
        }

        private void A_main_Load(object sender, EventArgs e)
        {

        }
    }
}
