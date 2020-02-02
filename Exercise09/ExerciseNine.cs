using System;

namespace SecondAsignmentCSharp.Exercise09
{
    class ExerciseNine
    {
        public static void FirstFourSumsOfDivisors()
        {
            Console.WriteLine();
            Console.WriteLine($" The program will list the first 4 numbers that are at the same time");
            Console.WriteLine($" the sums of their subdivisors excluding themselfes.");
            Console.WriteLine();
            Console.WriteLine($" press any key to continue");
            Console.WriteLine();
            Console.ReadKey();

            int n = 1;
            int k = 1;
            int j = 1;

            Console.WriteLine($" The numbers are:");

            while (j < 5)
            {
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        k = k + i;
                    }
                }
                if (k == n && n != 1)
                {
                    Console.WriteLine($" {k}");
                    j++;
                }
                n++;
                k = 1;

            }

            Console.WriteLine();
            Console.WriteLine($" The program has a while loop to know when the 4th number was found and stop.");
            Console.WriteLine();
            Console.WriteLine($" In the while loop there is a for loop that iterates the main number divisions");
            Console.WriteLine($" and inside it there is an if that adds to the number cheked a subdivisor when is found.");
            Console.WriteLine();
            Console.WriteLine($" After the for loop there is an if that checks if we found the number");
            Console.WriteLine($" equal to the sum of his divisors excluding himself.");
        }
    }
}
