using System.Windows;
using System.Windows.Input;

namespace NoteTaker
{
    public class ViewModelTest : ViewModelBase
    {
        private readonly DelegateCommand _saveNoteCommand;
        public ICommand SaveNoteCommand => _saveNoteCommand;

        public ViewModelTest()
        {
            _saveNoteCommand = new DelegateCommand(OnNoteSaved, CanSaveNote);
        }

        private void OnNoteSaved(object commandParameter)
        {
            //... Note save logic
            MessageBox.Show("Note saved!");
        }

        private bool CanSaveNote(object commandParameter)
        {
            //... Check for input, etc..
            return true;
        }
    }
}
