using Microsoft.VisualBasic.ApplicationServices;
using Serilog;
using Serilog.Core;
using System.DirectoryServices;
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

            var types = GetTypesFromFile(_dictionaryTypePath);
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
        public void ShowAllWordls()
        {
            try
            {
                mainRtb.Clear();
                mainRtb.Text = string.Join("\n", _dictionary.worlds.Select(w => $"{w.Word} - {string.Join(", ", w.Translations)}"));
                if (string.IsNullOrEmpty(mainRtb.Text))
                {
                    mainRtb.Text = "Please select a dictionary.";
                }
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
                mainRtb.Clear();
                var word = userWordTb.Text.Trim();

                if (string.IsNullOrEmpty(word))
                {
                    mainRtb.Text = "Please enter a word to search.";
                    return;
                }

                var foundWords = _dictionary.worlds.Where(w => w.Word.Equals(word, StringComparison.OrdinalIgnoreCase))
                    .ToList();

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
                mainRtb.Clear();
                var word = userWordTb.Text.Trim();
                if (string.IsNullOrEmpty(word))
                {
                    mainRtb.Text = "Please enter a word to search.";
                    return;
                }

                var searchResults = _dictionary.SearchByWordPart(word);

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
            _dictionary.Type = selectedItem;
            _path = $"{selectedItem}.json";
            _dictionary.worlds = _dictionary.GetWorldsFromFile(_path);
        }
        private void exportBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (!_dictionary.worlds.Any())
            {
                MessageBox.Show("Please chooise dictionary!");
                return;
            }

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var userPath = Path.Combine(folderBrowserDialog.SelectedPath, "translation.txt");
                    using (var fs = new FileStream(userPath, FileMode.Create, FileAccess.Write))
                    {
                        using (var sw = new StreamWriter(fs))
                        {
                            sw.WriteLine(string.Join("\n", _dictionary.worlds.Select(w => $"{w.Word} - {string.Join(", ", w.Translations)}")));
                        }
                    }
                    MessageBox.Show("Dictionary copied successfully");
                    _logger.Information("Dictionary copied successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                    _logger.Error($"{ex} {ex.Message}");
                }
            }
        }
        private void exportSimpleBtn_Click(object sender, EventArgs e)
        {
            var word = userWordTb.Text.Trim();
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (string.IsNullOrEmpty(word))
            {
                MessageBox.Show("Enter valid word");
                return;
            }
            var wordToExtport = _dictionary.worlds.Where(u => u.Word.Equals(word, StringComparison.OrdinalIgnoreCase))
                        .ToList();
            if (wordToExtport.Any())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var userPath = Path.Combine(folderBrowserDialog.SelectedPath, "translation.txt");
                        using (var fs = new FileStream(userPath, FileMode.Create, FileAccess.Write))
                        {
                            using (var sw = new StreamWriter(fs))
                            {
                                sw.WriteLine(string.Join("\n", wordToExtport.Select(w => $"{w.Word} - {string.Join(", ", w.Translations)}")));
                            }
                        }
                        MessageBox.Show("Word copied successfully");
                        _logger.Information("Word copied successfully");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error");
                        _logger.Error($"{ex} {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("No such word found");
                _logger.Information("User entered the correct word");
            }
        }

        private List<string> GetTypesFromFile(string path)
        {
            List<string> types = new List<string>();
            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (var sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream)
                    {
                        types.Add(sr.ReadLine());
                    }
                }
            }
            return types;
        }

    }
}
