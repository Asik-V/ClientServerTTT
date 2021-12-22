using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8000);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(ip);

            try
            {
                while (true)
                {
                    Console.Clear();
                    StringBuilder builder = new StringBuilder();
                    byte[] bytes = new byte[256];
                    int count;
                    do
                    {
                        count = socket.Receive(bytes);
                        builder.Append(Encoding.UTF8.GetString(bytes, 0, count));
                    } while (socket.Available > 0);

                    if (builder.Length != 0)
                    {
                        Console.WriteLine(builder);
                    }
                    if (builder.ToString() == "Крестики победили!" || builder.ToString() == "Нолики победили!" || builder.ToString() == "Ничья!")
                    {
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Вы играете за X. Ваш ход");
                        socket.Send(Encoding.UTF8.GetBytes(Console.ReadLine()));
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            socket.Close();
        }
    }
}
