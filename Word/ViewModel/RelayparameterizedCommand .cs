using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Word
{
    public class RelayparameterizedCommand : ICommand
    {
        private Action<object> _Action;


        public event EventHandler? CanExecuteChanged = (sender, e) => { };

        public bool CanExecute(object parameter)  => true;

        public RelayparameterizedCommand(Action<object> action) { _Action = action; }


        public void Execute(object parameter)
        {
            _Action(parameter);
        }
    }
}
