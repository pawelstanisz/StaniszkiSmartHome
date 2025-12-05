using StaniszkiSmartHome.Views;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace StaniszkiSmartHome
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ViewContent.Content = new StartView(); // Startowy widok

            // Timer do aktualizacji daty i godziny co sekundę
            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
            timer.Tick += (_, _) => TopDateTimeTextBlock.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
            timer.Start();
        }


        public void SwitchView(UserControl view)
        {
            ViewContent.Content = view;
        }


    }
}