using System.Windows;
using Word.Core;

namespace Word
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            IoC.SetUp();

            Current.MainWindow = new MainWindow();
            Current.MainWindow.Show();
        }
    }

}
