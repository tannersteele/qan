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

        public ICommand SaveNoteCommand { get; }
        public ICommand ShowNotesCommand { get;  }

        public ViewModelTest()
        {
            _currentNotes = new List<Note>();
            SaveNoteCommand = new DelegateCommand(SaveNote, CanSaveNote);
            ShowNotesCommand = new DelegateCommand(ShowNotes, CanShowNotes);
        }

        private void SaveNote()
        {
            _currentNotes.Add(new Note
            {
                Content = CurrentNoteFieldInput,
                Timestamp = DateTime.Now
            });
        }

        private bool CanSaveNote() => true;

        private void ShowNotes()
        {
            // Probably not the best way to do this - made a ticket for it
            new NotesViewer(new ObservableCollection<Note>(_currentNotes)).Show();
        }

        private bool CanShowNotes() => true;
    }
}
