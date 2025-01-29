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
            var newBdate = DateTime.Parse(newBdayTb.Text);
            _user.BDate = newBdate;
            _userService.DeleteUser(_user,_path);
            _dataStorage.Save(_userService.users, _path);

            bDayLb.Text = $"Your date of birth: {_user.BDate.ToShortDateString()}";
            MessageBox.Show("You have successfully changed your date of birth");
            _logger.Information($"User successfully changed password");
        }
        catch (Exception ex)
        {
            MessageBox.Show("The date you entered is incorrect.");
            _logger.Error($"{ex} {ex.Message}");
        }
    }
    private void changeBtn_Click(object sender, EventArgs e)
    {
        var oldPassword = oldPasswordTb.Text;
        var newPassword = newPasswordTb.Text;

        if (oldPassword == _user.Password)
        {
            _user.Password = newPassword;
            _userService.DeleteUser(_user, _path);
            _dataStorage.Save(_userService.users, _path);

            MessageBox.Show("You have successfully changed the password");
            _logger.Information("User successfully changed the password");
        }
        else
        {
            MessageBox.Show("You entered an incorrect password");
            _logger.Error("User entered incorrect password");
        }
    }

}
