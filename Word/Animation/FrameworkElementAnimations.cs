using System.Windows;
using System.Windows.Media.Animation;
using System.Windows.Media.Media3D;
using System.Xml.Linq;

namespace Word
{
    public static class FrameworkElementAnimations
    {
        public static async Task SlideAndFadeFromRight(this FrameworkElement elem, float sec = 0.3f, bool keepMargin = true, int width = 0)
        {
            var sb = new Storyboard();
            sb.AddSlideRight(sec, width == 0 ? elem.ActualWidth : width, keepMargin: keepMargin);
            sb.AddFadeIn(sec);
            sb.Begin(elem);

            if (sec != 0)
                elem.Visibility = Visibility.Visible;

            await Task.Delay((int)(sec * 1000));
        }

        public static async Task SlideAndFadeFromLeft(this FrameworkElement elem, float sec = 0.3f, bool keepMargin = true, int width = 0)
        {
            var sb = new Storyboard();
            sb.AddSlideRight(sec, width == 0 ? elem.ActualWidth : width, keepMargin: keepMargin);
            sb.AddFadeIn(sec);
            sb.Begin(elem);

            if (sec != 0)
                elem.Visibility = Visibility.Visible;

            await Task.Delay((int)(sec * 1000));
        }

        public static async Task SlideAndFadeToLeft(this FrameworkElement elem, float sec = 0.3f, bool keepMargin = true, int width = 0)
        {
            var sb = new Storyboard();
            sb.AddSlideLeft(sec, width == 0 ? elem.ActualWidth : width, keepMargin: keepMargin);
            sb.AddFadeOut(sec);
            sb.Begin(elem);

            if (sec != 0)
                elem.Visibility = Visibility.Visible;

            await Task.Delay((int)(sec * 1000));
            elem.Visibility = Visibility.Hidden;
        }

        public static async Task SlideAndFadeToRight(this FrameworkElement elem, float sec = 0.3f, bool keepMargin = true, int width = 0)
        {
            var sb = new Storyboard();
            sb.AddSlideToRight(sec, width == 0 ? elem.ActualWidth : width, keepMargin: keepMargin);
            sb.AddFadeOut(sec);
            sb.Begin(elem);

            if (sec != 0)
                elem.Visibility = Visibility.Visible;

            await Task.Delay((int)(sec * 1000));
            elem.Visibility = Visibility.Hidden;
        }

        public static async Task SlideAndFadeFromBottom(this FrameworkElement elem, float sec = 0.3f, bool keepMargin = true, int height = 0)
        {
            var sb = new Storyboard();
            sb.AddSlideFromBottom(sec, height == 0 ? elem.ActualHeight : height, keepMargin: keepMargin);
            sb.AddFadeIn(sec);
            sb.Begin(elem);

            if (sec != 0)
                elem.Visibility = Visibility.Visible;

            await Task.Delay((int)(sec * 1000));
        }

        public static async Task SlideAndFadeToBottom(this FrameworkElement elem, float sec = 0.3f, bool keepMargin = true, int height = 0)
        {
            var sb = new Storyboard();
            sb.AddSlideToBottom(sec, height == 0 ? elem.ActualHeight : height, keepMargin: keepMargin);
            sb.AddFadeOut(sec);
            sb.Begin(elem);

            if (sec != 0)
                elem.Visibility = Visibility.Visible;

            await Task.Delay((int)(sec * 1000));
            elem.Visibility = Visibility.Hidden;
        }

        public static async Task FadeIn(this FrameworkElement elem, float sec = 0.3f)
        {
            var sb = new Storyboard();
            sb.AddFadeIn(sec);
            sb.Begin(elem);

            if (sec != 0)
                elem.Visibility = Visibility.Visible;

            await Task.Delay((int)(sec * 1000));
        }

        public static async Task FadeOut(this FrameworkElement elem, float sec = 0.3f)
        {
            var sb = new Storyboard();
            sb.AddFadeOut(sec);
            sb.Begin(elem);

            if (sec != 0)
                elem.Visibility = Visibility.Visible;

            await Task.Delay((int)(sec * 1000));
            elem.Visibility = Visibility.Collapsed;
        }

    }
}
