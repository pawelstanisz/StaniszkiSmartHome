using System.Windows;
using System.Windows.Controls;

namespace StaniszkiSmartHome.Views;

public partial class KameryView : UserControl
{
    public KameryView()
    {
        InitializeComponent();
    }


    private void Back_Click(object sender, RoutedEventArgs e)
    {
        ((MainWindow)Application.Current.MainWindow).SwitchView(new StartView());
    }

}