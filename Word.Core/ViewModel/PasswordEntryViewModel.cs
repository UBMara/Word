using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Word.Core.ViewModel
{
    public class PasswordEntryViewModel : BaseViewModel
    {
        public string Label { get; set; }
        public string FakePassword { get; set; }
        public string CurrentPasswordHintText { get; set; }
        public string NewPasswordHintText { get; set; }
        public string ConfirmPasswordHintText { get; set; }
        public SecureString CurrentPassword { get; set; }
        public SecureString NewPassword { get; set; }
        public SecureString ConfirmPassword { get; set; }
        public bool Editing {  get; set; }

        public ICommand EditCommand { get; set; }
        public ICommand CancelCommand { get; set; }
        public ICommand SaveCommand { get; set; }

        public PasswordEntryViewModel()
        {
            EditCommand = new RelayCommand(Edit);
            CancelCommand = new RelayCommand(Cancel);
            SaveCommand = new RelayCommand(Save);

            CurrentPasswordHintText = "Current Password";
            NewPasswordHintText = "New Password";
            ConfirmPasswordHintText = "Confirm Password";
        }

        private void Save()
        {
            var storedPassword = "Testing";

            if (storedPassword != CurrentPassword.Unsecure())
            {
                IoC.UI.ShowMessage(new MessageBoxDialogViewModel
                {
                    Title = "Wrong password",
                    Message = "The current password is invalid"
                });

                return;
            }

            if (NewPassword.Unsecure() != ConfirmPassword.Unsecure())
            {
                IoC.UI.ShowMessage(new MessageBoxDialogViewModel
                {
                    Title = "Password mismatch",
                    Message = "The new and confirm password do not match"
                });

                return;
            }

            if (NewPassword.Unsecure().Length == 0)
            {
                IoC.UI.ShowMessage(new MessageBoxDialogViewModel
                {
                    Title = "Password too short",
                    Message = "You must enter a password!"
                });

                return;
            }

            CurrentPassword = new SecureString();
            foreach (var c in NewPassword.Unsecure().ToCharArray())
                CurrentPassword.AppendChar(c);

            Editing = false;
        }

        private void Cancel()
        {
            Editing = false;
        }

        public void Edit()
        {
            NewPassword = new SecureString();
            ConfirmPassword = new SecureString();

            Editing = true;
        }
    }
}
