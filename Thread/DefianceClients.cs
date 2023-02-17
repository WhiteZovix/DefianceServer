using MySql.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DefianceServer.Thread
{
    class Theater
    {
        public TheaterServer ParentServer { get; set; }
        public uint ID { get; set; }
        public ClientType ClientType { get; set; }
        public Socket ClientSocket { get; private set; }
        public string logon { get; set; }
        public nickname Nickname { get; set; }
        public DefianceServer Defiance { get; set; }

        private readonly string Identifier;
        private readonly AsyncCallback ClientReadCallback;
        private object sock;
        private TheaterServer parent;

        public Username Username { get; set; }
        public string token { get; set; }
        private byte[] TempBuffer { get; set; }
        public Theater(Socket sock, ClientType clienttype, TheaterServer parent)
        {
            Username = new Username();
            Defiance = new DefianceServer();
            Identifier = sock.ToString();
            ClientType = clienttype;
            ParentServer = parent;
            try
            {
                Console.WriteLine("[Theater][" + ClientType.ToString() + " - " + Identifier + "] Connected from " + ClientSocket.RemoteEndPoint.ToString());
            }
            catch (Exception ex)
            {
                Disconnect();
            }
        }

        private void Disconnect()
        {
            throw new NotImplementedException();
        }
    }
}