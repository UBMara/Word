namespace Word.Core.ViewModel
{
    public class ApplicationViewModel : BaseViewModel
    {
        private ApplicationPage _currentPage = ApplicationPage.Login;
        public ApplicationPage CurrentPage
        {
            get => _currentPage;
            set
            {
                _currentPage = value;
                OnPropertyChanged(nameof(CurrentPage));
            }
        }

        public BaseViewModel? CurrentPageViewModel { get; set; }

        public bool SideMenuVisible { get; set; } = false;

        public bool SettingsMenuVisible { get; set; }

        public void GoToPage(ApplicationPage page, BaseViewModel viewModel = null)
        {
            SettingsMenuVisible = false;
            CurrentPageViewModel = viewModel;
            CurrentPage = page;
            OnPropertyChanged(nameof(CurrentPage));
            SideMenuVisible = page == ApplicationPage.Chat;

        }
    }

}
