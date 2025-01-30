using Microsoft.VisualBasic.Devices;
using MyDictionary.Class;
using MyDictionary.Forms;
using System.Text.Json;

namespace MyDictionary;

public class Dictionary
{
    public List<Word> words { get; set; }
    public string Type { get; set; }
    private IDataStorage<Word> _dataStorage;
    private IDataStorage<string> _typeDataStorage;
    public Dictionary()
    {
        words = new List<Word>();
        _dataStorage = new FileWordsDataStorage();
        _typeDataStorage = new TypeDataStorage();
    }

    public string ShowAllWordsAndTrans()
    {
        try
        {
            return string.Join("\n", words.Select(w => $"{w.WordOriginal} - {string.Join(", ", w.Translations)}"));
        }
        catch (Exception ex)
        {
            return null;
        }

    }
    public string ShowAllInfo(string word)
    {
        try
        {
            word = word.Trim();

            if (string.IsNullOrEmpty(word))
            {
                return "Please enter a word to search.";
            }

            var foundWords = words.Where(w => w.WordOriginal.Equals(word, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (foundWords.Any())
            {
                return string.Join("\n", foundWords.Select(w => $"Word: {w.WordOriginal}\nAbout: {w.AboutWord}\nType: {w.TypeWord}\nSynonym: {w.Synonym}\nTranslation: {string.Join(", ", w.Translations)}"));
            }
            else
            {
                return "No word found.";
            }
        }
        catch (Exception ex)
        {
            return null;
        }
    }
    public string SeachWords(string word)
    {
        try
        {
            word = word.Trim();
            if (string.IsNullOrEmpty(word))
            {
                return "Please enter a word to search.";
            }

            var searchResults = words.Where(w => w.WordOriginal.Contains(word, StringComparison.OrdinalIgnoreCase))
                                 .ToList();

            if (searchResults.Any())
            {
                return string.Join("\n", searchResults.Select(w => $"{w.WordOriginal} - {string.Join(", ", w.Translations)}"));
            }
            else
            {
                return "No results found.";
            }
        }
        catch (Exception ex)
        {
            return null;
        }
    }
    public void ExportDictionary()
    {
        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

        if (!words.Any())
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
                        sw.WriteLine(string.Join("\n", words.Select(w => $"{w.WordOriginal} - {string.Join(", ", w.Translations)}")));
                    }
                }
                MessageBox.Show("Dictionary copied successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }
    }
    public void ExportSimpleWord(string word)
    {
        word = word.Trim();
        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        if (string.IsNullOrEmpty(word))
        {
            MessageBox.Show("Enter valid word");
            return;
        }

        var wordToExtport = words.Where(u => u.WordOriginal.Equals(word, StringComparison.OrdinalIgnoreCase))
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
                            sw.WriteLine(string.Join("\n", wordToExtport.Select(w => $"{w.WordOriginal} - {string.Join(", ", w.Translations)}")));
                        }
                    }
                    MessageBox.Show("Word copied successfully");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                }
            }
        }
        else
        {
            MessageBox.Show("No such word found");
        }
    }
    public void DeleteWord(string word, string path)
    {
        word = word.Trim();
        if (string.IsNullOrEmpty(word))
        {
            MessageBox.Show("Please enter a word to search.");
            return;
        }

        var wordsCount = words.Count;
        words = words.Where(u => !u.WordOriginal.Equals(word, StringComparison.OrdinalIgnoreCase)).ToList();

        if (words.Count < wordsCount)
        {
            _dataStorage.Save(words,path);
            MessageBox.Show("Word change successfully");
        }
        else
        {
            MessageBox.Show("No word found.");
        }
    }
    public void ChangeWord(string oldWord, string newWord, string path)
    {
        oldWord = oldWord.Trim();
        newWord = newWord.Trim();
        if (string.IsNullOrEmpty(oldWord))
        {
            MessageBox.Show("Please enter the word to replace.");
            return;
        }
        if (string.IsNullOrEmpty(newWord))
        {
            MessageBox.Show("Please enter new word.");
            return;
        }

        var index = words.FindIndex(u => u.WordOriginal.Equals(oldWord, StringComparison.OrdinalIgnoreCase));

        if (index != -1)
        {
            words[index].WordOriginal = newWord;
            _dataStorage.Save(words, path);
            MessageBox.Show($"Word '{oldWord}' was successfully replaced with '{newWord}'.");
        }
        else
        {
            MessageBox.Show($"Word '{oldWord}' not found in the dictionary.");
        }
    }
    public void DeleteTrans(string word, string trans, string path)
    {
        word = word.Trim();
        trans = trans.Trim();
        if (string.IsNullOrEmpty(word))
        {
            MessageBox.Show("Please enter a word to search.");
            return;
        }
        if (string.IsNullOrEmpty(trans))
        {
            MessageBox.Show("Please enter a translation to delete.");
            return;
        }

        var wordInDictionary = words.FirstOrDefault(u => u.WordOriginal.Equals(word, StringComparison.OrdinalIgnoreCase));

        if (wordInDictionary == null)
        {
            MessageBox.Show($"Word '{word}' not found in the dictionary.");
            return;
        }

        var translationIndex = wordInDictionary.Translations.FindIndex(u => u.Equals(trans, StringComparison.OrdinalIgnoreCase));

        if (translationIndex >= 0)
        {
            if (wordInDictionary.Translations.Count > 1)
            {
                wordInDictionary.Translations.RemoveAt(translationIndex);
                _dataStorage.Save(words, path);

                MessageBox.Show($"Translation '{trans}' deleted successfully");
            }
            else
            {
                MessageBox.Show($"Cannot delete the only translation for word '{word}'.");
                return;
            }
        }
        else
        {
            MessageBox.Show($"Translation not found for word");
            return;
        }
    }
    public void ChangeTrans(string word,string trans,string newTrans,string path)
    {
        word = word.Trim();
        trans = trans.Trim();
        newTrans = newTrans.Trim();

        if (string.IsNullOrEmpty(word))
        {
            MessageBox.Show("Please enter the word.");
            return;
        }
        if (string.IsNullOrEmpty(trans))
        {
            MessageBox.Show("Please enter translation.");
            return;
        }
        if (string.IsNullOrEmpty(newTrans))
        {
            MessageBox.Show("Please enter new translation.");
            return;
        }

        var wordInDictionary = words.FirstOrDefault(u => u.WordOriginal.Equals(word, StringComparison.OrdinalIgnoreCase));

        if (wordInDictionary != null)
        {
            var transIndex = wordInDictionary.Translations.FindIndex(u => u.Equals(trans, StringComparison.OrdinalIgnoreCase));
            if(transIndex != -1)
            {
                wordInDictionary.Translations[transIndex] = newTrans;
                _dataStorage.Save(words, path);
                MessageBox.Show($"Translation was successfully replaced with '{newTrans}'.");
            }
            else
            {
                MessageBox.Show($"Translation not found in the dictionary.");
            }
        }
        else
        {
            MessageBox.Show($"Word not found in the dictionary.");
        }
    }
    public void AddWord(string word,string type,string symonym,string about,string trans,string path)
    {
        var originalWord = word.Trim();
        var typeWord = type.Trim();
        var synonym = symonym.Trim();
        var aboutWord = about.Trim();
        var translations = trans.Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

        if (string.IsNullOrEmpty(originalWord))
        {
            MessageBox.Show("Please enter word.");
            return;
        }
        if (words.Any(u => u.WordOriginal.Equals(originalWord, StringComparison.OrdinalIgnoreCase)))
        {
            MessageBox.Show("Such a word is already in the dictionary.");
            return;
        }
        if (string.IsNullOrEmpty(typeWord))
        {
            MessageBox.Show("Please enter the word type.");
            return;
        }
        if (string.IsNullOrEmpty(synonym))
        {
            MessageBox.Show("Please enter the word synonym.");
            return;
        }
        if (string.IsNullOrEmpty(aboutWord))
        {
            MessageBox.Show("Please enter about word.");
            return;
        }
        if (translations.Length == 0)
        {
            MessageBox.Show("Please add at least one translation.");
            return;
        }

        var newWord = new Word()
        {
            WordOriginal = originalWord,
            TypeWord = typeWord,
            Synonym = synonym,
            AboutWord = aboutWord,
        };
        newWord.Translations = translations.ToList();

        words.Add(newWord);
        _dataStorage.Save(words, path);

        MessageBox.Show("Word successfully added");   
    }

    public void CreateDictionary(string type,string path)
    {
        List<string> types = new List<string>();
        types = _typeDataStorage.Get(path);
        if (types.Contains(type))
        {
            MessageBox.Show($"Dictionary '{type}' already exists.");
            throw new ArgumentException();
        }
        types.Add(type);
        _typeDataStorage.Save(types, path);

        List<Word> tempWord = new List<Word>();
        using (var fs = new FileStream($"{type}.json",FileMode.Create,FileAccess.Write))
        {
            var options = new JsonSerializerOptions
            {
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                WriteIndented = true
            };
            using (var sw = new StreamWriter(fs))
            {
                var json = JsonSerializer.Serialize(words, options);
                sw.WriteLine(json);
            }
        }
    }
}
