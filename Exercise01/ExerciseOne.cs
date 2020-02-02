using System;

namespace SecondAsignmentCSharp.Exercise01
{
    class ExerciseOne
    {
        public static void Asignare()
        {
            int a = 3; //the value was not used
            int b = (a = 2) * a; // 2 * 2 = 4 (after this line a = 2 and b = 4)
            int c = b * (b = 5); // 4 * 5 = 20 (after this line b = 5 and c = 20)
            Console.WriteLine();
            Console.WriteLine($" a = { a }, b = { b }, c = { c })"); // a will be 2, b will be 5 and c will be 20

            Console.WriteLine();
            Console.WriteLine($" The first value of a was never used.");
            Console.WriteLine($" In the first b value allocation a gets the value 2 and b get the value 4.");
            Console.WriteLine($" In the c value allocation b gets the new value 5 and c gets the value 20");
            Console.WriteLine($" In the end a is 2, b is 5 and c is 20");
        }
    }
}