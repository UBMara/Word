using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Word.Core.ViewModel;

namespace Word
{
    public class BubbleContentViewModel : BaseViewModel
    {
        public Brush? BubbleBackground { get; set; }
        public Control? Content { get; set; }
        public HorizontalAlignment? ArrowAlignment { get; set; }

        public BubbleContentViewModel()
        {
            BubbleBackground = Application.Current.FindResource("LighterBackgroundBrush") as Brush;
        }
    }
}

