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
            textBox1.Focus();
            textBox1.KeyDown += textBox1_KeyDown;

        }

        void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                button1_Click(sender, e);
            }
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

            if (textBox1.Text.Length != 0 && !textBox1.Text.Equals("Enter Nickname!"))
            {
                templogin = textBox1.Text;
                MainWindow win = new MainWindow();
                win.Show();

                this.Hide();
            }
            textBox1.Text = "Enter Nickname!";
            
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void textBox1_GotFocus(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
        }
       
    }
}
