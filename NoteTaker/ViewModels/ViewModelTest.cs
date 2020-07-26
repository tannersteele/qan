using System.Windows;
using System.Windows.Input;

namespace NoteTaker
{
    public class ViewModelTest : ViewModelBase
    {
        private string _currentNoteFieldInput;
        public string CurrentNoteFieldInput
        {
            get => _currentNoteFieldInput;
            set => SetProperty(ref _currentNoteFieldInput, value);
        }

        private readonly DelegateCommand _saveNoteCommand;
        public ICommand SaveNoteCommand => _saveNoteCommand;

        public ViewModelTest()
        {
            _saveNoteCommand = new DelegateCommand(OnNoteSaved, CanSaveNote);
        }

        private void OnNoteSaved(object commandParameter)
        {
            //... Note save logic
            MessageBox.Show($"Current input: {CurrentNoteFieldInput}");
        }

        private bool CanSaveNote(object commandParameter)
        {
            return true;
        }
    }
}
