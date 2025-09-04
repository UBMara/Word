using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word.Core
{
    public static class IconTypeExtensions
    {
        public static string ToFontAwesome(this IconType type)
        {
            switch (type)
            {
                case IconType.File:
                    return "\uf15b";

                case IconType.Picture:
                    return "\uf03e";

                default:
                    return null;
            }
        }
    }
}
