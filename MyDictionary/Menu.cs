using Serilog;
using Serilog.Core;

namespace MyDictionary
{
    public partial class Menu : Form
    {
        private bool _isAdmin = false;
        private User _user;
        private string _path;
        private Dictionary _dictionary;
        private readonly Logger _logger;
        private string _dictionaryTypePath;
        public Menu(bool admin, User user)
        {
            _logger = new LoggerConfiguration()
               .WriteTo.File("logs.txt", outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level:u3}]: {Message:lj} {NewLine}{Exception}")
               .MinimumLevel.Debug()
               .CreateLogger();
            _isAdmin = admin;
            _user = user;
            _dictionary = new Dictionary();
            _dictionaryTypePath = "dictionaryType.txt";
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
            var settings = new Settings(_isAdmin, _user);
            Hide();
            settings.Show();
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            if (!_isAdmin)
            {
                adminToolsLb.Visible = false;
            }

            var types = _dictionary.GetTypesFromFile(_dictionaryTypePath);
            dictionaryTypeB.Items.Clear();
            foreach (var item in types)
            {
                dictionaryTypeB.Items.Add(item);
            }
        }
        private void adminToolsLb_Click(object sender, EventArgs e)
        {
            var adminTools = new AdminTools(_user);
            Hide();
            adminTools.Show();
        }
        private void allWordBtn_Click(object sender, EventArgs e)
        {
            mainRtb.Clear();
            if (!string.IsNullOrEmpty(_dictionary.ShowAllWordsAndTrans()))
            {
                mainRtb.Text = _dictionary.ShowAllWordsAndTrans();
            }
            else
            {
                MessageBox.Show("Please select a dictionary");
            }

        }
        private void showAllInfoBtn_Click(object sender, EventArgs e)
        {
            mainRtb.Clear();
            if (!string.IsNullOrEmpty(_dictionary.ShowAllInfo(userWordTb.Text)))
            {
                mainRtb.Text = _dictionary.ShowAllInfo(userWordTb.Text);
            }
            else
            {
                MessageBox.Show("Please select a dictionary.");
            }
        }
        private void seachBtn_Click(object sender, EventArgs e)
        {
            mainRtb.Clear();
            if (!string.IsNullOrEmpty(_dictionary.SeachWords(userWordTb.Text)))
            {
                mainRtb.Text = _dictionary.SeachWords(userWordTb.Text);
            }
            else
            {
                MessageBox.Show("Please select a dictionary.");
            }
        }
        private void dictionaryTypeB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = dictionaryTypeB.SelectedItem.ToString();
            _dictionary.Type = selectedItem;
            _path = $"{selectedItem}.json";
            _dictionary.words = _dictionary.GetWorldsFromFile(_path);
        }
        private void exportBtn_Click(object sender, EventArgs e)
        {
            _dictionary.ExportDictionary();
        }
        private void exportSimpleBtn_Click(object sender, EventArgs e)
        {
            _dictionary.ExportSimpleWord(userWordTb.Text);
        }
    }
}
