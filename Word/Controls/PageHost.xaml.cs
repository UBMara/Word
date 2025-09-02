using System.Windows;
using System.Windows.Controls;

namespace Word
{
    public partial class PageHost : UserControl
    {
        public BasePage CurrentPage
        {
            get => (BasePage)GetValue(CurrentPageProperty);
            set => SetValue(CurrentPageProperty, value);
        }

        public static readonly DependencyProperty CurrentPageProperty =
            DependencyProperty.Register(nameof(CurrentPage), typeof(BasePage), typeof(PageHost), new UIPropertyMetadata(CurrentPagePropertyChange));

        private static void CurrentPagePropertyChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var newPageFrame = (d as PageHost)?.NewPage;
            var oldPageFrame = (d as PageHost)?.OldPage;
            var oldPageContent = newPageFrame?.Content;
            newPageFrame.Content = null;
            oldPageFrame.Content = oldPageContent;

            if (oldPageContent is BasePage oldPage)
                oldPage.ShouldAnimateOut = true;

            newPageFrame.Content = e.NewValue;
        }

        public PageHost()
        {
            InitializeComponent();
        }
    }
}
