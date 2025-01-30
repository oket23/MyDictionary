using MyDictionary.Forms;

namespace MyDictionary.Class;

internal class TypeDataStorage : IDataStorage<string>
{
    public List<string> Get(string path)
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

    public void Save(List<string> types, string path)
    {
        using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write))
        {
            using (var sw = new StreamWriter(fs))
            {
                foreach (var type in types)
                {
                    sw.WriteLine(type);
                }
            }
        }
    }

}
