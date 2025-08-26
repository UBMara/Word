using Fasetto.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Input;
using Word.Models;

namespace Word.ViewModel
{
    public class WindowViewModel : BaseViewModel
    {
        private Window _window;

        private int _outerMarginSize = 10;
        private int _windowRadius = 10;
       

        public double MinWidth { get; set; } = 400;
        public double MinHeight { get; set; } = 400;

        public ICommand MinCommand { get; set; }
        public ICommand MaxCommand { get; set; }
        public ICommand CloseCommand { get; set; }
        public ICommand MenuCommand {  get; set; }

         private WindowDockPosition _dockPosition = WindowDockPosition.Undocked;
        public int ResizeBorder { get { return Borderless ? 0 : 6; } }

        public Thickness ResizeBorderThick { get { return new Thickness(ResizeBorder + OuterMarginSize); } }
        public bool Borderless { get { return (_window.WindowState == WindowState.Maximized || _dockPosition != WindowDockPosition.Undocked); } }


        public Thickness InnerPadding { get { return new Thickness(ResizeBorder); } }
        public int OuterMarginSize
        {
            get
            {
                return _window.WindowState == WindowState.Maximized ? 0 : _outerMarginSize;
            }
            set
            {
                _outerMarginSize = value;
            }
        }

        public Thickness OuterMarginSizeThick { get { return new Thickness(OuterMarginSize); } }

        public int WindowRadius
        {
            get
            {
                return _window.WindowState == WindowState.Maximized ? 0 : _windowRadius;
            }
            set
            {
                _windowRadius = value;
            }
        }

        public CornerRadius CornerRadius { get { return new CornerRadius(WindowRadius); } }

        public int TitleHeight { get; set; } = 42;

        public GridLength TitleHeightLength { get { return new GridLength(TitleHeight + ResizeBorder); } }

        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Login;
        public WindowViewModel(Window window)
        {
            _window = window;
            _window.StateChanged += (sender, e) =>
            {
                OnPropertyChanged(nameof(ResizeBorderThick));
                OnPropertyChanged(nameof(OuterMarginSize));
                OnPropertyChanged(nameof(OuterMarginSizeThick));
                OnPropertyChanged(nameof(WindowRadius));
                OnPropertyChanged(nameof(CornerRadius));
            };

            MinCommand = new RelayCommand(() => _window.WindowState = WindowState.Minimized);
            MaxCommand = new RelayCommand(() => _window.WindowState ^= WindowState.Maximized);
            CloseCommand = new RelayCommand(() => _window?.Close());
            MenuCommand = new RelayCommand(() => SystemCommands.ShowSystemMenu(_window, GetMousePosition()));

            var resize = new WindowResizer(_window);

        }

        private Point GetMousePosition()
        {
            var position = Mouse.GetPosition(_window);

            return new Point(position.X + _window.Left, position.Y + _window.Top);
        }

        
    }
}
