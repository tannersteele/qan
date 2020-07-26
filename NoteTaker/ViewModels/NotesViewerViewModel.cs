using NoteTaker.Models;
using System.Collections.ObjectModel;

namespace NoteTaker.ViewModels
{
    public class NotesViewerViewModel : ViewModelBase
    {
        public ObservableCollection<Note> CurrentNotes { get; set; }
    }
}
