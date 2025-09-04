using System.Windows;
using Word.Core.ViewModel;

namespace Word
{
    public partial class DialogWindow : Window
    { 
        private DialogWindowViewModel _ViewModel;

        public DialogWindowViewModel ViewModel
        {
            get => _ViewModel;
            set 
            {
                _ViewModel = value;
                DataContext = _ViewModel;
            } 
        }
        public DialogWindow()
        {
            InitializeComponent();
            
        }
    }
}