using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace WpfApplication1
{
    class Server
    {
        public void ReceiveUsername() 
        {
            Socket sock = new Socket(AddressFamily.InterNetwork,
                      SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Any, 8081);
            sock.Bind(iep);
            EndPoint ep = (EndPoint)iep;

            byte[] data = new byte[1024];
            string stringData = Encoding.ASCII.GetString(data);

            data = new byte[1024];
            recv = sock.ReceiveFrom(data, ref ep);
            stringData = Encoding.ASCII.GetString(data, 0, recv);
            Console.WriteLine("received: {0}  from: {1}",
                                  stringData, ep.ToString());
            sock.Close();
 
        }

        public int recv { get; set; }
    }
}
