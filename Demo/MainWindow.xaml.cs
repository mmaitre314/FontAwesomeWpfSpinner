using System.Windows;
using System.Windows.Media.Animation;

namespace Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ((Storyboard)FindResource("WaitStoryboard")).Begin();
        }
    }
}
