using System;

namespace Cos
{
    class Medvedev
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите угол в градусах");

            double gradys = Convert.ToDouble(Console.ReadLine());

            double radians = (gradys * Math.PI) / 180.0;

            double y = Math.Cos(radians);

            Console.WriteLine($"cos({gradys}) = {y:F2}");

        }
    }
}