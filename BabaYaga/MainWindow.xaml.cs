﻿using System;
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
        }

        private void Bth_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new отрасль());
            // Manager.MainFrame = MainFrame;
        }
        private void BtnInstr_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Instrument());
        }

        private void Instrument(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new BabaYaga.Robo());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new BabaYaga.Instrument());
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
