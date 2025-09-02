
namespace Word.Core.ViewModel
{
    public class MessageListItemViewModel : BaseViewModel
    {
        public string SenderName { get; set; }
        public string Message { get; set; }
        public string Initials { get; set; }
        public string ProfilePicRGB { get; set; }
        public bool IsSelected { get; set; }
        public bool SentByMe { get; set; }
        public DateTimeOffset MessageReadTime { get; set; }
        public bool MessageRead => MessageReadTime > DateTimeOffset.MinValue;
        public DateTimeOffset MessageSentTime { get; set; }
    }
}
