using MyDictionary.Forms;
using System.Text.Json;

namespace MyDictionary.Class;

public class FileUserDataStorage : IDataStorage<User>
{

    public List<User> Get(string path)
    {
        List<User> users = new List<User>();

        using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            using (var sr = new StreamReader(fs))
            {
                var json = sr.ReadToEnd();
                users = JsonSerializer.Deserialize<List<User>>(json);
            }
        }

        return users;
    }

    public void Save(List<User> users, string path)
    {
        using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write))
        {
            using (var sw = new StreamWriter(fs))
            {
                var options = new JsonSerializerOptions
                {
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                    WriteIndented = true
                };
                var json = JsonSerializer.Serialize(users, options);
                sw.WriteLine(json);
            }
        }
    }

}
