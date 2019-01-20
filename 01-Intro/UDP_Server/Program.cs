using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UDP_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            int servPort = 5000;
            UdpClient client = null;

            client = new UdpClient(servPort);

            IPEndPoint remoteIPEndPoint = new IPEndPoint(IPAddress.Any,0);

            for(;;)
            {
                try
                {
                    byte[] byteBuffer = client.Receive(ref remoteIPEndPoint);

                    string recvMessage = Encoding.ASCII.GetString(byteBuffer,0,byteBuffer.Length);
                    //string sendBack = Encoding.ASCII.GetString();
                    Console.WriteLine(recvMessage);
                }
                catch(SocketException e)
                {
                    Console.WriteLine(e.ErrorCode+" "+e.Message);
                    
                }
            }
        }
    }
}
