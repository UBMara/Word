using Ninject;
using Word.Core.ViewModel;

namespace Word.Core
{
    public static class IoC
    {
        public static IKernel Kernel { get; private set; } = new StandardKernel();
        public static IUIManager UI => IoC.Get<IUIManager>();
        public static ApplicationViewModel Application => IoC.Get<ApplicationViewModel>();
        public static SettingsViewModel Settings => IoC.Get<SettingsViewModel>();

        public static T Get<T>()
        {
            return Kernel.Get<T>();
        }

        public static void SetUp()
        {
            BindViewModel();
        }

        private static void BindViewModel()
        {
            Kernel.Bind<ApplicationViewModel>().ToConstant(new ApplicationViewModel());
            Kernel.Bind<SettingsViewModel>().ToConstant(new SettingsViewModel());
        }
    }
}
