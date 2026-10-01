using System;
using System.Threading.Tasks;

namespace Chislo
{
    class Medvedev
    {
        static void Main(string[] args)
        {
            // пункт а)

            long num = Random.Shared.NextInt64(100000000000, 1000000000000);

            long num12 = (num / 1) % 10;
            long num11 = (num / 10) % 10;
            long num10 = (num / 100) % 10;
            long num9 = (num / 1000) % 10;
            long num8 = (num / 10000) % 10;     
            long num7 = (num / 100000) % 10;    
            long num6 = (num / 1000000) % 10;   
            long num5 = (num / 10000000) % 10;  
            long num4 = (num / 100000000) % 10; 
            long num3 = (num / 1000000000) % 10;
            long num2 = (num / 10000000000) % 10;
            long num1 = (num / 100000000000) % 10;


            long even = num2 + num4 + num6 + num8 + num10 + num12;
            long noteven = num1 + num3 + num5 + num7 + num9 + num11;
            long sumeven = 3 * even + noteven;
            long lastnum = sumeven % 10;
            Console.WriteLine($"Код EAN13 равен: {num}");
            Console.WriteLine($"Контрольная цифра равна: {10 - lastnum}");

            Console.WriteLine();

            // пункт б)

            Console.WriteLine("Введите двенадцатизначное число: ");
            long numer = long.Parse(Console.ReadLine());

            long numer12 = (numer / 1) % 10;
            long numer11 = (numer / 10) % 10;
            long numer10 = (numer / 100) % 10;
            long numer9 = (numer / 1000) % 10;
            long numer8 = (numer / 10000) % 10;     
            long numer7 = (numer / 100000) % 10;    
            long numer6 = (numer / 1000000) % 10;   
            long numer5 = (numer / 10000000) % 10;  
            long numer4 = (numer / 100000000) % 10; 
            long numer3 = (numer / 1000000000) % 10;
            long numer2 = (numer / 10000000000) % 10;
            long numer1 = (numer / 100000000000) % 10;

            long evener = numer2 + numer4 + numer6 + numer8 + numer10 + numer12;
            long notevener = numer1 + numer3 + numer5 + numer7 + numer9 + numer11;
            long sumevener = 3 * evener + notevener;
            long lastnumer = sumevener % 10;
            Console.WriteLine($"Код EAN13 равен: {numer}");
            Console.WriteLine($"Контрольная цифра равна: {10 - lastnumer}");
        }
    }
}

