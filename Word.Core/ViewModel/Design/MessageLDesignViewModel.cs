using System.Collections.ObjectModel;
using Word.Core.ViewModel;

namespace Word.Core
{
    public class MessageLDesignViewModel : MessageListViewModel
    {
        public static MessageLDesignViewModel Instance => new MessageLDesignViewModel();

        public MessageLDesignViewModel()
        {
            Items = new List<MessageListItemViewModel>
            {
                new MessageListItemViewModel()
                {
                    SenderName = "Parnell",
                    Initials = "PL",
                    Message = "I'm about to wipe the old server",
                    ProfilePicRGB = "F5276C",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    SentByMe = false,
                },

                new MessageListItemViewModel()
                {
                    SenderName = "Luke",
                    Initials = "LM",
                    Message = "Let me know when you manage to spin up the new 2016 server",
                    ProfilePicRGB = "F54927",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    MessageReadTime = DateTimeOffset.UtcNow.Subtract(TimeSpan.FromDays(1.3)),
                    SentByMe = true,
                },

                new MessageListItemViewModel()
                {
                    SenderName = "Parnell",
                    Initials = "PL",
                    Message = "The new server is up.",
                    ProfilePicRGB = "F5B027",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    SentByMe = false,
                }
                
            };
        }
    }
}
