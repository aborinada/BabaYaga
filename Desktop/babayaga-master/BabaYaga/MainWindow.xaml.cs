using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BabaYaga
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            manager.MainFrame = MainFrame;
            MainFrame.Navigate(new ());
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {
            
        }

        private void Button_Click_info(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new отрасль());
        }

        private void Button_Click_siz(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Size());
        }

        private void Button_Click_DengerZone(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Robo());
        }

        private void Button_Click_Search_for_details(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Instrument());
        }

        private void Button_Click_Sorting_by_size(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Color_filtering(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Quality_control(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Assembly_by_barcode(object sender, RoutedEventArgs e)
        {

        }
    }
}
