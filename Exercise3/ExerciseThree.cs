using System;

namespace SecondAsignmentCSharp.Exercise3
{
    class ExerciseThree
    {
        public static void WhatAndWhy()
        {
            int a = 3;
            if (++a < 4)
                if (a++ < 4)
                    Console.WriteLine(a);
                else
                    Console.WriteLine(a);
            Console.WriteLine($" The program does not display anything");
            Console.WriteLine($" because in the first if a is incremented");
            Console.WriteLine($" to 4 before comparing (<) it with 4");
            Console.WriteLine($" therefore the loop stopes there!");
        }
    }
}
