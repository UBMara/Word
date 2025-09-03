using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Word.Core.ViewModel
{
    public class BasePopupMenuViewModel : BaseViewModel
    {
        public string? BubbleBackground { get; set; }
        public ElementHorizontalAlignment ArrowAlignment { get; set; }

        public BasePopupMenuViewModel()
        {
            BubbleBackground = "ffffff";
            ArrowAlignment = ElementHorizontalAlignment.Left;
        }
    }
}
