﻿using System;
using System.Collections.Generic;
using System.IO;
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

namespace liananeshariit
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            mi_open.Background = Brushes.LightCoral;
        }
        private void info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Лялляя", "Разработчик: Лиана", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Changee_Click(object sender, RoutedEventArgs e)
        {
            string colorName = (sender as MenuItem)?.Tag?.ToString() ?? (sender as Button)?.Tag?.ToString();
            if (!string.IsNullOrEmpty(colorName))
            {
                this.Background = (System.Windows.Media.Brush)new System.Windows.Media.SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString(colorName));
            }
        }
    }
}
