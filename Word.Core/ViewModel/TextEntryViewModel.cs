using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Word.Core.ViewModel
{
    public class TextEntryViewModel : BaseViewModel
    {
        public string Label { get; set; }
        public string OriginalText { get; set; }
        public string EditedText { get; set; }
        public bool Editing { get; set; }

        public ICommand EditCommand { get; set; }
        public ICommand CancelCommand { get; set; }
        public ICommand SaveCommand { get; set; }

        public TextEntryViewModel()
        {
            EditCommand = new RelayCommand(Edit);
            CancelCommand = new RelayCommand(Cancel);
            SaveCommand = new RelayCommand(Save);
        }

        private void Save()
        {
            OriginalText = EditedText;
            Editing = false;
        }

        private void Cancel()
        {
            Editing = false;
        }

        public void Edit()
        {
            EditedText = OriginalText;
            Editing = true;
        }
    }
}
