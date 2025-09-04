using System.Windows;
using Word.Core;

namespace Word
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            ApplicationSetup();

            Current.MainWindow = new MainWindow();
            Current.MainWindow.Show();
        }

        public void ApplicationSetup()
        {
            IoC.SetUp();
            IoC.Kernel.Bind<IUIManager>().ToConstant(new UIManager());
        }
    }

}
