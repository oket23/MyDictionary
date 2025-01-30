using MyDictionary.Class;
using Serilog.Core;

namespace MyDictionary.Forms
{
    public partial class NewWord : Form
    {
        private Logger _logger;
        private Dictionary _dictionary;
        private string _path;
        public NewWord(Logger logger,Dictionary dictionary,string path)
        {
            _path = path;
            _dictionary = dictionary;
            _logger = logger;
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addWordBtn_Click(object sender, EventArgs e)
        {
            _dictionary.AddWord(userOriginalWordTb.Text,userTypeWordTb.Text,userSynonymTb.Text,userAboutWordTb.Text,userTransTb.Text,_path);
            _logger.Information("User successfully added word!");
        }

    }
}
