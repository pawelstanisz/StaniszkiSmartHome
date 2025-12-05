
using System.Windows;
using System.Windows.Controls;

namespace StaniszkiSmartHome.Views
{
    public partial class StartupView : UserControl
    {
        public StartupView()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).SwitchView(new StartView());
        }
    }
}
