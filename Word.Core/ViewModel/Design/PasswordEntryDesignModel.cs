using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word.Core.ViewModel
{
    public class PasswordEntryDesignModel : PasswordEntryViewModel
    {
        public static PasswordEntryDesignModel Instance => new PasswordEntryDesignModel();

        public PasswordEntryDesignModel()
        {
            Label = "Name";
            FakePassword = "********";
        }
    }
}
