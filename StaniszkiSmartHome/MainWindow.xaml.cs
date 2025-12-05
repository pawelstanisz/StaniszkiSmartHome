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

            ViewContent.Content = new StartupView(); // Startowy widok

            // Timer do aktualizacji daty i godziny co sekundę
            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
            timer.Tick += (_, _) => TopDateTimeTextBlock.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
            timer.Start();
        }

        // Metoda do przełączania widoków
        public void SwitchView(UserControl view)
        {
            ViewContent.Content = view;
        }

        // Wyświetlanie widoku startowego po kliknięciu TextLogo w górnej belce
        private void TextLogo_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {   
            SwitchView(new StartupView());  // Przełącz na widok startowy
        }



    }
}