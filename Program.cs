using System;


namespace institut
{
    class Program
    {
        enum University {КАИ, КГУ, КХТИ}

        enum name {Роман, Сергей, Олег}

        struct UniversityName
        {
            public University Type;
            public name Tipe;
        }

        UniversityName now = new UniversityName();




    }
}