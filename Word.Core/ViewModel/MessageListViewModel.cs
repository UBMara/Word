using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Word.Core.ViewModel
{ 
    public class MessageListViewModel : BaseViewModel
    {
        public List<MessageListItemViewModel>? Items { get; set; }
        public ICommand? AttachmentButtonCommand { get; set; }
        public ICommand? PopUpClickawayCommand { get; set; }
        public ICommand SendCommand { get; set; }
        public bool AttachmentMenuVisible { get; set; }
        public ChatAttachmentPopupMenuViewModel AttachmentMenu { get; set; }
        public bool AnyPopupVisible => AttachmentMenuVisible;

        public MessageListViewModel()
        {
            AttachmentButtonCommand = new RelayCommand(AttachmentButton);
            PopUpClickawayCommand = new RelayCommand(PopUpClickaway);
            SendCommand = new RelayCommand(Send);
            AttachmentMenu = new ChatAttachmentPopupMenuViewModel();
        }

        public void PopUpClickaway()
        {
            AttachmentMenuVisible = false;
        }

        private void AttachmentButton()
        {
            AttachmentMenuVisible ^= true;
        }

        public void Send()
        {
            IoC.UI.ShowMessage(new MessageBoxDialogViewModel
            {
                Title = "Send Message",
                Message = "Thank you for writing a nice message :)",
                OkText = "OK"
            });
        }
    }
}
