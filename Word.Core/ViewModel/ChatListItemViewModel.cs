using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

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

        public ICommand OpenMessageCommand { get; set; }

        public ChatListItemViewModel()
        {
            OpenMessageCommand = new RelayCommand(OpenMessage);
        }

        public void OpenMessage()
        {
            if (Name == "Jesse")
            {
                IoC.Application.GoToPage(ApplicationPage.Login, new LoginViewModel
                {
                    Email = "jesse@helloworld.com"
                });
                return;
            }

            IoC.Application.GoToPage(ApplicationPage.Chat, new MessageListViewModel
            {
                Items = new List<MessageListItemViewModel>
                {
                    new MessageListItemViewModel
                    {
                        Message = Message,
                        Initials = Initials,
                        MessageSentTime = DateTime.UtcNow,
                        ProfilePicRGB = "FF00FF",
                        SenderName = "Luke",
                        SentByMe = true,
                    },
                    new MessageListItemViewModel
                    {
                        Message = "A received message",
                        Initials = Initials,
                        MessageSentTime = DateTime.UtcNow,
                        ProfilePicRGB = "FF0000",
                        SenderName = "Parnell",
                        SentByMe = false,
                    },                    
                    new MessageListItemViewModel
                    {
                        Message = "A received message",
                        Initials = Initials,
                        MessageSentTime = DateTime.UtcNow,
                        ProfilePicRGB = "FF0000",
                        SenderName = "Parnell",
                        SentByMe = false,
                    },
                    new MessageListItemViewModel
                    {
                        Message = Message,
                        Initials = Initials,
                        MessageSentTime = DateTime.UtcNow,
                        ProfilePicRGB = "FF00FF",
                        SenderName = "Luke",
                        SentByMe = true,
                    },
                    new MessageListItemViewModel
                    {
                        Message = "A received message",
                        Initials = Initials,
                        MessageSentTime = DateTime.UtcNow,
                        ProfilePicRGB = "FF0000",
                        SenderName = "Parnell",
                        SentByMe = false,
                    },                    
                    new MessageListItemViewModel
                    {
                        Message = "A received message",
                        Initials = Initials,
                        MessageSentTime = DateTime.UtcNow,
                        ProfilePicRGB = "FF0000",
                        SenderName = "Parnell",
                        SentByMe = false,
                    },
                }
            });
        }
    }
}
