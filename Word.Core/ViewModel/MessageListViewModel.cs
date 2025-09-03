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
        public bool AttachmentMenuVisible { get; set; }
        //public ChatAttachmentPopupMenuViewModel AttachmentMenu { get; set; }

        public MessageListViewModel()
        {
            AttachmentButtonCommand = new RelayCommand(AttachmentButton);
            //AttachmentMenu = new ChatAttachmentPopupMenuViewModel();
        }

        private void AttachmentButton()
        {
            AttachmentMenuVisible ^= true;
        }
    }
}
