using System;
using System.Collections.Generic;
namespace MyDictionary
{
    public partial class AdminTools : Form
    {
        private User _user;
        public AdminTools(User user)
        {
            _user = user;
            InitializeComponent();
        }

        private void AdminTools_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void viewDictionariesLb_Click(object sender, EventArgs e)
        {
            var menu = new Menu(true,_user);
            Hide();
            menu.Show();
        }

        private void settingsLb_Click(object sender, EventArgs e)
        {
            var settings = new Settings(true, _user);
            Hide();
            settings.Show();
        }

        private void exitLb_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
