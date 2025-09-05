using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word.Core.ViewModel
{
    public class MessageBoxDisignModel : MessageBoxDialogViewModel
    {
        public static MessageBoxDisignModel Instance => new MessageBoxDisignModel();

        public MessageBoxDisignModel()
        {
            OkText = "OK";
            Message = "Design time messages are fun :)";
        }
    }
}
