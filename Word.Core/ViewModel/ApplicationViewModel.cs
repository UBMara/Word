using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word.Core.ViewModel
{
    public  class ApplicationViewModel
    {
        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Login;

        public bool SideMenuVisible { get; set; } = false;

    }
}
