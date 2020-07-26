using SourceChord.FluentWPF;

namespace NoteTaker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : AcrylicWindow
    {
        public MainWindow()
        {
            DataContext = new ViewModelTest();
            InitializeComponent();
        }
    }
}
