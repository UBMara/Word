using System.Windows;
using Word.Core.ViewModel;

namespace Word
{
    public partial class MainWindow : Window
    { 
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new WindowViewModel(this);
        }
    }
}