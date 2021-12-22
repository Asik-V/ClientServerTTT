using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    class Program
    {

        static bool isCorrectChoise(char arr)
        {
            if (arr == ' ')
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        static void Move(char[] arr, Socket user)
        {
            Console.WriteLine("Вы играете за 0. Ваш ход");
            string choise;
            switch (choise = Console.ReadLine())
            {
                case "1A":
                    if (isCorrectChoise(arr[10]))
                    {
                        arr[10] = '0';
                        if (isWin(arr, '0') == 0)
                        {
                            Console.WriteLine("Нолики победили!");
                            user.Send(Encoding.UTF8.GetBytes("Нолики победили!"));
                            break;
                        }
                        else if (isWin(arr, '0') == 1)
                        {
                            Console.WriteLine("Ничья!");
                            user.Send(Encoding.UTF8.GetBytes("Ничья!"));
                            break;
                        }
                        else
                        {
                            user.Send(Encoding.UTF8.GetBytes(arr));
                        }
                    }
                    else
                    {
                        Console.WriteLine("Эта ячейка занята");
                        Move(arr, user);
                    }
                    break;

                case "1B":
                    if (isCorrectChoise(arr[12]))
                    {
                        arr[12] = '0';
                        if (isWin(arr, '0') == 0)
                        {
                            Console.WriteLine("Нолики победили!");
                            user.Send(Encoding.UTF8.GetBytes("Нолики победили!"));
                            break;
                        }
                        else if (isWin(arr, '0') == 1)
                        {
                            Console.WriteLine("Ничья!");
                            user.Send(Encoding.UTF8.GetBytes("Ничья!"));
                            break;
                        }
                        else
                        {
                            user.Send(Encoding.UTF8.GetBytes(arr));
                        }
                    }
                    else
                    {
                        Console.WriteLine("Эта ячейка занята");
                        Move(arr, user);
                    }
                    break;
                case "1C":
                    if (isCorrectChoise(arr[14]))
                    {
                        arr[14] = '0';
                        if (isWin(arr, '0') == 0)
                        {
                            Console.WriteLine("Нолики победили!");
                            user.Send(Encoding.UTF8.GetBytes("Нолики победили!"));
                            break;
                        }
                        else if (isWin(arr, '0') == 1)
                        {
                            Console.WriteLine("Ничья!");
                            user.Send(Encoding.UTF8.GetBytes("Ничья!"));
                            break;
                        }
                        else
                        {
                            user.Send(Encoding.UTF8.GetBytes(arr));
                        }
                    }
                    else
                    {
                        Console.WriteLine("Эта ячейка занята");
                        Move(arr, user);
                    }
                    break;

                case "2A":
                    if (isCorrectChoise(arr[26]))
                    {
                        arr[26] = '0';
                        if (isWin(arr, '0') == 0)
                        {
                            Console.WriteLine("Нолики победили!");
                            user.Send(Encoding.UTF8.GetBytes("Нолики победили!"));
                            break;
                        }
                        else if (isWin(arr, '0') == 1)
                        {
                            Console.WriteLine("Ничья!");
                            user.Send(Encoding.UTF8.GetBytes("Ничья!"));
                            break;
                        }
                        else
                        {
                            user.Send(Encoding.UTF8.GetBytes(arr));
                        }
                    }
                    else
                    {
                        Console.WriteLine("Эта ячейка занята");
                        Move(arr, user);
                    }

                    break;
                case "2B":
                    if (isCorrectChoise(arr[28]))
                    {
                        arr[28] = '0';
                        if (isWin(arr, '0') == 0)
                        {
                            Console.WriteLine("Нолики победили!");
                            user.Send(Encoding.UTF8.GetBytes("Нолики победили!"));
                            break;
                        }
                        else if (isWin(arr, '0') == 1)
                        {
                            Console.WriteLine("Ничья!");
                            user.Send(Encoding.UTF8.GetBytes("Ничья!"));
                            break;
                        }
                        else
                        {
                            user.Send(Encoding.UTF8.GetBytes(arr));
                        }
                    }
                    else
                    {
                        Console.WriteLine("Эта ячейка занята");
                        Move(arr, user);
                    }
                    break;
                case "2C":
                    if (isCorrectChoise(arr[30]))
                    {
                        arr[30] = '0';
                        if (isWin(arr, '0') == 0)
                        {
                            Console.WriteLine("Нолики победили!");
                            user.Send(Encoding.UTF8.GetBytes("Нолики победили!"));
                            break;
                        }
                        else if (isWin(arr, '0') == 1)
                        {
                            Console.WriteLine("Ничья!");
                            user.Send(Encoding.UTF8.GetBytes("Ничья!"));
                            break;
                        }
                        else
                        {
                            user.Send(Encoding.UTF8.GetBytes(arr));
                        }
                    }
                    else
                    {
                        Console.WriteLine("Эта ячейка занята");
                        Move(arr, user);
                    }
                    break;

                case "3A":
                    if (isCorrectChoise(arr[42]))
                    {
                        arr[42] = '0';
                        if (isWin(arr, '0') == 0)
                        {
                            Console.WriteLine("Нолики победили!");
                            user.Send(Encoding.UTF8.GetBytes("Нолики победили!"));
                            break;
                        }
                        else if (isWin(arr, '0') == 1)
                        {
                            Console.WriteLine("Ничья!");
                            user.Send(Encoding.UTF8.GetBytes("Ничья!"));
                            break;
                        }
                        else
                        {
                            user.Send(Encoding.UTF8.GetBytes(arr));
                        }
                    }
                    else
                    {
                        Console.WriteLine("Эта ячейка занята");
                        Move(arr, user);
                    }
                    break;

                case "3B":
                    if (isCorrectChoise(arr[44]))
                    {
                        arr[44] = '0';
                        if (isWin(arr, '0') == 0)
                        {
                            Console.WriteLine("Нолики победили!");
                            user.Send(Encoding.UTF8.GetBytes("Нолики победили!"));
                            break;
                        }
                        else if (isWin(arr, '0') == 1)
                        {
                            Console.WriteLine("Ничья!");
                            user.Send(Encoding.UTF8.GetBytes("Ничья!"));
                            break;
                        }
                        else
                        {
                            user.Send(Encoding.UTF8.GetBytes(arr));
                        }
                    }
                    else
                    {
                        Console.WriteLine("Эта ячейка занята");
                        Move(arr, user);
                    }
                    break;

                case "3C":
                    if (isCorrectChoise(arr[46]))
                    {
                        arr[46] = '0';
                        if (isWin(arr, '0') == 0)
                        {
                            Console.WriteLine("Нолики победили!");
                            user.Send(Encoding.UTF8.GetBytes("Нолики победили!"));
                            break;
                        }
                        else if (isWin(arr, '0') == 1)
                        {
                            Console.WriteLine("Ничья!");
                            user.Send(Encoding.UTF8.GetBytes("Ничья!"));
                            break;
                        }
                        else
                        {
                            user.Send(Encoding.UTF8.GetBytes(arr));
                        }
                    }
                    else
                    {
                        Console.WriteLine("Эта ячейка занята");
                        Move(arr, user);
                    }
                    break;

                default:
                    {
                        Console.WriteLine("Неверное значение");
                        Move(arr, user);
                    }
                    break;
            }
        }



        static int isWin(char[] arr, char symbol)
        {
            if ((arr[10] == symbol && arr[12] == symbol && arr[14] == symbol) ||
                (arr[26] == symbol && arr[28] == symbol && arr[30] == symbol) ||
                (arr[42] == symbol && arr[44] == symbol && arr[46] == symbol) ||
                (arr[10] == symbol && arr[26] == symbol && arr[42] == symbol) ||
                (arr[12] == symbol && arr[28] == symbol && arr[44] == symbol) ||
                (arr[14] == symbol && arr[30] == symbol && arr[46] == symbol) ||
                (arr[10] == symbol && arr[28] == symbol && arr[46] == symbol) ||
                (arr[14] == symbol && arr[28] == symbol && arr[42] == symbol))
            {
                return 0;
            }
            else if ((arr[10] != ' ' && arr[12] != ' ' && arr[14] != ' ') &&
                (arr[26] != ' ' && arr[28] != ' ' && arr[30] != ' ') &&
                (arr[42] != ' ' && arr[44] != ' ' && arr[46] != ' ') &&
                (arr[10] != ' ' && arr[26] != ' ' && arr[42] != ' ') &&
                (arr[12] != ' ' && arr[28] != ' ' && arr[44] != ' ') &&
                (arr[14] != ' ' && arr[30] != ' ' && arr[46] != ' ') &&
                (arr[10] != ' ' && arr[28] != ' ' && arr[46] != ' ') &&
                (arr[14] != ' ' && arr[28] != ' ' && arr[42] != ' '))
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }



        static void Main(string[] args)
        {
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8000);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(ip);
            socket.Listen(10);
            Console.WriteLine("Server started");
            Socket user = socket.Accept();

            while (true)
            {

                try
                {
                    int a;
                    char[] arr = {
                     ' ',' ','A',' ','B',' ','C', '\n',
                     '1',' ',' ','|',' ','|',' ', '\n',
                     ' ',' ','-','|','-','|','-', '\n',
                     '2',' ',' ','|',' ','|',' ', '\n',
                     ' ',' ','-','|','-','|','-', '\n',
                     '3',' ',' ','|',' ','|',' ', '\n',
                    };

                    user.Send(Encoding.UTF8.GetBytes(arr));

                    while (true)
                    {
                        Console.Clear();
                        StringBuilder builder = new StringBuilder();
                        byte[] bytes = new byte[256];
                        int count;
                        do
                        {
                            count = user.Receive(bytes);
                            builder.Append(Encoding.UTF8.GetString(bytes, 0, count));
                        } while (user.Available > 0);

                        if (builder.Length != 0)
                        {
                            Console.WriteLine(builder);
                        }
                        switch (builder.ToString())
                        {
                            case "1A":
                                if (isCorrectChoise(arr[10]))
                                {
                                    arr[10] = 'X';
                                    if (isWin(arr, 'X') == 0)
                                    {
                                        Console.WriteLine("Крестики победили!");
                                        user.Send(Encoding.UTF8.GetBytes("Крестики победили!"));
                                        break;
                                    }
                                    else if (isWin(arr, 'X') == 1)
                                    {
                                        Console.WriteLine("Ничья!");
                                        user.Send(Encoding.UTF8.GetBytes("Ничья!"));
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(arr);
                                        Move(arr, user);

                                    }
                                }
                                else
                                {
                                    user.Send(Encoding.UTF8.GetBytes(arr));
                                    user.Send(Encoding.UTF8.GetBytes("Эта ячейка занята"));
                                }
                                break;
                            case "1B":
                                if (isCorrectChoise(arr[12]))
                                {
                                    arr[12] = 'X';
                                    if (isWin(arr, 'X') == 0)
                                    {
                                        Console.WriteLine("Крестики победили!");
                                        user.Send(Encoding.UTF8.GetBytes("Крестики победили!"));
                                        break;
                                    }
                                    else if (isWin(arr, 'X') == 1)
                                    {
                                        Console.WriteLine("Ничья!");
                                        user.Send(Encoding.UTF8.GetBytes("Ничья!"));
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(arr);
                                        Move(arr, user);

                                    }
                                }
                                else
                                {
                                    user.Send(Encoding.UTF8.GetBytes(arr));
                                    user.Send(Encoding.UTF8.GetBytes("Эта ячейка занята"));
                                }
                                break;
                            case "1C":
                                if (isCorrectChoise(arr[14]))
                                {
                                    arr[14] = 'X';
                                    if (isWin(arr, 'X') == 0)
                                    {
                                        Console.WriteLine("Крестики победили!");
                                        user.Send(Encoding.UTF8.GetBytes("Крестики победили!"));
                                        break;
                                    }
                                    else if (isWin(arr, 'X') == 1)
                                    {
                                        Console.WriteLine("Ничья!");
                                        user.Send(Encoding.UTF8.GetBytes("Ничья!"));
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(arr);
                                        Move(arr, user);

                                    }
                                }
                                else
                                {
                                    user.Send(Encoding.UTF8.GetBytes(arr));
                                    user.Send(Encoding.UTF8.GetBytes("Эта ячейка занята"));
                                }
                                break;
                            case "2A":
                                if (isCorrectChoise(arr[26]))
                                {
                                    arr[26] = 'X';
                                    if (isWin(arr, 'X') == 0)
                                    {
                                        Console.WriteLine("Крестики победили!");
                                        user.Send(Encoding.UTF8.GetBytes("Крестики победили!"));
                                        break;
                                    }
                                    else if (isWin(arr, 'X') == 1)
                                    {
                                        Console.WriteLine("Ничья!");
                                        user.Send(Encoding.UTF8.GetBytes("Ничья!"));
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(arr);
                                        Move(arr, user);
                                    }
                                }
                                else
                                {
                                    user.Send(Encoding.UTF8.GetBytes(arr));
                                    user.Send(Encoding.UTF8.GetBytes("Эта ячейка занята"));
                                }
                                break;
                            case "2B":
                                if (isCorrectChoise(arr[28]))
                                {
                                    arr[28] = 'X';
                                    if (isWin(arr, 'X') == 0)
                                    {
                                        Console.WriteLine("Крестики победили!");
                                        user.Send(Encoding.UTF8.GetBytes("Крестики победили!"));
                                        break;
                                    }
                                    else if (isWin(arr, 'X') == 1)
                                    {
                                        Console.WriteLine("Ничья!");
                                        user.Send(Encoding.UTF8.GetBytes("Ничья!"));
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(arr);
                                        Move(arr, user);

                                    }
                                }
                                else
                                {
                                    user.Send(Encoding.UTF8.GetBytes(arr));
                                    user.Send(Encoding.UTF8.GetBytes("Эта ячейка занята"));
                                }
                                break;
                            case "2C":
                                if (isCorrectChoise(arr[30]))
                                {
                                    arr[30] = 'X';
                                    if (isWin(arr, 'X') == 0)
                                    {
                                        Console.WriteLine("Крестики победили!");
                                        user.Send(Encoding.UTF8.GetBytes("Крестики победили!"));
                                        break;
                                    }
                                    else if (isWin(arr, 'X') == 1)
                                    {
                                        Console.WriteLine("Ничья!");
                                        user.Send(Encoding.UTF8.GetBytes("Ничья!"));
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(arr);
                                        Move(arr, user);

                                    }
                                }
                                else
                                {
                                    user.Send(Encoding.UTF8.GetBytes(arr));
                                    user.Send(Encoding.UTF8.GetBytes("Эта ячейка занята"));
                                }
                                break;
                            case "3A":
                                if (isCorrectChoise(arr[42]))
                                {
                                    arr[42] = 'X';
                                    if (isWin(arr, 'X') == 0)
                                    {
                                        Console.WriteLine("Крестики победили!");
                                        user.Send(Encoding.UTF8.GetBytes("Крестики победили!"));
                                        break;
                                    }
                                    else if (isWin(arr, 'X') == 1)
                                    {
                                        Console.WriteLine("Ничья!");
                                        user.Send(Encoding.UTF8.GetBytes("Ничья!"));
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(arr);
                                        Move(arr, user);

                                    }
                                }
                                else
                                {
                                    user.Send(Encoding.UTF8.GetBytes(arr));
                                    user.Send(Encoding.UTF8.GetBytes("Эта ячейка занята"));
                                }
                                break;
                            case "3B":
                                if (isCorrectChoise(arr[44]))
                                {
                                    arr[44] = 'X';
                                    if (isWin(arr, 'X') == 0)
                                    {
                                        Console.WriteLine("Крестики победили!");
                                        user.Send(Encoding.UTF8.GetBytes("Крестики победили!"));
                                        break;
                                    }
                                    else if (isWin(arr, 'X') == 1)
                                    {
                                        Console.WriteLine("Ничья!");
                                        user.Send(Encoding.UTF8.GetBytes("Ничья!"));
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(arr);
                                        Move(arr, user);

                                    }
                                }
                                else
                                {
                                    user.Send(Encoding.UTF8.GetBytes(arr));
                                    user.Send(Encoding.UTF8.GetBytes("Эта ячейка занята"));
                                }
                                break;
                            case "3C":
                                if (isCorrectChoise(arr[46]))
                                {
                                    arr[46] = 'X';
                                    if (isWin(arr, 'X') == 0)
                                    {
                                        Console.WriteLine("Крестики победили!");
                                        user.Send(Encoding.UTF8.GetBytes("Крестики победили!"));
                                        break;
                                    }
                                    else if (isWin(arr, 'X') == 1)
                                    {
                                        Console.WriteLine("Ничья!");
                                        user.Send(Encoding.UTF8.GetBytes("Ничья!"));
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(arr);
                                        Move(arr, user);

                                    }
                                }
                                else
                                {
                                    user.Send(Encoding.UTF8.GetBytes(arr));
                                    user.Send(Encoding.UTF8.GetBytes("Эта ячейка занята"));
                                }
                                break;
                            default:
                                user.Send(Encoding.UTF8.GetBytes(arr));
                                user.Send(Encoding.UTF8.GetBytes("Неверное значение\n"));
                                break;
                        }
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            socket.Close();
        }
    }
}
