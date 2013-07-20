using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
namespace WpfApplication1
{
    class Clients
    {
        public string name { get; set; }

        public void SendName(string name)
        {
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint iep1 = new IPEndPoint(IPAddress.Broadcast, 8101);
            IPEndPoint iep2 = new IPEndPoint(IPAddress.Parse("192.168.1.255"), 8101);

            string username =name ;
            byte[] data = Encoding.ASCII.GetBytes("*us*"+username);

            sock.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, 1);
            sock.SendTo(data, iep1);
            sock.SendTo(data, iep2);
            sock.Close();
        }
         
        public void SendMessage(string message)
        {
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint iep1 = new IPEndPoint(IPAddress.Broadcast, 8101);
            IPEndPoint iep2 = new IPEndPoint(IPAddress.Parse("192.168.1.255"), 8101);

            string msg = message;
            byte[] data = Encoding.ASCII.GetBytes(msg);

            sock.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, 1);
            sock.SendTo(data, iep1);
            sock.SendTo(data, iep2);
            sock.Close();
        }
    }
}
