using System.Security;

namespace Word
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
