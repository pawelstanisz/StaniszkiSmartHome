
using System.Windows;
using System.Windows.Controls;

namespace StaniszkiSmartHome.Views
{
    public partial class StartView : UserControl
    {
        public StartView()
        {
            InitializeComponent();
        }

        private void Alarm_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).SwitchView(new AlarmView());
        }

        private void Domofon_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).SwitchView(new DomofonView());
        }

        private void Kamery_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).SwitchView(new KameryView());
        }

        private void Oswietlenie_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).SwitchView(new OswietlenieView());
        }

        private void Rolety_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).SwitchView(new RoletyView());
        }

        private void Temperatura_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).SwitchView(new TemperaturaView());
        }
    }
}
