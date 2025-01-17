namespace MyDictionary
{
    public partial class Login : Form
    {
        private int _leftPading = 10;
        private bool _IsFirstPicture = false;
        public Login()
        {
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

        private void changeForm(Form form)
        {
            Hide();
            form.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon...");
        }

        private void registerLb_Click(object sender, EventArgs e)
        {
            Register register = new Register(this);
            changeForm(register);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void loginLb_Click(object sender, EventArgs e)
        {

        }
    }
}
