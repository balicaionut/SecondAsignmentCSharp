using System;

namespace SecondAsignmentCSharp.Exercise1
{
    class ExerciseOne
    {
        public static void Asignare()
        {
            int a = 3; //the value was not used
            int b = (a = 2) * a; // 2 * 2 = 4 (after this line a = 2 and b = 4)
            int c = b * (b = 5); // 4 * 5 = 20 (after this line b = 5 and c = 20)
            Console.WriteLine($" a = { a }, b = { b }, c = { c })"); // a will be 2, b will be 5 and c will be 20
        }
    }
}