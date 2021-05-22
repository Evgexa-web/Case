using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string k;
            while (true)
            {
                Console.Write("k = ");
                k = Console.ReadLine();
                switch (k)
                {
                    case "1":
                        Console.WriteLine("плохо");
                        break;
                    case "2":
                        Console.WriteLine("неудовлетворительно");
                        break;
                    case "3":
                        Console.WriteLine("удовлетворительно");
                        break;
                    case "4":
                        Console.WriteLine("хорошо");
                        break;
                    case "5":
                        Console.WriteLine("отлично");
                        break;
                    default:
                        Console.WriteLine("ошибка");
                        break;
                }
            }
        }
    }
}
