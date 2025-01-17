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
    public partial class Register : Form
    {
        private Login _login;
        private bool _IsFirstPicture = false;
        public Register(Login login)
        {
            _login = login;
            InitializeComponent();
        }

        private void loginLb_Click(object sender, EventArgs e)
        {
            Hide();
            _login.Show();
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void passwordPicture_Click(object sender, EventArgs e)
        {
            string openPath = Path.Combine("Image", "openPassword.png");
            string closePath = Path.Combine("Image", "closePassword.png");

            if (_IsFirstPicture)
            {
                passwordPicture.Image = Image.FromFile(closePath);
                passwordTb.PasswordChar = '*';
                passwordAgainTb.PasswordChar = '*';
                _IsFirstPicture = false;
            }
            else
            {
                passwordPicture.Image = Image.FromFile(openPath);
                passwordTb.PasswordChar = '\0';
                passwordAgainTb.PasswordChar = '\0';
                _IsFirstPicture = true;
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon...");
        }
    }
}
