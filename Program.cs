using System;

namespace trapecia
{
    class Medvedev
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту трапецию");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите верхние основание трапеции");
            double base1  = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите нижние основание трапеции");
            double base2 = Convert.ToDouble(Console.ReadLine());

            double a = (base2 - base1) / 2;
            double storona = Math.Sqrt(a * a + height * height);

            Console.WriteLine($"Периметр равнобедренной трапеции приблизительно равен {2 * storona + base1 + base2:F2}");
        }
    }
}