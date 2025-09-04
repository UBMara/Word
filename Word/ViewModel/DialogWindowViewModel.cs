using Fasetto.Word;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Word.Core.ViewModel;

namespace Word
{ 
    public class DialogWindowViewModel : WindowViewModel
    {
        public string Title { get; set; }
        public Control Content { get; set; }

        public DialogWindowViewModel(Window window) : base(window)
        {
            MinWidth = 250;
            MinHeight = 100;

            TitleHeight = 30;
        }
    }
}
