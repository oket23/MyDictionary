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
    private string _dictionaryTypePath;
    private string _path;
    public AdminTools(User user, Logger logger)
    {
        _user = user;
        _logger = logger;
        _dictionary = new Dictionary();
        _dataStorage = new FileWordsDataStorage();
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
        _dictionary.words = _dataStorage.Get(_path);
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
        _dictionary.ChangeWord(userWordTb.Text, userNewWordTb.Text, _path);
        mainRtb.Text = _dictionary.ShowAllWordsAndTrans();
    }

    private void addDictionaryBtn_Click(object sender, EventArgs e)
    {
        //додаваня нового словника
    }

    private void addNewWord_Click(object sender, EventArgs e)
    {
        //додавання нового слова
    }
    //зробити пароль через хеш
    //розібратися з загрузкою типів словника
}
