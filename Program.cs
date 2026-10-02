using System;
using System.Diagnostics.CodeAnalysis;


namespace institut
{
    class Program
    {
        enum University
        { 
            КАИ,
            КХТИ,
            КГУ
        }

        enum name
        {
            Роман, 
            Сергей, 
            Олег 
        }

        struct UniversityName
        {
            public University Type;
            public name Tipe;
        }

        static void Main(string[] args)
        {

            UniversityName now1 = new UniversityName();
            UniversityName now2 = new UniversityName();
            UniversityName now3 = new UniversityName();
            now1.Type = University.КАИ;
            now2.Type = University.КХТИ;
            now3.Type = University.КГУ;

            UniversityName name1 = new UniversityName();
            UniversityName name2 = new UniversityName();
            UniversityName name3 = new UniversityName();
            name3.Tipe = name.Роман;
            name2.Tipe = name.Сергей;
            name1.Tipe = name.Олег;

            Console.WriteLine($"{name3.Tipe} , {now3.Type} .");
            Console.WriteLine($"{name2.Tipe} , {now2.Type} .");
            Console.WriteLine($"{name1.Tipe} , {now1.Type}  .");
        }
    }
}