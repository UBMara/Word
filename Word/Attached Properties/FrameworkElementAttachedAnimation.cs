using System.Windows;

namespace Word
{
    public abstract class AnimateBaseProperty<Parent> : BaseAttachedProperty<Parent, bool>
        where Parent : BaseAttachedProperty<Parent, bool>, new()
    {
        protected Dictionary<DependencyObject, bool> mAlreadyLoaded = new Dictionary<DependencyObject, bool>();
        protected Dictionary<DependencyObject, bool> mFirstLoadValue = new Dictionary<DependencyObject, bool>();

        public override void OnValueUpdated(DependencyObject sender, object value)
        {
            if (!(sender is FrameworkElement element))
                return;

            if ((bool)sender.GetValue(ValueProperty) == (bool)value && mAlreadyLoaded.ContainsKey(sender))
                return;

            if (!mAlreadyLoaded.ContainsKey(sender))
            {
                mAlreadyLoaded[sender] = false;

                if (!(bool)value)
                    element.Visibility = Visibility.Hidden;

                RoutedEventHandler onLoaded = null;
                onLoaded = async (ss, ee) =>
                {
                    element.Loaded -= onLoaded;

                    await Task.Delay(5);

                    DoAnimation(element, mFirstLoadValue.ContainsKey(sender) ? mFirstLoadValue[sender] : (bool)value, true);

                    mAlreadyLoaded[sender] = true;
                };

                element.Loaded += onLoaded;
            }

            else if (mAlreadyLoaded[sender] == false)
                mFirstLoadValue[sender] = (bool)value;
            else
                DoAnimation(element, (bool)value, false);
        }

        protected virtual void DoAnimation(FrameworkElement element, bool value, bool firstLoad) { }
    }
    public class AnimateSlideLeft : AnimateBaseProperty<AnimateSlideLeft>
    {
        protected override async void DoAnimation(FrameworkElement element, bool value, bool firstLoad)
        {
            if (value)
                await element.SlideAndFadeIn(AnimationSlideInDirection.Left, firstLoad, firstLoad ? 0 : 0.3f, keepMargin: false);
            else
                await element.SlideAndFadeOut(AnimationSlideInDirection.Left, firstLoad ? 0 : 0.3f, keepMargin: false);
        }
    }

    public class AnimateSlideBottom : AnimateBaseProperty<AnimateSlideBottom>
    {
        protected override async void DoAnimation(FrameworkElement element, bool value, bool firstLoad)
        {
            if (value)
                await element.SlideAndFadeIn(AnimationSlideInDirection.Bottom, firstLoad, firstLoad ? 0 : 0.3f, keepMargin: false);
            else
                await element.SlideAndFadeOut(AnimationSlideInDirection.Bottom, firstLoad ? 0 : 0.3f, keepMargin: false);
        }
    }

    public class AnimateSlideBottomMargin : AnimateBaseProperty<AnimateSlideBottomMargin>
    {
        protected override async void DoAnimation(FrameworkElement element, bool value, bool firstLoad)
        {
            if (value)
                await element.SlideAndFadeIn(AnimationSlideInDirection.Bottom, firstLoad, firstLoad ? 0 : 0.3f, keepMargin: true);
            else
                await element.SlideAndFadeOut(AnimationSlideInDirection.Bottom, firstLoad ? 0 : 0.3f, keepMargin: true);
        }
    }

    public class AnimateFadeInOut : AnimateBaseProperty<AnimateFadeInOut>
    {
        protected override async void DoAnimation(FrameworkElement element, bool value, bool firstLoad)
        {
            if (value)
                await element.FadeIn(firstLoad, firstLoad ? 0 : 0.3f);
            else
                await element.FadeOut(firstLoad ? 0 : 0.3f);
        }
    }
}