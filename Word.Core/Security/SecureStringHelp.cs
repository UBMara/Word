using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Word.Core
{
    public static class SecureStringHelp
    {
        public static string Unsecure(this SecureString secureString)
        {
            if (secureString == null) return string.Empty;

            var unmanagedstring = IntPtr.Zero;

            try
            {
                unmanagedstring = Marshal.SecureStringToGlobalAllocUnicode(secureString);
                return Marshal.PtrToStringUni(unmanagedstring);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedstring);
            }
        }
    }
}
