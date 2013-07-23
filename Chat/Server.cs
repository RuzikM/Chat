using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace WpfApplication1
{
     class MsgChangedEventArgs : EventArgs
     {
        private string mem;
        public string Mem
        {
            get { return mem; }
        }
        public MsgChangedEventArgs(string mem)
        {
            this.mem = mem;
        }
    }
    class EventClass
    {
       
    }
    class Server
    {
       
        public void GetMessage()
        {
            IPEndPoint e = new IPEndPoint(IPAddress.Any, 8101);
            UdpClient u = new UdpClient(e);

            UdpState s = new UdpState();
            s.e = e;
            s.u = u;

            Console.WriteLine("listening for messages");
            u.BeginReceive(new AsyncCallback(ReceiveCallback), s);
        }
        public void ReceiveCallback(IAsyncResult ar)
        {
            UdpClient u = (UdpClient)((UdpState)(ar.AsyncState)).u;
            IPEndPoint e = (IPEndPoint)((UdpState)(ar.AsyncState)).e;

            Byte[] receiveBytes = u.EndReceive(ar, ref e);
            string receiveString = Encoding.ASCII.GetString(receiveBytes);
            UdpState s = new UdpState();
            s.e = e;
            s.u = u;
            u.BeginReceive(new AsyncCallback(ReceiveCallback), s);
            OnMsgChanged(new MsgChangedEventArgs(receiveString));
          
        }

      
       public event System.EventHandler<MsgChangedEventArgs> MsgChanged;
        public virtual void OnMsgChanged(MsgChangedEventArgs e)
        {
            if (MsgChanged != null)
            {
                MsgChanged(this, e);
            }
        }
    }
}









