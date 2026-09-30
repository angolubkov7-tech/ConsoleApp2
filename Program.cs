using System;

namespace Numbers
{
    class Medvedev
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое число");

            double num = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num + 10);
        }
    }
}