using System;

namespace Chislo
{
    class Medvedev
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввидите большую координату точки по оси X: ");
            double numX1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите большую координату точки по оси Y: ");
            double numY1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ввидите меньшую координату точки по оси X: ");
            double numX2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите меньшую координат точки по оси Y: ");
            double numY2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Расстояние между точками равно {Math.Sqrt((numX1 - numX2) * (numX1 - numX2) + (numY1 - numY2) * (numY1 - numY2))}");

        }
    }

}

