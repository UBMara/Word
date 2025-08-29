using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace Word
{
    public abstract class AnimateBaseProperty<Parent> : BaseAttachedProperty<Parent, bool>
        where Parent : BaseAttachedProperty<Parent, bool>, new()
    {
        public bool FirstLoad { get; set; } = true;

        public override void OnValueUpdated(DependencyObject d, object value)
        {
            if(!(d is FrameworkElement element)) return;

            if(d.GetValue(ValueProperty) == value && !FirstLoad) return;

            if(FirstLoad)
            {
                RoutedEventHandler onLoad = null;
                onLoad = (ss, ee) =>
                {
                    element.Loaded -= onLoad;

                    DoAnimation(element, (bool)value);
                };

                element.Loaded += onLoad;
                FirstLoad = false;
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
}
