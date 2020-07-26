using NoteTaker.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace NoteTaker.ViewModels
{
    public class NotesViewerViewModel : ViewModelBase
    {
        public ObservableCollection<Note> CurrentNotes { get; set; }
    }
}
