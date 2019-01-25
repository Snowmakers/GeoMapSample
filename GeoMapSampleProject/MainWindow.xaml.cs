using System.IO;
using System.Windows;

namespace GeoMapSampleProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var path = Directory.GetCurrentDirectory();

            DataContext = new MainWindowViewModel(path);
            GeoMap.BackgroundContent = new LocalMapImagery(path);
            GeoMap.WorldRect = new Rect(8.3713675, 46.7982968, 0.0119369, 0.0081759);
        }
    }
}
