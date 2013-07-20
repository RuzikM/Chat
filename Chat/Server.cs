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
        public string ReceiveUsername() 
        {
            Socket sock = new Socket(AddressFamily.InterNetwork,
                      SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Any, 8081);
            sock.Bind(iep);
            EndPoint ep = (EndPoint)iep;

            
                
                byte[] zdata = new byte[1024];
                int recv = sock.ReceiveFrom(zdata, ref ep);
                string stringData = Encoding.ASCII.GetString(zdata);

                return stringData;
            
          
            
 
        }

        public int recv { get; set; }
    }
}
