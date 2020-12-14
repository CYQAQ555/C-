using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TCPServer
{
    class Program
    {  
        static void Main(string[] args)
        {   
            TcpListener tcpListener = new TcpListener(IPAddress.Parse("192.168.1.138"), 9000);
            tcpListener.Start();
            Console.WriteLine("开始监听");   

            while (true)
            {
                if (tcpListener.Pending())
                {
                    TcpClient client = tcpListener.AcceptTcpClient();
                    Console.WriteLine("{0}已连接",client.Client.RemoteEndPoint.ToString());                   

                    Task.Run(() =>
                    {  
                        NetworkStream stream = client.GetStream();
                        var remote = client.Client.RemoteEndPoint;
                      
                        while (true)
                        {
                            if (stream.DataAvailable)
                            {
                                byte[] data = new byte[1024];
                                int len = stream.Read(data, 0, 1024);
                                string Name = Encoding.UTF8.GetString(data,0,len);
                                var senddata = Encoding.UTF8.GetBytes("Hello:" + Name);
                                stream.Write(senddata, 0, senddata.Length);
                            }

                            if (!client.IsOnline())
                            {
                                Console.WriteLine("{0}连接关闭.",remote.ToString());
                                break;
                            }

                            Thread.Sleep(1);
                        }
                    });
                }

                Thread.Sleep(1);
            }
        }
    }

    public static class TcpClientEx
    {
        public static bool IsOnline(this TcpClient client)
        {
            return !((client.Client.Poll(15000, SelectMode.SelectRead) && (client.Client.Available == 0)) || !client.Client.Connected);
        }
    }
}
