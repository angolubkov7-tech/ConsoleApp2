using System;
using System.Security.Cryptography;

namespace Chisla
{
    class Medvedev
    {
        static void Main(string[] args)
        {
            int num1 = Random.Shared.Next(0, int.MaxValue);
            int num2 = Random.Shared.Next(0, int.MaxValue);
            int num3 = Random.Shared.Next(0, int.MaxValue);
            int num4 = Random.Shared.Next(0, int.MaxValue);

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
        }
    }
} 