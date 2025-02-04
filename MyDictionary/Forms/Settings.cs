using MyDictionary.Class;
using MyDictionary.Forms;
using Serilog.Core;

namespace MyDictionary;

public partial class Settings : Form
{
    private bool _isAdmin = false;
    private readonly Logger _logger;
    private UserService _userService;
    private IDataStorage<User> _dataStorage;
    private string _path = "users.json";
    private User _user;

    public Settings(bool admin, User user,Logger logger)
    {
        _isAdmin = admin;
        _user = user;
        _logger = logger;
        _userService = new UserService(_logger);
        _dataStorage = new FileUserDataStorage();
        InitializeComponent();
    }
    private void viewDictionariesLb_Click(object sender, EventArgs e)
    {
        var viewDictionary = new Menu(_isAdmin, _user,_logger);
        Hide();
        viewDictionary.Show();
    }
    private void exitLb_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
    private void Settings_FormClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }
    private void adminToolsLb_Click(object sender, EventArgs e)
    {
        var adminTools = new AdminTools(_user, _logger);
        Hide();
        adminTools.Show();
    }
    private void Settings_Load(object sender, EventArgs e)
    {
        if (!_isAdmin)
        {
            adminToolsLb.Visible = false;
        }
        loginLb.Text = $"Your login: {_user.Login}";
        bDayLb.Text = $"Your date of birth: {_user.BDate.ToShortDateString()}";
    }
    private void signOutLb_Click(object sender, EventArgs e)
    {
        var login = new Login(_logger);
        Hide();
        login.Show();
    }
    private void changeBdayBtn_Click(object sender, EventArgs e)
    {
        try
        {
            _userService.users = _dataStorage.Get(_path);
            var newBdate = DateTime.Parse(newBdayTb.Text);
            _user.BDate = newBdate;

            var updatedUsers = _userService.DeleteUser(_user, _path);
            updatedUsers.Add(_user);

            _dataStorage.Save(updatedUsers, _path);

            bDayLb.Text = $"Your date of birth: {_user.BDate.ToShortDateString()}";
            MessageBox.Show("You have successfully changed your date of birth");
            _logger.Information("User successfully changed their date of birth.");
        }
        catch (Exception ex)
        {
            MessageBox.Show("The date you entered is incorrect.");
            _logger.Error($"{ex} {ex.Message}");
        }
    }


    private void changeBtn_Click(object sender, EventArgs e)
    {
        _userService.users = _dataStorage.Get(_path);
        var oldPassword = oldPasswordTb.Text.Trim();
        var newPassword = newPasswordTb.Text.Trim();

        if (string.IsNullOrWhiteSpace(oldPassword) || string.IsNullOrWhiteSpace(newPassword))
        {
            MessageBox.Show("Passwords cannot be empty");
            _logger.Error("User tried to change password with empty fields");
            return;
        }

        if (!BCrypt.Net.BCrypt.Verify(oldPassword, _user.Password))
        {
            MessageBox.Show("You entered an incorrect password");
            _logger.Error("User entered incorrect password");
            return;
        }

        if (oldPassword == newPassword)
        {
            MessageBox.Show("The new password cannot be the same as the old one");
            _logger.Warning("User tried to change password to the same one");
            return;
        }

        _user.Password = BCrypt.Net.BCrypt.HashPassword(newPassword);
        _userService.users = _userService.DeleteUser(_user, _path);
        _userService.users.Add(_user); 

        _dataStorage.Save(_userService.users, _path); 

        MessageBox.Show("You have successfully changed the password");
        _logger.Information("User successfully changed the password");
    }


}
