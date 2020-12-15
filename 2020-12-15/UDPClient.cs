using System;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace work18
{
    class UDPClient
    {
        static void Main(string[] args)
        {
            UdpClient udpClient = new UdpClient(11000);
            IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, 11000);
            IPEndPoint point = new IPEndPoint(IPAddress.Any, 11000);
            Console.WriteLine("start");
            try
            {
                udpClient.Connect("127.0.0.1", 11000);
                while (true)
                {
                    byte[] datas = Encoding.UTF8.GetBytes("udpClient");
                    int Len = datas.Length;
                    udpClient.Send(datas, Len);

                    byte[] receiveBytes = udpClient.Receive(ref point);
                    string returnData = Encoding.UTF8.GetString(receiveBytes);
                    Console.WriteLine("client " + returnData);
                }

            }
            catch (SocketException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                udpClient.Close();
            }
        }
    }
}

