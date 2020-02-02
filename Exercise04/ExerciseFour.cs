using System;

namespace SecondAsignmentCSharp.Exercise04
{
    class ExerciseFour
    {
        public static void SumIs()
        {
            int suma = 0;
            for (int i = 1; i < 10; i++)
            {
                suma = suma + i;
            }
            Console.WriteLine();
            Console.WriteLine("Suma este: " +suma);

            Console.WriteLine();
            Console.WriteLine($" The for loop initialazez i with 1 and as long as i is under 10 it increments with 1");
            Console.WriteLine($" and in the loop sum is incremented by adding itsealf with the value of i");
            Console.WriteLine($" 0+1, 1+2, 3+3, 6+4, 10+5, 15+6, 21+7, 28+8, 36+8 end result 45");
        }
    }
}
