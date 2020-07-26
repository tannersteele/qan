using NoteTaker.Models;
using NoteTaker.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace NoteTaker
{
    public class ViewModelTest : ViewModelBase
    {
        private readonly IList<Note> _currentNotes;

        private string _currentNoteFieldInput;
        public string CurrentNoteFieldInput
        {
            get => _currentNoteFieldInput;
            set => SetProperty(ref _currentNoteFieldInput, value);
        }

        private readonly DelegateCommand _saveNoteCommand;
        public ICommand SaveNoteCommand => _saveNoteCommand;

        private readonly DelegateCommand _showNotesCommand;
        public ICommand ShowNotesCommand => _showNotesCommand;

        public ViewModelTest()
        {
            _currentNotes = new List<Note>();
            _saveNoteCommand = new DelegateCommand(OnNoteSaved, CanSaveNote);
            _showNotesCommand = new DelegateCommand(OnShowNotes, CanShowNotes);
        }

        private void OnNoteSaved(object commandParameter)
        {
            _currentNotes.Add(new Note
            {
                Content = CurrentNoteFieldInput,
                Timestamp = DateTime.Now
            });
        }

        private bool CanSaveNote(object commandParameter) => true;

        private void OnShowNotes(object commandParameter)
        {
            // Probably not the best way to do this - made a ticket for it
            new NotesViewer(new ObservableCollection<Note>(_currentNotes)).Show();
        }

        private bool CanShowNotes(object commandParameter) => true;
    }
}
