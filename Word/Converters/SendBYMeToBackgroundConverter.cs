using System.Globalization;
using System.Windows;
using Word.Converters;

namespace Word
{
    class SendBYMeToBackgroundConverter : BaseConverter<SendBYMeToBackgroundConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? Application.Current.FindResource("LighterBlueForegroundBrush") : Application.Current.FindResource("LightForegroundBrush");

        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
