using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void asEmployee_Click(object sender, EventArgs e)
        {
            var E_login = new E_login();
            E_login.Show();
            this.Hide();
        }

        private void asClient_Click(object sender, EventArgs e)
        {
            var C_login = new C_login();
            C_login.Show();
            this.Hide();

        }
    }
}
