using Serilog.Core;

namespace MyDictionary;

public partial class ForgotPassword : Form
{
    private Login _login;
    private Logger _logger;
    public ForgotPassword(Login login,Logger logger)
    {
        _login = login;
        _logger = logger;
        InitializeComponent();
    }

    private void backToLogginBtn_Click(object sender, EventArgs e)
    {
        Hide();
        _login.Show();
    }

    private void ForgotPassword_FormClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }
}
