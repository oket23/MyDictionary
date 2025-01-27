namespace MyDictionary
{
    public partial class Menu : Form
    {
        private bool _isAdmin = false;
        private User _user;
        public Menu(bool admin,User user)
        {
            _isAdmin = admin;
            _user = user;
            InitializeComponent();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void exitLb_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bye-Bye");
            Application.Exit();
        }
        private void settingsLb_Click(object sender, EventArgs e)
        {
            var settings = new Settings(_isAdmin,_user);
            Hide();
            settings.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (!_isAdmin)
            {
                adminToolsLb.Visible = false;
            }
        }

        private void adminToolsLb_Click(object sender, EventArgs e)
        {
            var adminTools = new AdminTools(_user);
            Hide();
            adminTools.Show();
        }
    }
}
