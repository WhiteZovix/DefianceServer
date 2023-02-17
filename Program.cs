using System;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using DefianceServer.Thread;
using System.Security.Cryptography.X509Certificates;

namespace DefianceServer
{
    class Program
    {
        public static object username;
        public static object token;
        static void Main(string[] args)
        {

            int port = 50000;
            string IpAddress = "82.165.17.58";
            Socket ServerListener = new Socket(AddressFamily
                .InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(IpAddress), port);
            ServerListener.Bind(ep);
            ServerListener.Listen(100);
            Console.WriteLine("DefianceServer is Listening...");
            Socket ClientSocket = default(Socket);
            int counter = 0;
            while (true)
            {
                counter++;
                ClientSocket = ServerListener.Accept();
                Console.WriteLine(counter + " PLAYER CONNECTING TO THE SERVER: " + IpAddress + username + token);
                ThreadStart UserThread = (new ThreadStart(() => p.User(ClientSocket)));
            }
        }


        private class p
        {


            private static object cl_auth_server; //defiance.exe /cl_auth_server "127.0.0.1"

            private static object client;

            private static object msg;

            internal static void User(Socket client)
            {
                while (true)
                {
                    byte[] msg = new byte[1024];
                    int size = client.Receive(msg);
                    client.Send(msg, 0, size, SocketFlags.None);
                }


                throw new NotImplementedException();
            }
        }
    }
}
