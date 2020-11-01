using System;
using System.Net;
using System.Net.Sockets;

namespace EtherionHTTPServer
{

    class Program
    {
        const int MAX_CONNECTIONS = 5;

        static void Main(string[] args)
        {
            Socket socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endPoint = new IPEndPoint(System.Net.IPAddress.Parse("127.0.0.1"), 6789);

            socket.Bind(endPoint);
            socket.Listen(MAX_CONNECTIONS);


            Socket connection = socket.Accept();

            Console.ReadLine();
        }
    }
}
