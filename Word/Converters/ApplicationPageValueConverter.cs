using System.Diagnostics;
using System.Globalization;
using Word.Converters;
using Word.Core;

namespace Word
{
    public class ApplicationPageValueConverter : BaseConverter<ApplicationPageValueConverter>
    {
        public override object Convert(object value, Type targetType = null, object parameter = null, CultureInfo culture = null)
        {
            switch ((ApplicationPage)value) 
            {
                case ApplicationPage.Login: return new LoginPage();

                case ApplicationPage.Register: return new RegisterPage();

                case ApplicationPage.Chat: return new ChatPage();

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
