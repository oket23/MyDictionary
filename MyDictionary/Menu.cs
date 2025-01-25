namespace MyDictionary
{
    public partial class Menu : Form
    {
        private bool _isAdmin = false;
        public Menu(bool admin)
        {
            _isAdmin = admin;
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
            var settings = new Settings(_isAdmin);
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
            var adminTools = new AdminTools();
            Hide();
            adminTools.Show();
        }
    }
}
