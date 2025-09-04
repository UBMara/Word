using Ninject;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using Word.Converters;
using Word.Core;
using Word.Core.ViewModel;

namespace Word
{
    public class HorizontalAlignmentConverter : BaseConverter<HorizontalAlignmentConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (HorizontalAlignment)value;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
