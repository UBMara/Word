using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word.Core.ViewModel
{ 
    public class MessageListViewModel : BaseViewModel
    {
        public List<MessageListItemViewModel> Items { get; set; }
    }
}
