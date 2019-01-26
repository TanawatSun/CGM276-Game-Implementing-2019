using System;
using System.Net;
using System.Net.Sockets;
using System.Text;


namespace UDPClient
{
    class Program
    {
        static void Main(string[] args)
        {
           string server = "127.0.0.1"; // loop back address
           int servPort = 5000;

           string message = "Tanawat 5808657";

           byte[] sendPacket = Encoding.ASCII.GetBytes(message);

           UdpClient client = new UdpClient();

           try
           {
               client.Send(sendPacket,sendPacket.Length,server,servPort);
           }
           catch(SocketException e)
           {
               Console.WriteLine(e.ErrorCode+""+e.Message);
           }
        }
    }
}
