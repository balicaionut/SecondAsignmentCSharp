using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAsignmentCSharp.Exercise10
{
    class ExerciseTen
    {
        public static void DepositCalculator()
        {
            Console.WriteLine();
            Console.WriteLine($" The program will ask you for a sum of money to deposit in an account");
            Console.WriteLine($" and will ask you the number of years to simulate how much money");
            Console.WriteLine($" you will have in the account after those years.");
            Console.WriteLine();
            Console.WriteLine($" The account has a yearly term with a return of 25%");
            Console.WriteLine();
            Console.WriteLine($" press any key to continue");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine($" Please insert the initial deposit sum of money:");
            double dep = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($" Please insert the years to simulate:");
            int years = int.Parse(Console.ReadLine());
            Console.WriteLine();

            double loadDep = dep;

            for (int i = 0; i < years; i++)
            {
                loadDep = loadDep + loadDep * 0.25;
            }

            Console.WriteLine($" After {years} years the initial deposit of {dep} will be {loadDep}");
                                   
            Console.WriteLine();
            Console.WriteLine($" The program has a for loop that iterates until the number of years is reached");
            Console.WriteLine($" and every time it adds to the deposit the return of 25% of each year.");
        }
    }
}
