using System.Security;
using System.Windows.Input;

namespace Word.Core.ViewModel
{
    public class RegisterViewModel : BaseViewModel
    {
        public string? Email { get; set; }

        public bool RegisterIsRunning { get; set; }

        public SecureString? Password { get; set; }

        public ICommand RegisterCommand { get; set; }

        public ICommand LoginCommand { get; set; }

        public RegisterViewModel()
        {
            RegisterCommand = new RelayparameterizedCommand(async(parameter) => await Register(parameter));
            LoginCommand = new RelayCommand(async () => await Login());
        }

        public async Task Login()
        {
            IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.Login);


            await Task.Delay(1);
        }

        public async Task Register(object parameter)
        {
            await RunCommand(() => this.RegisterIsRunning, async () =>
            {
                await Task.Delay(5000);

            });
        }
    }
}
