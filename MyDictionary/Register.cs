using Serilog;
using Serilog.Core;

namespace MyDictionary
{
    public partial class Register : Form
    {
        private Login _login;
        private bool _IsFirstPicture = false;
        private readonly Logger _logger;
        private string _path = "users.json";
        public Register(Login login)
        {
            _login = login;
            _logger = new LoggerConfiguration()
                            .WriteTo.File("logs.txt", outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level:u3}]: {Message:lj} {NewLine}{Exception}")
                            .MinimumLevel.Debug()
                            .CreateLogger();
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
            string openPath = Path.Combine("Image", "openPassword.png");
            string closePath = Path.Combine("Image", "closePassword.png");

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
            errorRtb.SelectAll();
            errorRtb.SelectionAlignment = HorizontalAlignment.Center;

            var user = new User();
            var users = new List<User>();
            users = users.GetUsersFromFile(_path).ToList();

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

            if (IsvalidLogin(loginTb.Text, users) && IsValidPassword(passwordTb.Text, passwordAgainTb.Text) && IsValidBDate(user.BDate))
            {
                errorRtb.Text = "";
                user.SetUsersToFile(_path);
                MessageBox.Show("You successfully registered!");
                _logger.Information("User successfully registered.");
            }

        }

        private bool IsvalidLogin(string login, List<User> users)
        {
            if (string.IsNullOrEmpty(login) || login.Length < 3)
            {
                errorRtb.Text = "Enter correct login!";
                _logger.Error("User entered an incorrect login.");
                return false;
            }

            if (users.Any(u => u.Login == login))
            {
                errorRtb.Text = "Such a login is already registered.";
                _logger.Error("Such a login is already registered.");
                return false;
            }

            _logger.Information("User entered a valid login.");
            return true;
        }
        private bool IsValidPassword(string password, string confirmPassword)
        {
            if (password.Length < 8)
            {
                errorRtb.Text = "Password must be longer than 8 characters.";
                _logger.Error("Password must be longer than 8 characters.");
                return false;
            }

            if (password != confirmPassword)
            {
                errorRtb.Text = "Passwords must match.";
                _logger.Error("Passwords must match.");
                return false;
            }

            _logger.Information("User entered a valid password.");
            return true;
        }
        private bool IsValidBDate(DateTime bDate)
        {
            var age = DateTime.Now.Year - bDate.Year;

            if (age < 3)
            {
                errorRtb.Text = "You must be at least 3 years old to register.";
                _logger.Error("User is under 3.");
                return false;
            }
            if(age > 100)
            {
                errorRtb.Text = "Enter valid date";
                _logger.Error("User enter incorrect date");
                return false;
            }

            _logger.Information("User's age is valid.");
            return true;
        }
    }
}
