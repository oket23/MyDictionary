using MyDictionary.Forms;
using System.Text.Json;

namespace MyDictionary.Class;

internal class FileWordsDataStorage : IDataStorage<Word>
{
    public List<Word> Get(string path)
    {
        List<Word> worlds = new List<Word>();

        using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            using (var sr = new StreamReader(fs))
            {
                var json = sr.ReadToEnd();
                worlds = JsonSerializer.Deserialize<List<Word>>(json);
            }
        }

        return worlds;
    }

    public void Save(List<Word> words, string path)
    {
        using (var fs = new FileStream(path, FileMode.Open, FileAccess.Write))
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
