using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word.Core.ViewModel
{
    public class ChatLIDesignViewModel : ChatListItemViewModel
    {
        public static ChatLIDesignViewModel Instance => new ChatLIDesignViewModel();

        public ChatLIDesignViewModel()
        {
            Initials = "LM";
            Name = "Luke";
            Message = "new message";
            ProfilePicRGB = "0000CC";
        }
    }
}
