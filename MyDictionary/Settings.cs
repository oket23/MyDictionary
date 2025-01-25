namespace MyDictionary
{
    public partial class Settings : Form
    {
        private bool _isAdmin = false;
        public Settings(bool admin)
        {
            _isAdmin = admin;
            InitializeComponent();
        }
        private void viewDictionariesLb_Click(object sender, EventArgs e)
        {
            var viewDictionary = new Menu(_isAdmin);
            Hide();
            viewDictionary.Show();
        }
        private void exitLb_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void adminToolsLb_Click(object sender, EventArgs e)
        {
            var adminTools = new AdminTools();
            Hide();
            adminTools.Show();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            if (!_isAdmin)
            {
                adminToolsLb.Visible = false;
            }
        }

        private void signOutLb_Click(object sender, EventArgs e)
        {
            var login = new Login();
            Hide();
            login.Show();
        }
    }
}
