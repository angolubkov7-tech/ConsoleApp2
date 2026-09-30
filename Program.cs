using System;

namespace Chislo
{
    class Medvedev
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число (А); ");
            string a = Console.ReadLine();

            Console.WriteLine("Введите число (B); ");
            string b = Console.ReadLine();

            Console.WriteLine("Введите число (C); ");
            string c = Console.ReadLine();

            string temp = b;
            string tempc = c;
            b = a;
            a = tempc;
            c = temp;

            Console.WriteLine($"Число (А) = {a}, Число (B) = {b}, Число (C) = {c} ");
        }
    }
}

