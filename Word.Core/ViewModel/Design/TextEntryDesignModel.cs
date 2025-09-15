using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word.Core.ViewModel
{
    public class TextEntryDesignModel : TextEntryViewModel
    {
        public static TextEntryDesignModel Instance => new TextEntryDesignModel();

        public TextEntryDesignModel()
        {
            Label = "Name";
            OriginalText = "Luke Malpass";
            EditedText = "Editing :)";
        }
    }
}
