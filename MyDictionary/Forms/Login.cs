using MyDictionary.Class;
using MyDictionary.Forms;
using Serilog.Core;

namespace MyDictionary;

public partial class Login : Form
{
    private bool _IsFirstPicture = false;
    private UserService _userService;
    private readonly Logger _logger;
    private string _path = "users.json";
    private IDataStorage<User> _dataStorage;
    public Login(Logger logger)
    {
        _logger = logger;
        _userService = new UserService(_logger);
        _dataStorage = new FileUserDataStorage();
        InitializeComponent();
    }

    private void passwordPicture_Click(object sender, EventArgs e)
    {
        var openPath = Path.Combine("Image", "openPassword.png");
        var closePath = Path.Combine("Image", "closePassword.png");

        if (_IsFirstPicture)
        {
            passwordPicture.Image = Image.FromFile(closePath);
            passwordTb.PasswordChar = '*';
            _IsFirstPicture = false;
        }
        else
        {
            passwordPicture.Image = Image.FromFile(openPath);
            passwordTb.PasswordChar = '\0';
            _IsFirstPicture = true;
        }

    }
    private void forgotLb_Click(object sender, EventArgs e)
    {
        ForgotPassword forgotPassword = new ForgotPassword(this, _logger);
        ChangeForm(forgotPassword);

    }
    public void ChangeForm(Form form)
    {
        Hide();
        form.Show();
    }
    private void loginBtn_Click(object sender, EventArgs e)
    {
        _userService.users = _dataStorage.Get(_path);

        if (_userService.IsValidLoginAndPassword(loginTb.Text, passwordTb.Text, _userService.users))
        {
            MessageBox.Show("You have successfully logged in!");
            Hide();

            if (_userService.IsAdmin(_userService.users, loginTb.Text))
            {
                _logger.Information("Admin has successfully logged in!");
                MessageBox.Show("Hello developer)");
            }
            else
            {
                _logger.Information("User has successfully logged in!");
            }
            var menu = new Menu(_userService.IsAdmin(_userService.users, loginTb.Text), _userService.users.First(u => u.Login == loginTb.Text), _logger);
            ChangeForm(menu);
        }
    }
    private void registerLb_Click(object sender, EventArgs e)
    {
        Register register = new Register(this, _logger);
        ChangeForm(register);
    }


}
