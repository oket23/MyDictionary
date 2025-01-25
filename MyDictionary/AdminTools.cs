using System;
using System.Collections.Generic;
namespace MyDictionary
{
    public partial class AdminTools : Form
    {
        public AdminTools()
        {
            InitializeComponent();
        }

        private void AdminTools_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void viewDictionariesLb_Click(object sender, EventArgs e)
        {
            var menu = new Menu(true);
            Hide();
            menu.Show();
        }

        private void settingsLb_Click(object sender, EventArgs e)
        {
            var settings = new Settings(true);
            Hide();
            settings.Show();
        }

        private void exitLb_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
