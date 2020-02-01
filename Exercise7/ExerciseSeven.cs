using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAsignmentCSharp.Exercise7
{
    class ExerciseSeven
    {
        public static void EvenOrOdd()
        {
            Console.WriteLine();
            Console.WriteLine($" This program will output if a number provided by user is even or odd");
            Console.WriteLine();
            Console.WriteLine($" Please input the number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine();
                Console.WriteLine($" {number} is an even number");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($" {number} is an odd number");
            }

            Console.WriteLine();
            Console.WriteLine($" The program has an if-else implementation, therfore");
            Console.WriteLine($" if the modulus of the number devided by 2 is equal to zero");
            Console.WriteLine($" then the number is even, otherwise the number is odd.");
        }

    }
}
