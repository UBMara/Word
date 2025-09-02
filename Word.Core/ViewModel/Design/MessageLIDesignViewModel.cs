using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word.Core.ViewModel
{
    public class MessageLIDesignViewModel : MessageListItemViewModel
    {
        public static MessageLIDesignViewModel Instance => new MessageLIDesignViewModel();

        public MessageLIDesignViewModel()
        {
            Initials = "LM";
            SenderName = "Luke";
            Message = "Some design time visual text";
            ProfilePicRGB = "5D3FD3";
            SentByMe = true;
            MessageSentTime = DateTimeOffset.UtcNow;
            MessageReadTime = DateTimeOffset.UtcNow.Subtract(TimeSpan.FromDays(1.3));
            
        }
    }
}
