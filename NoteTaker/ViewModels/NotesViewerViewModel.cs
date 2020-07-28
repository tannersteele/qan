using NoteTaker.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NoteTaker.ViewModels
{
    public class NotesViewerViewModel : ViewModelBase
    {
        public ObservableCollection<Note> CurrentNotes { get; set; }

        public NotesViewerViewModel(IEnumerable<Note> notes)
        {
            CurrentNotes = new ObservableCollection<Note>(notes);
        }
    }
}
