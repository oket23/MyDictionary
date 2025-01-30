using MyDictionary.Class;
using MyDictionary.Forms;
using Serilog.Core;

namespace MyDictionary;

public partial class AdminTools : Form
{
    private User _user;
    private readonly Logger _logger;
    private Dictionary _dictionary;
    private IDataStorage<Word> _dataStorage;
    private IDataStorage<string> _typeDataStorage;
    private string _dictionaryTypePath;
    private string _path;
    public AdminTools(User user, Logger logger)
    {
        _user = user;
        _logger = logger;
        _dictionary = new Dictionary();
        _dataStorage = new FileWordsDataStorage();
        _typeDataStorage = new TypeDataStorage();
        _dictionaryTypePath = "dictionaryType.txt";
        InitializeComponent();
    }
    private void AdminTools_FormClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }
    private void viewDictionariesLb_Click(object sender, EventArgs e)
    {
        var menu = new Menu(true, _user, _logger);
        Hide();
        menu.Show();
    }
    private void settingsLb_Click(object sender, EventArgs e)
    {
        var settings = new Settings(true, _user, _logger);
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
        if (dictionaryTypeB.SelectedIndex != -1)
        {
            
            mainRtb.Text = _dictionary.ShowAllWordsAndTrans();
            if (string.IsNullOrEmpty(mainRtb.Text))
            {
                mainRtb.Text = "No word found in the dictionary";
            }
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
        _dictionary.words = _dataStorage.Get(_path);
    }
    private void AdminTools_Load(object sender, EventArgs e)
    {
        var types = _typeDataStorage.Get(_dictionaryTypePath);
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
        _dictionary.ChangeWord(userWordTb.Text, userNewWordTb.Text, _path);
        mainRtb.Text = _dictionary.ShowAllWordsAndTrans();
    }
    private void deleteTransBtn_Click(object sender, EventArgs e)
    {
        _dictionary.DeleteTrans(userWordTb.Text, userTransTb.Text, _path);
        mainRtb.Text = _dictionary.ShowAllWordsAndTrans();
    }
    private void changeTransBtn_Click(object sender, EventArgs e)
    {
        _dictionary.ChangeTrans(userWordTb.Text, userTransTb.Text,userNewTransTb.Text, _path);
        mainRtb.Text = _dictionary.ShowAllWordsAndTrans();
    }
    private void addDictionaryBtn_Click(object sender, EventArgs e)
    {
        var type = userDictionatyTypeTb.Text;

        if (!string.IsNullOrEmpty(type))
        {
            try
            {
                _dictionary.CreateDictionary(type, _dictionaryTypePath);
                List<string> types = new List<string>();

                types = _typeDataStorage.Get(_dictionaryTypePath);
                dictionaryTypeB.Items.Clear();
                foreach (var item in types)
                {
                    dictionaryTypeB.Items.Add(item);
                }

                MessageBox.Show("New dictionary has been successfully created.\nIf you want, create the first word in it");
                _logger.Information("New dictionary has been successfully created!");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"{ex.Message}");
            }
            
        }
        else
        {
            MessageBox.Show("Enter dictionary type!");
            _logger.Error("User enters incorrect type!");
        }
    }
    private void addNewWord_Click(object sender, EventArgs e)
    {
        if (dictionaryTypeB.SelectedIndex != -1)
        {
            var newWord = new NewWord(_logger, _dictionary, _path);

            newWord.ShowDialog();

            mainRtb.Clear();
            mainRtb.Text = _dictionary.ShowAllWordsAndTrans();
        }
        else
        {
            MessageBox.Show("Please select a dictionary");
        }
    }

}
