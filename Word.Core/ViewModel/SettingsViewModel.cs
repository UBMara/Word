using System.Runtime.InteropServices;
using System.Windows.Input;

namespace Word.Core.ViewModel
{
    public class SettingsViewModel : BaseViewModel
    {
        public ICommand OpenCommand { get; set; }
        public ICommand CloseCommand { get; set; }

        public TextEntryViewModel Name { get; set; }
        public TextEntryViewModel Username { get; set; }
        public TextEntryViewModel Password { get; set; }
        public TextEntryViewModel Email { get; set; }

        public SettingsViewModel()
        {
            OpenCommand = new RelayCommand(Open);
            CloseCommand = new RelayCommand(Close);
        }

        private void Close()
        {
            IoC.Application.SettingsMenuVisible = false;
        }

        private void Open()
        {
            IoC.Application.SettingsMenuVisible = true;
        }
    }
}
