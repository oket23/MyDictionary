﻿namespace MyDictionary
{
    public partial class Menu : Form
    {
        private Login _login;
        public Menu(Login login)
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
