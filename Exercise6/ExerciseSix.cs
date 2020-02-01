using System;

namespace SecondAsignmentCSharp.Exercise6
{
    class ExerciseSix
    {
        public static void MinOfThree()
        {
            Console.WriteLine();
            Console.WriteLine($" This program will indicate the minimum of three numbers provided by user");
            Console.WriteLine();
            Console.WriteLine($" Please input the 1st number: ");
            int first = int.Parse(Console.ReadLine());

            Console.WriteLine($" Please input the 2nd number: ");
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine($" Please input the 3rd number: ");
            int therd = int.Parse(Console.ReadLine());
            Console.WriteLine();


            if (first < second && first <therd)
                Console.WriteLine($" The minimum is {first} the 1st number");
            else if (second < first && second < therd)
                Console.WriteLine($" The minimum is {second} the 2nd number");
            else
                Console.WriteLine($" The minimum is {therd} the 3rd number");

            Console.WriteLine();
            Console.WriteLine($" The program has an if-elseif-else implementation");
            Console.WriteLine($" and verifies which is the minimum number");
        }
    }
}
