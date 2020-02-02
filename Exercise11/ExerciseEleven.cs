using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAsignmentCSharp.Exercise11
{
    class ExerciseEleven
    {
        public static void SecondsConverter()
        {
            Console.WriteLine();
            Console.WriteLine($" The program will ask you to input any number of seconds");
            Console.WriteLine($" and will convert them in hours, minutes and seconds left");
            Console.WriteLine();
            Console.WriteLine($" press any key to continue");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine($" Please insert the the number of seconds you wish to convert:");
            int inSec = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int s = inSec;
            int h = s / 3600;
            s = s % 3600;
            int m = s / 60;
            s = s % 60;


            Console.WriteLine($" {inSec} = {h} hours, {m} minutes and {s} seconds");

            Console.WriteLine();
            Console.WriteLine($" The program simply devides first by 3600 to find the number of hours,");
            Console.WriteLine($" then, the remaining seconds are devided by 60 to find the number of minutes");
            Console.WriteLine($" and the remaining secons.");
        }
    }
}
