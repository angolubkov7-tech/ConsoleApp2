using System;
using System.Threading.Tasks;

namespace Chislo
{
    class Medvedev
    {
        static void Main(string[] args)
        {
          string hello = Console.ReadLine();

            Console.WriteLine("Как тебя зовут?");

            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}");
            
            string room = Console.ReadLine();
            Console.WriteLine("Да");

            string tell = Console.ReadLine();
            Console.WriteLine("Нет");

            Thread.Sleep(5000);

            Console.WriteLine("Но могу показать");

            var rnd = new Random();
            Console.ForegroundColor = (ConsoleColor)rnd.Next(0, 16);
        }
    }
}

