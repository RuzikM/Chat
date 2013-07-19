using System;
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
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Window
    {
        
        public login()
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void image1_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void image1_ImageFailed_1(object sender, ExceptionRoutedEventArgs e)
        {

        }
        public static string templogin;
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            templogin = textBox1.Text;
            MainWindow win = new MainWindow();
            win.Show();

            this.Hide();
            
        }
    }
}
