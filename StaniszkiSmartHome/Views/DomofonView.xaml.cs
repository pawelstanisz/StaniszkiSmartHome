using System.Windows;
using System.Windows.Controls;

namespace StaniszkiSmartHome.Views;

public partial class DomofonView : UserControl
{
    public DomofonView()
    {
        InitializeComponent();
    }

    private void Back_Click(object sender, RoutedEventArgs e)
    {
        ((MainWindow)Application.Current.MainWindow).SwitchView(new StartView());
    }

}