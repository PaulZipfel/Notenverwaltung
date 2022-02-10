using System;
using System.Windows;
using System.Windows.Input;

namespace Notenverwaltung
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lblSchliessen.MouseLeftButtonDown += (sender, e) => this.Close();
            lblMinimieren.MouseLeftButtonDown += (sender, e) => this.WindowState = WindowState.Minimized;
        }
    }
}
