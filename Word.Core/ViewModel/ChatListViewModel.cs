using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word.Core.ViewModel
{ 
    public class ChatListViewModel : BaseViewModel
    {
        public List<ChatListItemViewModel>? Items { get; set; }
    }
}
