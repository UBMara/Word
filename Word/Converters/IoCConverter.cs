using Ninject;
using System.Diagnostics;
using System.Globalization;
using Word.Converters;
using Word.Core;
using Word.Core.ViewModel;

namespace Word
{
    public class IoCConverter : BaseConverter<IoCConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((string)value)
            {
                case nameof(ApplicationPage): return IoC.Application;

                default:
                    Debugger.Break();
                    return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
