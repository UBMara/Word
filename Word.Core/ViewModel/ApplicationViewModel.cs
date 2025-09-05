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

        public bool SideMenuVisible { get; set; } = false;

        public bool SettingsMenuVisible { get; set; }

        public void GoToPage(ApplicationPage page)
        {
            CurrentPage = page;
            SideMenuVisible = page == ApplicationPage.Chat;

        }
    }

}
