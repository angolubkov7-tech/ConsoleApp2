using System;

namespace Chislo
{
    class Medvedev
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько секунд прошло с начало суток");
            int second = Convert.ToInt32(Console.ReadLine());

            int hour = second / 3600;
            int minute = (second%3600) / 60;
            int second2 = second%60;

            Console.WriteLine($"От начала суток прошло {hour} часов, от последнего часа прошло {minute} минут, от последний минуты прошло {second2} сеекунд ");
        }
    }
}

