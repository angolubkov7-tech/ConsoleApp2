using System;

namespace chisla
{
    class Medvedev
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число (А): ");
            int chisloA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число (B): ");
            int chislob = Convert.ToInt32(Console.ReadLine());

            int temp = chisloA;
            chisloA = chislob;
            chislob = temp;


            Console.WriteLine($"Число (А) = {chisloA}, Число (B) = {chislob}");
        }
    }
}