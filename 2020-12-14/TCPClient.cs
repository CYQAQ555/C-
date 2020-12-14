using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TCP_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.SetMinThreads(100, 100);
            ThreadPool.SetMaxThreads(200, 200);

            Parallel.For(1, 10, x =>
            {
                SendData("Tom");
            });

            Console.WriteLine("全部完成");
            Console.ReadKey();
        }

        private static void SendData(string Name)
        {
            Task.Run(() =>
            {
                Console.WriteLine("任务{0}开始", Task.CurrentId);
                TcpClient tcpClient = new TcpClient();
                tcpClient.Connect("192.168.1.138", 9000);
                Console.WriteLine("{0}连接{1}成功",tcpClient.Client.LocalEndPoint.ToString(),tcpClient.Client.RemoteEndPoint.ToString());
                NetworkStream netStream = tcpClient.GetStream();

                Task.Run(() =>
                {
                    Thread.Sleep(100);
                    while (true)
                    {
                        if (!tcpClient.Client.Connected)
                        {
                            break;
                        }

                        if (netStream == null)
                        {
                            break;
                        }

                        try
                        {
                            if (netStream.DataAvailable)
                            {
                                byte[] data = new byte[1024];
                                int len = netStream.Read(data, 0, 1024);
                                var message = Encoding.UTF8.GetString(data, 0, len);
                                Console.WriteLine(message);
                            }
                        }
                        catch
                        {
                            break;
                        }

                        Thread.Sleep(10);
                    }
                });

                for (int i = 0; i < 100; i++)
                {
                    byte[] datas = Encoding.UTF8.GetBytes(Name);
                    int Len = datas.Length;
                    netStream.Write(datas, 0, Len);
                    Thread.Sleep(1000);
                }

                netStream.Close();
                netStream = null;
                tcpClient.Close();

                Console.WriteLine("任务{0}完成",Task.CurrentId);
            });
        }
    }
}