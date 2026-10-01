using System;

namespace Chislo
{
    class Medvedev
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя человека: ");
            string nameA = Console.ReadLine();

            
            Console.WriteLine(nameA);


            Console.WriteLine();


           
            Console.Write("Введите имя человека для приветствия: ");
            string nameB = Console.ReadLine();
            Console.WriteLine($"Привет, {nameB}!");

        }
    }
}

