using System;

namespace SecondAsignmentCSharp.Exercise05
{
    class ExerciseFive
    {
        public static void EnFactorial()
        {
            Console.WriteLine($"Please input a number from 1 to 12: ");
            int n = int.Parse(Console.ReadLine());
            int nf = n;

            if (n < 1 || n > 12)
            {
                Console.WriteLine($"Error: Value aout of range!");
                Console.WriteLine();
                Console.ReadKey();
                Console.WriteLine($"Please input a number from 1 to 12: ");
                n = int.Parse(Console.ReadLine());
            }
            else
            {
                for (int i = 1; i < n; i++)
                {
                    nf = nf * i;
                }
            }

            Console.WriteLine();
            Console.WriteLine($" { n }! is: { nf } ");
            Console.WriteLine();

            Console.WriteLine($" The program has an if-else implementation to verify if n < 13 or > 0");
            Console.WriteLine($" If the conditions are not met the program will ask for a correct value.");
            Console.WriteLine($" If value is correct the program will execute a loop that will resolve the factorial.");
        }
    }
}
