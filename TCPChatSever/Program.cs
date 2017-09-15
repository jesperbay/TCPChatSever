using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCPChatSever
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener severSocket = new TcpListener(6789);
            severSocket.Start();
            Console.WriteLine("Sever started");

          TcpClient connectSocket =  severSocket.AcceptTcpClient();

        }
    }
}
