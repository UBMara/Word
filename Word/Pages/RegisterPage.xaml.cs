using System.Security;
using Word.Core.ViewModel;

namespace Word
{
    public partial class RegisterPage : BasePage<RegisterViewModel>, IHavePassword

    {
        public RegisterPage()
        {
            InitializeComponent();

        }

        public SecureString SecurePassword => PasswordText.SecurePassword;
    }
}
