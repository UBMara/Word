using System.Windows;
using System.Windows.Media.Animation;

namespace Word
{
        public static class FrameworkElementAnimations
        {
            public static async Task SlideAndFadeFromRight(this FrameworkElement elem, float sec = 0.3f, bool keepMargin = true)
            {
                var sb = new Storyboard();
                sb.AddSlideRight(sec, elem.ActualWidth, keepMargin: keepMargin );
                sb.AddFadeIn(sec);
                sb.Begin(elem);
                elem.Visibility = Visibility.Visible;
                await Task.Delay((int)(sec * 1000));
            }

        public static async Task SlideAndFadeFromLeft(this FrameworkElement elem, float sec = 0.3f, bool keepMargin = true)
        {
            var sb = new Storyboard();
            sb.AddSlideRight(sec, elem.ActualWidth, keepMargin: keepMargin);
            sb.AddFadeIn(sec);
            sb.Begin(elem);
            elem.Visibility = Visibility.Visible;
            await Task.Delay((int)(sec * 1000));
        }

        public static async Task SlideAndFadeToLeft(this FrameworkElement elem, float sec = 0.3f, bool keepMargin = true)
            {
                var sb = new Storyboard();
                sb.AddSlideLeft(sec, elem.ActualWidth, keepMargin: keepMargin);
                sb.AddFadeOut(sec);
                sb.Begin(elem);
                elem.Visibility = Visibility.Visible;
                await Task.Delay((int)(sec * 1000));
            }

        public static async Task SlideAndFadeToRight(this FrameworkElement elem, float sec = 0.3f, bool keepMargin = true)
        {
            var sb = new Storyboard();
            sb.AddSlideToRight(sec, elem.ActualWidth, keepMargin: keepMargin);
            sb.AddFadeOut(sec);
            sb.Begin(elem);
            elem.Visibility = Visibility.Visible;
            await Task.Delay((int)(sec * 1000));
        }

    }
}
