using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word.Core.ViewModel
{
    public class ChatListItemViewModel : BaseViewModel
    {
        public string? Name { get; set; }
        public string? Message { get; set; }
        public string? Initials { get; set; }
        public string? ProfilePicRGB { get; set; }

        public bool NowContentAvailable { get; set; }
        public bool IsSelected { get; set; }

    }
}
