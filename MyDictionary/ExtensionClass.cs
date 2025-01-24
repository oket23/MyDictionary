using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MyDictionary
{
    public static class ExtensionClass
    {
        public static IEnumerable<T> GetUsersFromFile<T>(this IEnumerable<T> collection, string path)
        {
            List<T> users = new List<T>();
            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (var sr = new StreamReader(fs))
                {
                    string json;
                    while ((json = sr.ReadLine()) != null)
                    {
                        T userFormFile = JsonSerializer.Deserialize<T>(json);
                        users.Add(userFormFile);
                    }
                }
            }
            return users;
        }

        public static void SetUsersToFile(this User user,string path)
        {
            using (var fs = new FileStream("Users.json", FileMode.Append, FileAccess.Write))
            {
                using (var sw = new StreamWriter(fs))
                {
                    var json = JsonSerializer.Serialize(user);
                    sw.WriteLine(json);

                }
            }
        }
    }
}
