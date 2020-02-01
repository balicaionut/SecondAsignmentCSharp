using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecondAsignmentCSharp.Exercise1;
using SecondAsignmentCSharp.Exercise2;
using SecondAsignmentCSharp.Exercise3;
using SecondAsignmentCSharp.Exercise4;
using SecondAsignmentCSharp.Exercise5;
using SecondAsignmentCSharp.Exercise6;
using SecondAsignmentCSharp.Exercise7;

namespace SecondAsignmentCSharp
{
    class Program
    {
		static void Main(string[] args)
		{
			bool showMenu = true;
			while (showMenu)
			{
				showMenu = BoolMenu();
			}
		}

		private static bool BoolMenu()
		{
			Menu.MainMenu();
			switch (Console.ReadLine())
			{
				case "1":
					ExerciseOne.Asignare();
					Continue();
					return true;
				case "2":
					ExerciseTwo.IsCompiling();
					Continue();
					return true;
				case "3":
					ExerciseThree.WhatAndWhy();
					Continue();
					return true;
				case "4":
					ExerciseFour.SumIs();
					Continue();
					return true;
				case "5":
					ExerciseFive.EnFactorial();
					Continue();
					return true;
				case "6":
					ExerciseSix.MinOfThree();
					Continue();
					return true;
				case "7":
					ExerciseSeven.EvenOrOdd();
					Continue();
					return true;
				case "8":

					Continue();
					return true;
				case "9":

					Continue();
					return true;
				case "10":

					Continue();
					return true;
				case "11":

					Continue();
					return true;
				case "0":

					return false;
				default:
					Console.WriteLine(" Error: invalid selection");
					Continue();
					return true;
			}
		}
		private static void Continue()
		{
			Console.WriteLine();
			Console.WriteLine($" press any key to continue");
			Console.WriteLine();
			Console.ReadKey();
		}
    }
}
