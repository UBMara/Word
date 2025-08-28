using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Word
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged = (sender, e) => {};

        public void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        protected async Task RunCommand(Expression<Func<bool>> updateFlag, Func<Task> action)
        {
            if (updateFlag.Compile().Invoke()) return;

            updateFlag.SetPropertyValue(true);

            try
            {
                await action();
            }
            finally
            {
                updateFlag.SetPropertyValue(false);
            }
        }
    }
}
