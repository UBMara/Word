using System.Globalization;
using System.Windows;
using Word.Converters;

namespace Word
{
    class BooleanInvertConverter : BaseConverter<BooleanInvertConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture) => !(bool)value;

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
    }
}
