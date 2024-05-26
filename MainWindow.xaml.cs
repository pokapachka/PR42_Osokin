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

namespace ПР42_Осокин
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow init;
        public View.Main Main = new View.Main();
        public View.Category.Main MainCategorys = new View.Category.Main();

        public MainWindow()
        {
            InitializeComponent();
            init = this;
            frame.Navigate(Main);
        }

        private void OpenIndex(object sender, MouseButtonEventArgs e) => frame.Navigate(Main);
    }
}
