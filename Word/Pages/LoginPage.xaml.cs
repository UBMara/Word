using System.Security;

namespace Word.Pages
{
    public partial class LoginPage : BasePage<LoginViewModel>, IHavePassword

    {
        public LoginPage()
        {
            InitializeComponent();
        }

        public SecureString SecurePassword => PasswordText.SecurePassword;
    }
}
