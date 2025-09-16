using System.Security;
using System.Windows.Input;

namespace Word.Core.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        public string? Email { get; set; }

        public bool LoginIsRunning { get; set; }

        public SecureString? Password { get; set; }

        public ICommand RegisterCommand { get; set; }

        public ICommand LoginCommand { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new RelayparameterizedCommand(async(parameter) => await Login(parameter));
            RegisterCommand = new RelayCommand(async () => await Register());
        }

        public async Task Register()
        {
            IoC.Application.GoToPage(ApplicationPage.Register);


            await Task.Delay(1);
        }

        public async Task Login(object parameter)
        {
            await RunCommand(() => LoginIsRunning, async () =>
            {
                await Task.Delay(1000);

                IoC.Settings.Name = new TextEntryViewModel { Label = "Name", OriginalText = $"Luke Malpass {DateTime.Now.ToLocalTime()}" };
                IoC.Settings.Username = new TextEntryViewModel { Label = "Username", OriginalText = "luke" };
                IoC.Settings.Password = new PasswordEntryViewModel { Label = "Password", FakePassword = "********" };
                IoC.Settings.Email = new TextEntryViewModel { Label = "Email", OriginalText = "contact@gmail.com" };

                IoC.Application.GoToPage(ApplicationPage.Chat);
            });
        }
    }
}
