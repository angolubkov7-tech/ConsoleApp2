using System;

namespace Chislo
{
    class Medvedev
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число (А); ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число (B); ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Средние арифмитическое равно {(num1 + num2) / 2}, средние геометрическое равно {Math.Sqrt(num1 * num2)}");
        }
    }

}

