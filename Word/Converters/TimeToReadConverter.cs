using System.Globalization;
using System.Windows;
using Word.Converters;

namespace Word
{
    class TimeToReadConverter : BaseConverter<TimeToReadConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var time = (DateTimeOffset)value;

            if (time == DateTimeOffset.MinValue)
                return string.Empty;

            if (time.Date == DateTimeOffset.UtcNow.Date)
                return $"Read {time.ToLocalTime().ToString("HH:mm")}";

            return $"Read {time.ToLocalTime().ToString("HH:mm, MMM yyyy")}";

        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
