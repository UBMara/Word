using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Word
{
    public static class PageAnimations
    {
        public static async Task SlideAndFadeFromRight(this Page page, float sec)
        {
            var sb = new Storyboard();
            sb.AddSlideRight(sec, page.WindowWidth);
            sb.AddFadeIn(sec);
            sb.Begin(page);
            page.Visibility = Visibility.Visible;
            await Task.Delay((int)(sec * 1000));
        }

        public static async Task SlideAndFadeToLeft(this Page page, float sec)
        {
            var sb = new Storyboard();
            sb.AddSlideLeft(sec, page.WindowWidth);
            sb.AddFadeOut(sec);
            sb.Begin(page);
            page.Visibility = Visibility.Visible;
            await Task.Delay((int)(sec * 1000));
        }
    }
}
