using MyDictionary.Class;
using MyDictionary.Forms;
using Serilog.Core;
using System.Text.Json;

namespace MyDictionary;

public class UserService
{
    public List<User> users;
    private readonly Logger _logger;
    private IDataStorage<User> _dataStorage;

    public UserService(Logger logger)
    {
        _dataStorage = new FileUserDataStorage();
        _logger = logger;
        users = new List<User>();
    }
    public bool IsAdmin(List<User> users, string login)
    {
        var user = users.FirstOrDefault(u => u.Login == login);
        if (user != null && login == "oket13")
        {
            return true;
        }
        return false;
    }
    public bool IsValidLoginAndPassword(string login, string password, List<User> users)
    {
        var user = users.FirstOrDefault(u => u.Login == login);
        if (user == null)
        {
            MessageBox.Show("Such a login does not exist.");
            _logger.Error("User enters incorrect login.");
            return false;
        }
        if (user.Password != password)
        {
            MessageBox.Show("Incorrect password.");
            _logger.Error("User enters incorrect password.");
            return false;
        }

        return true;
    }
    public bool IsvalidLogin(string login, List<User> users)
    {
        if (string.IsNullOrEmpty(login) || login.Length < 3)
        {
            MessageBox.Show("Enter correct login!");
            _logger.Error("User entered an incorrect login.");
            return false;
        }

        if (users.Any(u => u.Login == login))
        {
            MessageBox.Show("Such a login is already registered.");
            _logger.Error("Such a login is already registered.");
            return false;
        }

        _logger.Information("User entered a valid login.");
        return true;
    }
    public bool IsValidPassword(string password, string confirmPassword)
    {
        if (password.Length < 8)
        {
            MessageBox.Show("Password must be longer than 8 characters.");
            _logger.Error("Password must be longer than 8 characters.");
            return false;
        }

        if (password != confirmPassword)
        {
            MessageBox.Show("Passwords must match.");
            _logger.Error("Passwords must match.");
            return false;
        }

        _logger.Information("User entered a valid password.");
        return true;
    }
    public bool IsValidBDate(DateTime bDate)
    {
        var age = DateTime.Now.Year - bDate.Year;

        if (age < 3)
        {
            MessageBox.Show("You must be at least 3 years old to register.");
            _logger.Error("User is under 3.");
            return false;
        }
        if (age > 100)
        {
            MessageBox.Show("Enter valid date");
            _logger.Error("User enter incorrect date");
            return false;
        }

        _logger.Information("User's age is valid.");
        return true;
    }
    public void DeleteUser(User user, string path)
    {
        List<User> usersList = new List<User>();
        usersList = _dataStorage.Get(path);
        var newUsers = usersList.Where(u => u.Login != user.Login).ToList();

        using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write))
        {
            using (var sw = new StreamWriter(fs))
            {
                foreach (var item in newUsers)
                {
                    var json = JsonSerializer.Serialize(item);
                    sw.WriteLine(json);
                }
            }
        }
    }

}
