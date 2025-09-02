using System.Windows.Controls;
using System.Windows;
using Word.Core.ViewModel;

namespace Word
{
    public class BasePage : Page
    {
        public PageAnimation PageLoad { get; set; } = PageAnimation.SlideAndFadeRight;
        public PageAnimation PageUnload { get; set; } = PageAnimation.SlideAndFadeLeft;

        public float SlideSec { get; set; } = 0.8f;
        
        public bool ShouldAnimateOut { get; set; }
        public BasePage()
        {
            if (this.PageLoad != PageAnimation.None)
                this.Visibility = Visibility.Collapsed;

            this.Loaded += BasePage_Loaded;

        }

        private async void BasePage_Loaded(object sender, RoutedEventArgs e)
        {
            if (ShouldAnimateOut)
                await AnimateOut();
            else await AnimateIn();
        }

        public async Task AnimateIn()
        {
            if (this.PageLoad == PageAnimation.None) return;

            switch (this.PageLoad)
            {
                case PageAnimation.SlideAndFadeRight:
                    await this.SlideAndFadeFromRight(this.SlideSec);
                    break;
            }
        }

        public async Task AnimateOut()
        {
            if (this.PageUnload == PageAnimation.None) return;

            switch (this.PageUnload)
            {
                case PageAnimation.SlideAndFadeLeft:
                    await this.SlideAndFadeToLeft(this.SlideSec);
                    break;
            }
        }
    }

    public class BasePage<VM> : BasePage
        where VM : BaseViewModel, new()
    {
        private VM? _viewModel;

        public VM ViewModel
        {
            get { return _viewModel; }
            set
            {
                if (_viewModel == value) return;

                _viewModel = value;
                this.DataContext = _viewModel;
            }
        }

        public BasePage() : base()
        {
            ViewModel = new VM();
        }

    }
}
