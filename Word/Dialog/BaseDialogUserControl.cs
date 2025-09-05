using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Word.Core.ViewModel;

namespace Word
{
    public class BaseDialogUserControl : UserControl
    {
        private DialogWindow _DialogWindow;

        public ICommand CloseCommand { get; private set; }

        public int MinWidth { get; set; } = 250;
        public int MinHeight { get; set; } = 100;

        public int TitleHeight { get; set; } = 30;

        public string Title { get; set; }

        public BaseDialogUserControl()
        {
            if (!DesignerProperties.GetIsInDesignMode(this))
            {
                _DialogWindow = new DialogWindow();
                _DialogWindow.ViewModel = new DialogWindowViewModel(_DialogWindow);

                CloseCommand = new RelayCommand(() => _DialogWindow.Close());
            }
        }

        public Task ShowDialog<T>(T viewModel)
            where T : BaseViewModel
        {
            var tcs = new TaskCompletionSource<bool>();

            Application.Current.Dispatcher.Invoke(() =>
            {
                try
                {
                    _DialogWindow.ViewModel.MinWidth = MinWidth;
                    _DialogWindow.ViewModel.MinHeight = MinHeight;
                    _DialogWindow.ViewModel.TitleHeight = TitleHeight;
                    _DialogWindow.ViewModel.Title = Title;

                    _DialogWindow.ViewModel.Content = this;

                    DataContext = viewModel;

                    _DialogWindow.ShowDialog();
                }
                finally
                {
                    tcs.TrySetResult(true);
                }
            });

            return tcs.Task;
        }
    }
}
