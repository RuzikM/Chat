﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net.Sockets;
//using System.Collections.Generic;
using System.ComponentModel;
//using System.Net.Sockets;
using System.IO;
using System.Threading;



namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<user> userlist = new List<user>();
        public MainWindow()
        {
           
            InitializeComponent();
            login obj = new login();
            string text = obj.text ;
            listBox1.Items.Add(text);

            listBox1.Foreground = new SolidColorBrush(Colors.White);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {


        }
        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void listBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
