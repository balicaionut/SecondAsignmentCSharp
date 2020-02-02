using System;
using SecondAsignmentCSharp.Exercise01;
using SecondAsignmentCSharp.Exercise02;
using SecondAsignmentCSharp.Exercise03;
using SecondAsignmentCSharp.Exercise04;
using SecondAsignmentCSharp.Exercise05;
using SecondAsignmentCSharp.Exercise06;
using SecondAsignmentCSharp.Exercise07;
using SecondAsignmentCSharp.Exercise08;
using SecondAsignmentCSharp.Exercise09;
using SecondAsignmentCSharp.Exercise10;
using SecondAsignmentCSharp.Exercise11;

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
					ExerciseEight.DayOfTheWeek();
					Continue();
					return true;
				case "9":
					ExerciseNine.FirstFourSumsOfDivisors();
					Continue();
					return true;
				case "10":
					ExerciseTen.DepositCalculator();
					Continue();
					return true;
				case "11":
					ExerciseEleven.SecondsConverter();
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
