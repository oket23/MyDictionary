using Serilog;
using Serilog.Core;

namespace MyDictionary
{
    public partial class Login : Form
    {
        private int _leftPading = 10;
        private bool _IsFirstPicture = false;
        private readonly Logger _logger;
        private string _path = "users.json";
        public Login()
        {
            _logger = new LoggerConfiguration()
               .WriteTo.File("logs.txt", outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level:u3}]: {Message:lj} {NewLine}{Exception}")
               .MinimumLevel.Debug()
               .CreateLogger();

            InitializeComponent();
        }

        private void passwordPicture_Click(object sender, EventArgs e)
        {
            string openPath = Path.Combine("Image", "openPassword.png");
            string closePath = Path.Combine("Image", "closePassword.png");

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
            ForgotPassword forgotPassword = new ForgotPassword(this);
            changeForm(forgotPassword);

        }
        public void changeForm(Form form)
        {
            Hide();
            form.Show();
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            errorRtb.SelectAll();
            errorRtb.SelectionAlignment = HorizontalAlignment.Center;

            var users = new List<User>();
            users = users.GetUsersFromFile(_path).ToList();


            if (IsValidLoginAndPassword(loginTb.Text, passwordTb.Text, users))
            {
                errorRtb.Text = "";
                MessageBox.Show("You have successfully logged in!");
                Hide();

                if (IsAdmin(users, loginTb.Text))
                {
                    _logger.Information("Admin has successfully logged in!");
                    MessageBox.Show("Hello developer)");
                }
                else
                {
                    _logger.Information("User has successfully logged in!");
                }
                var menu = new Menu(IsAdmin(users, loginTb.Text), users.First(u => u.Login == loginTb.Text));
                changeForm(menu);
            }
        }
        private bool IsValidLoginAndPassword(string login, string password, List<User> users)
        {
            var user = users.FirstOrDefault(u => u.Login == login);
            if (user == null)
            {
                errorRtb.Text = "Such a login does not exist.";
                _logger.Error("User enters incorrect login.");
                return false;
            }
            if (user.Password != password)
            {
                errorRtb.Text = "Incorrect password.";
                _logger.Error("User enters incorrect password.");
                return false;
            }

            return true;
        }
        private bool IsAdmin(List<User> users, string login)
        {
            var user = users.FirstOrDefault(u => u.Login == login);
            if (user != null && login == "oket13")
            {
                return true;
            }
            return false;
        }
        private void registerLb_Click(object sender, EventArgs e)
        {
            Register register = new Register(this);
            changeForm(register);
        }

    }
}
