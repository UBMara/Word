using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Word.Core.ViewModel
{
    public class ChatAttachmentPopupMenuViewModel : BasePopupMenuViewModel
    {
        public string? BubbleBackground { get; set; }
        public ElementHorizontalAlignment ArrowAlignment { get; set; }

        public ChatAttachmentPopupMenuViewModel()
        {
            BubbleBackground = "ffffff";
            ArrowAlignment = ElementHorizontalAlignment.Left;
        }
    }
}
