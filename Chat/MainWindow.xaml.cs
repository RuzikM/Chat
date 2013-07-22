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
        List<Clients> userlist = new List<Clients>();
        string databaseName = @"data.db";

        public MainWindow()
        {

            InitializeComponent();
            login obj = new login();
            listBox1.Items.Add(login.templogin);

            Clients client = new Clients();
            client.SendName(login.templogin); // send login trough UDP

            
        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Server server = new Server();

            Thread listenmsg = new Thread(() => server.GetMessage(ref msg));
            listenmsg.Start();
        }
        
        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void listBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
           
               
            
           
           
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
             Clients client = new Clients();
             
             
             try {
                 string message = login.templogin + ":" + " " + textBox1.Text;
                 string sendmsg = "*"+listBox1.SelectedItem.ToString()+"*";
                 client.SendMessage(sendmsg + message); //sending message trough UDP}
                 listBox2.Items.Add(message);
                 textBox1.Text = "";
             }
             catch { }
             
 
        }

        public string msg = "";
        public string usr = "";


        private void Window_TargetUpdated(object sender, DataTransferEventArgs e)
        {
            

        }

        private void Window_GotFocus(object sender, RoutedEventArgs e)
        {
            

        }

        private void msg_Updated(object sender, DataTransferEventArgs e)
        {
            listBox2.Items.Add(msg);
            if (msg.StartsWith("*us*"))
            {

                listBox1.Items.Add(msg.Substring(4));
            }   
        }

   }
}
