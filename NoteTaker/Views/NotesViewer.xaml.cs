using NoteTaker.Models;
using NoteTaker.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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
