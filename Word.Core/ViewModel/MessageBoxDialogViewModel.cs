using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word.Core.ViewModel
{
    public class MessageBoxDialogViewModel : BaseViewModel
    {
        public string? Message { get; set; }
        public string? OkText { get; set; }
    }
}
