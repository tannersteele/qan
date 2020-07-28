using NoteTaker.Models;
using NoteTaker.ViewModels;
using System.Collections.Generic;
using System.Windows;

namespace NoteTaker.Views
{
    /// <summary>
    /// Interaction logic for NotesViewer.xaml
    /// </summary>
    public partial class NotesViewer : Window
    {
        public NotesViewer(IEnumerable<Note> activeNotes)
        {
            DataContext = new NotesViewerViewModel(activeNotes);
            InitializeComponent();
        }
    }
}
