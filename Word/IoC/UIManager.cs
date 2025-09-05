using Word.Core;
using Word.Core.ViewModel;
using System.Threading.Tasks;

namespace Word
{
    public class UIManager : IUIManager
    {

        public Task ShowMessage(MessageBoxDialogViewModel viewModel)
        {
            return new DialogMessageBox().ShowDialog(viewModel);
        }
    }
}
