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
    public partial class ForgotPassword : Form
    {
        Login _login;
        public ForgotPassword(Login login)
        {
            _login = login;
            InitializeComponent();
        }

        private void backToLogginBtn_Click(object sender, EventArgs e)
        {
            Hide();
            _login.Show();
        }

        private void ForgotPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
