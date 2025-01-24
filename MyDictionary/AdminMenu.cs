using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDictionary
{
    public partial class AdminMenu : Form
    {
        private Login _login;
        public AdminMenu(Login login)
        {
            _login = login;
            InitializeComponent();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void backToLoginLb_Click(object sender, EventArgs e)
        {
            Hide();
            _login.Show();
        }
    }
}
