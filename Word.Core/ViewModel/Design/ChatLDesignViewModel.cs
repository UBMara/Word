using System.Collections.ObjectModel;

namespace Word.Core.ViewModel
{
    public class ChatLDesignViewModel : ChatListViewModel
    {
        public static ChatLDesignViewModel Instance => new ChatLDesignViewModel();

        public ChatLDesignViewModel()
        {
            Items = new List<ChatListItemViewModel>
            {
                new ChatListItemViewModel()
                {
                    Initials = "LM",
                    Name = "Luke",
                    Message = "new message",
                    ProfilePicRGB = "0000CC"
                },

                new ChatListItemViewModel()
                {
                    Initials = "JA",
                    Name = "Jesse",
                    Message = "new message",
                    ProfilePicRGB = "FF6600"
                },

                new ChatListItemViewModel()
                {
                    Initials = "PL",
                    Name = "Pamell",
                    Message = "new message",
                    ProfilePicRGB = "339966",
                    IsSelected = true
                },

                new ChatListItemViewModel()
                {
                    Initials = "LM",
                    Name = "Luke",
                    Message = "new message",
                    ProfilePicRGB = "0000CC"
                },

                new ChatListItemViewModel()
                {
                    Initials = "JA",
                    Name = "Jesse",
                    Message = "new message",
                    ProfilePicRGB = "FF6600"
                },

                new ChatListItemViewModel()
                {
                    Initials = "PL",
                    Name = "Pamell",
                    Message = "new message",
                    ProfilePicRGB = "339966"
                }
            };
        }
    }
}
