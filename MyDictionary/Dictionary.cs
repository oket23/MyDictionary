using System.Text.Json;

namespace MyDictionary
{
    public class Dictionary
    {
        public List<World> worlds { get; set; }
        public string Type { get; set; }

        public Dictionary()
        {
            worlds = new List<World>();
        }
        public List<World> GetWorldsFromFile(string path)
        {
            List<World> worlds = new List<World>();
            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (var sr = new StreamReader(fs))
                {
                    string json;
                    while ((json = sr.ReadLine()) != null)
                    {
                        World wordlsFormFile = JsonSerializer.Deserialize<World>(json);
                        worlds.Add(wordlsFormFile);
                    }
                }
            }
            return worlds;
        }
        public List<World> SearchByWordPart(string searchTerm)
        {
            return worlds.Where(w => w.Word.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                                     .ToList();
        }

    }
}
