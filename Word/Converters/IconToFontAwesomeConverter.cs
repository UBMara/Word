using System.Globalization;
using System.Windows;
using Word.Converters;
using Word.Core;

namespace Word
{
    class IconToFontAwesomeConverter : BaseConverter<IconToFontAwesomeConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((IconType)value).ToFontAwesome();
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
