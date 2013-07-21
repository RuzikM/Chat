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

        public void GetMessage(ref string a)
        {

            UdpClient listener = new UdpClient(8101);
            IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, 8101);
            while (true)
            {
                byte[] bytes = listener.Receive(ref groupEP);
                a = Encoding.UTF8.GetString(bytes);



            }
        }

      
            
           




        


    }
}

