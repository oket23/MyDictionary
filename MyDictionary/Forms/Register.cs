using MyDictionary.Class;
using MyDictionary.Forms;
using Serilog.Core;

namespace MyDictionary;

public partial class Register : Form
{
    private Login _login;
    private bool _IsFirstPicture = false;
    private UserService _userService;
    private IDataStorage<User> _dataStorage;
    private readonly Logger _logger;
    private string _path = "users.json";
    public Register(Login login, Logger logger)
    {
        _login = login;
        _logger = logger;
        _userService = new UserService(_logger);
        _dataStorage = new FileUserDataStorage();
        InitializeComponent();
    }

    private void loginLb_Click(object sender, EventArgs e)
    {
        Hide();
        _login.Show();
    }
    private void Register_FormClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }
    private void passwordPicture_Click(object sender, EventArgs e)
    {
        var openPath = Path.Combine("Image", "openPassword.png");
        var closePath = Path.Combine("Image", "closePassword.png");

        if (_IsFirstPicture)
        {
            passwordPicture.Image = Image.FromFile(closePath);
            passwordTb.PasswordChar = '*';
            passwordAgainTb.PasswordChar = '*';
            _IsFirstPicture = false;
        }
        else
        {
            passwordPicture.Image = Image.FromFile(openPath);
            passwordTb.PasswordChar = '\0';
            passwordAgainTb.PasswordChar = '\0';
            _IsFirstPicture = true;
        }
    }
    private void registerBtn_Click(object sender, EventArgs e)
    {
        _userService.users = _dataStorage.Get(_path);
        var user = new User();
        var passwordHash = passwordTb.Text.GetHashCode();

        try
        {
            user.Login = loginTb.Text;
            user.Password = passwordTb.Text;
            user.BDate = DateTime.Parse(BdayTb.Text);
        }
        catch (Exception ex)
        {
            _logger.Error($"{ex} {ex.Message}");
        }

        if (_userService.IsvalidLogin(user.Login, _userService.users) && _userService.IsValidPassword(user.Password, passwordAgainTb.Text) && _userService.IsValidBDate(user.BDate))
        {
            _userService.users.Add(user);
            _dataStorage.Save(_userService.users, _path);
            MessageBox.Show("You successfully registered!");
            _logger.Information("User successfully registered.");
        }

    }

}
