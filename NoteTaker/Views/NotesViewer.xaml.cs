using NoteTaker.Models;
using NoteTaker.ViewModels;
using System.Collections.ObjectModel;
using System.Windows;

namespace NoteTaker.Views
{
    /// <summary>
    /// Interaction logic for NotesViewer.xaml
    /// </summary>
    public partial class NotesViewer : Window
    {
        public NotesViewer(ObservableCollection<Note> activeNotes)
        {
            DataContext = new NotesViewerViewModel()
            {
                CurrentNotes = activeNotes
            };

            InitializeComponent();
        }
    }
}
