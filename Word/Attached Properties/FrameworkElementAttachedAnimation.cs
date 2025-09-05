using System.Windows;

namespace Word
{
    public abstract class AnimateBaseProperty<Parent> : BaseAttachedProperty<Parent, bool>
        where Parent : BaseAttachedProperty<Parent, bool>, new()
    {
        public bool FirstLoad { get; set; } = true;
        protected bool FirstFire = true;

        public override void OnValueUpdated(DependencyObject d, object value)
        {
            if(!(d is FrameworkElement element)) return;

            if ((bool)d.GetValue(ValueProperty) == (bool)value && !FirstFire) return;

            FirstFire = false;

            if (FirstLoad)
            {
                if (!(bool)value)
                    element.Visibility = Visibility.Hidden;

                RoutedEventHandler onLoaded = null;
                onLoaded = async (ss, ee) =>
                {
                    element.Loaded -= onLoaded;
                    await Task.Delay(5);
                    DoAnimation(element, (bool)value);
                    FirstLoad = false;
                };

                element.Loaded += onLoaded;
                
            }
            else
            {
                DoAnimation(element, (bool)value);
            }
        }

        protected virtual void DoAnimation(FrameworkElement element, bool value) { }
    }

    public class AnimateSlideLeft : AnimateBaseProperty<AnimateSlideLeft>
    {
        protected override async void DoAnimation(FrameworkElement element, bool value)
        {
            if (value) await element.SlideAndFadeFromLeft(FirstLoad ? 0 : 0.3f, keepMargin: false);

            else await element.SlideAndFadeToLeft(FirstLoad ? 0 : 0.3f, keepMargin: false);
        }
    }

    public class AnimateSlideBottom : AnimateBaseProperty<AnimateSlideBottom>
    {
        protected override async void DoAnimation(FrameworkElement element, bool value)
        {
            if (value) await element.SlideAndFadeFromBottom(FirstLoad ? 0 : 0.3f, keepMargin: false);

            else await element.SlideAndFadeToBottom(FirstLoad ? 0 : 0.3f, keepMargin: false);
        }
    }

    public class AnimateSlideBottomMargin : AnimateBaseProperty<AnimateSlideBottomMargin>
    {
        protected override async void DoAnimation(FrameworkElement element, bool value)
        {
            if (value) await element.SlideAndFadeFromBottom(FirstLoad ? 0 : 0.3f, keepMargin: true);

            else await element.SlideAndFadeToBottom(FirstLoad ? 0 : 0.3f, keepMargin: true);
        }
    }

    public class AnimateFadeInOut : AnimateBaseProperty<AnimateFadeInOut>
    {
        protected override async void DoAnimation(FrameworkElement element, bool value)
        {
            if (value) await element.FadeIn(FirstLoad ? 0 : 0.3f);

            else await element.FadeOut(FirstLoad ? 0 : 0.3f);
        }
    }
}
