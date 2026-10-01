using System;

namespace Chislo
{
    class Medvedev
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число больше 999");

            int num = Convert.ToInt32(Console.ReadLine());

            int num1 = (num / 100) % 10;
            int num3 = num / 1000;

            Console.WriteLine($"Число сотен в числе {num} равно {num1} , число тысяч рвно {num3}");

        }
    }
}

