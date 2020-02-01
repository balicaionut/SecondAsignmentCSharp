using System;

namespace SecondAsignmentCSharp.Exercise2
{
    class ExerciseTwo
    {
        public static void IsCompiling()
        {
            double d = 2.95;
            int i = 4;
            Console.WriteLine(++d > i ? d : i);
            Console.WriteLine($" the progarm compiles and displays 4 that is the i value");
            Console.WriteLine($" it compairs the incremented d (++d = 3.95) with i (4)");
            Console.WriteLine($" and because d is smaller it displys i");
        }
    }
}