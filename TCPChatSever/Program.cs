using System;
using System.Collections.Generic;
using System.IO;
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
            Console.WriteLine("Server arktiveret");

            Stream ns = connectSocket.GetStream();

            while (true)
            {
                StreamReader sr = new StreamReader(ns);

                StreamWriter sw = new StreamWriter(ns);
                sw.AutoFlush = true;

                string memessage = Console.ReadLine();
                sw.WriteLine(memessage);

                string message = sr.ReadLine();
                Console.WriteLine("clit " + message);

                string s = Console.ReadLine();
                if (s == "end")
                {
                    sr.Close();
                    sw.Close();
                    ns.Close();
                    Environment.Exit(0);
                }

            }

           

        }
    }
}
