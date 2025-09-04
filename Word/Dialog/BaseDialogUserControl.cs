using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.DataContracts;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Word.Core.ViewModel;

namespace Word.Core
{
    public class BaseDialogUserControl
    {
        private DialogWindow _DialogWindow;

        public ICommand CloseCommand { get; private set; }

        public int MinWidth { get; set; } = 250;
        public int MinHeight { get; set; } = 100;

        public int TitleHeight { get; set; } = 30;

        public string Title { get; set; }

        public BaseDialogUserControl()
        {
            _DialogWindow = new DialogWindow();
            _DialogWindow.ViewModel = new DialogWindowViewModel(_DialogWindow);

        }

        public Task ShowDialog<T>(T viewModel)
            where T : BaseViewModel
        {
            var tcs = new TaskCompletionSource<bool>();

            Application.Current.Dispatcher.Invoke(() =>
            {
                try
                {
                    _DialogWindow.ViewModel.MinWidth = MinHeight;
                    _DialogWindow.ViewModel.MinHeight = MinWidth;
                    _DialogWindow.ViewModel.TitleHeight = TitleHeight;
                    _DialogWindow.ViewModel.Title = Title;

                    //DataContext = viewModel;

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
