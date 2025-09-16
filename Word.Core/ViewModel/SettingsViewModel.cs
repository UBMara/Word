using System.Runtime.InteropServices;
using System.Windows.Input;

namespace Word.Core.ViewModel
{
    public class SettingsViewModel : BaseViewModel
    {
        public ICommand OpenCommand { get; set; }
        public ICommand CloseCommand { get; set; }
        public ICommand LogoutCommand { get; set; }
        public ICommand ClearUserDataCommand { get; set; }

        public TextEntryViewModel Name { get; set; }
        public TextEntryViewModel Username { get; set; }
        public PasswordEntryViewModel Password { get; set; }
        public TextEntryViewModel Email { get; set; }
        public string LogoutText { get; set; }

        public SettingsViewModel()
        {
            OpenCommand = new RelayCommand(Open);
            CloseCommand = new RelayCommand(Close);
            LogoutCommand = new RelayCommand(Logout);
            ClearUserDataCommand = new RelayCommand(ClearUserData);

            Name = new TextEntryViewModel { Label = "Name", OriginalText = "Luke Malpass" };
            Username = new TextEntryViewModel { Label = "Username", OriginalText = "luke" };
            Password = new PasswordEntryViewModel { Label = "Password", FakePassword = "********" };
            Email = new TextEntryViewModel { Label = "Email", OriginalText = "contact@gmail.com" };

            LogoutText = "Logout";
        }
        public void ClearUserData()
        {
            Name = null;
            Username = null;
            Password = null;
            Email = null;
        }

        public void Logout()
        {
            ClearUserData();

            IoC.Application.GoToPage(ApplicationPage.Login);
        }

        public void Close()
        {
            IoC.Application.SettingsMenuVisible = false;
        }

        public void Open()
        {
            IoC.Application.SettingsMenuVisible = true;
        }
    }
}
