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
            IoC.Get<ApplicationViewModel>().CurrentPage = ApplicationPage.Register;


            await Task.Delay(1);
        }

        public async Task Login(object parameter)
        {
            await RunCommand(() => this.LoginIsRunning, async () =>
            {
                await Task.Delay(5000);

            });
        }
    }
}
