using Serilog;
using Serilog.Core;
using System.Text.Json;

namespace MyDictionary
{
    public partial class Menu : Form
    {
        private bool _isAdmin = false;
        private User _user;
        private string _path;
        private Dictionary _dictionary;
        private readonly Logger _logger;
        public Menu(bool admin, User user)
        {
            _logger = new LoggerConfiguration()
               .WriteTo.File("logs.txt", outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level:u3}]: {Message:lj} {NewLine}{Exception}")
               .MinimumLevel.Debug()
               .CreateLogger();
            _isAdmin = admin;
            _user = user;
            _dictionary = new Dictionary();
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
        }
        private void adminToolsLb_Click(object sender, EventArgs e)
        {
            var adminTools = new AdminTools(_user);
            Hide();
            adminTools.Show();
        }
        public void ShowAllWordls()
        {
            try
            {
                _dictionary.worlds = _dictionary.GetWorldsFromFile(_path);
                mainRtb.Clear();
                mainRtb.Text = string.Join("\n", _dictionary.worlds.Select(w => $"{w.Word} - {string.Join(", ", w.Translations)}"));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a dictionary.");
                _logger.Error($"{ex} {ex.Message}");
            }

        }
        private void allWordBtn_Click(object sender, EventArgs e)
        {
            ShowAllWordls();
        }
        private void showAllInfoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _dictionary.worlds = _dictionary.GetWorldsFromFile(_path);
                mainRtb.Clear();
                var word = userWordTb.Text;
                var foundWords = _dictionary.worlds.Where(w => w.Word.Equals(word, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                if (string.IsNullOrEmpty(word))
                {
                    mainRtb.Text = "Please enter a word to search.";
                    return;
                }

                if (foundWords.Any())
                {
                    mainRtb.Text = string.Join("\n", foundWords.Select(w => $"Word: {w.Word}\nAbout: {w.AboutWord}\nType: {w.TypeWord}\nSynonym: {w.Synonym}\nTranslation: {string.Join(", ", w.Translations)}"));
                }
                else
                {
                    mainRtb.Text = "No word found.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a dictionary.");
                _logger.Error($"{ex} {ex.Message}");
            }

        }
        private void seachBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _dictionary.worlds = _dictionary.GetWorldsFromFile(_path);
                mainRtb.Clear();
                var word = userWordTb.Text.Trim();
                var searchResults = _dictionary.SearchByWordPart(word);

                if (string.IsNullOrEmpty(word))
                {
                    mainRtb.Text = "Please enter a word to search.";
                    return;
                }

                if (searchResults.Any())
                {
                    mainRtb.Text = string.Join("\n", searchResults.Select(w => $"{w.Word} - {string.Join(", ", w.Translations)}"));
                }
                else
                {
                    mainRtb.Text = "No results found.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a dictionary.");
                _logger.Error($"{ex} {ex.Message}");
            }

        }

        private void dictionaryTypeB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = dictionaryTypeB.SelectedItem.ToString();
            _path = $"{selectedItem}.json";
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            //експортувати словник у файл з вибором куди
            //зробити ще одну кнопку для екпорту імено слова і перекладу слова в файл з вибором куди
        }
    }
}
