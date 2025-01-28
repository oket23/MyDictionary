using Serilog;
using Serilog.Core;

namespace MyDictionary
{
    public partial class AdminTools : Form
    {
        private User _user;
        private readonly Logger _logger;
        private Dictionary _dictionary;
        private string _dictionaryTypePath;
        private string _path;
        public AdminTools(User user)
        {
            _user = user;
            _logger = new LoggerConfiguration()
               .WriteTo.File("logs.txt", outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level:u3}]: {Message:lj} {NewLine}{Exception}")
               .MinimumLevel.Debug()
               .CreateLogger();
            _dictionary = new Dictionary();
            _dictionaryTypePath = "dictionaryType.txt";
            InitializeComponent();
        }
        private void AdminTools_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void viewDictionariesLb_Click(object sender, EventArgs e)
        {
            var menu = new Menu(true, _user);
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
        private void dictionaryTypeB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = dictionaryTypeB.SelectedItem.ToString();
            _dictionary.Type = selectedItem;
            _path = $"{selectedItem}.json";
            _dictionary.words = _dictionary.GetWorldsFromFile(_path);
        }
        private void AdminTools_Load(object sender, EventArgs e)
        {
            var types = _dictionary.GetTypesFromFile(_dictionaryTypePath);
            dictionaryTypeB.Items.Clear();
            foreach (var item in types)
            {
                dictionaryTypeB.Items.Add(item);
            }
        }
        private void deleteWordBtn_Click(object sender, EventArgs e)
        {
            _dictionary.DeleteWord(userWordTb.Text, _path);
            mainRtb.Text = _dictionary.ShowAllWordsAndTrans();
        }
        private void changeWordBtn_Click(object sender, EventArgs e)
        {
            _dictionary.ChangeWord(userWordTb.Text,userNewWordTb.Text,_path);
            mainRtb.Text = _dictionary.ShowAllWordsAndTrans();
        }
        private void deleteTransBtn_Click(object sender, EventArgs e)
        {
            _dictionary.DeleteTrans(userWordTb.Text, userTransTb.Text, _path);
            mainRtb.Text = _dictionary.ShowAllWordsAndTrans();
        }

    }
}
