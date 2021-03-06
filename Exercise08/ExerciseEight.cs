﻿using System;

namespace SecondAsignmentCSharp.Exercise08
{
    class ExerciseEight
    {
		public static void DayOfTheWeek()
		{
			bool showMenu = true;
			while (showMenu)
			{
				showMenu = BoolMenu();
			}
		}

		private static bool BoolMenu()
		{
			WeekDayMenu();
			switch (Console.ReadLine())
			{
				case "1":
					Console.WriteLine();
					Console.WriteLine(" Monday");
					Continue();
					return true;
				case "2":
					Console.WriteLine();
					Console.WriteLine(" Tuesday");
					Continue();
					return true;
				case "3":
					Console.WriteLine();
					Console.WriteLine(" Wednesday");
					Continue();
					return true;
				case "4":
					Console.WriteLine();
					Console.WriteLine(" Thursday");
					Continue();
					return true;
				case "5":
					Console.WriteLine();
					Console.WriteLine(" Friday");
					Continue();
					return true;
				case "6":
					Console.WriteLine();
					Console.WriteLine(" Saturday");
					Continue();
					return true;
				case "7":
					Console.WriteLine();
					Console.WriteLine(" Sunday");
					Continue();
					return true;
				case "0":
					return false;
				default:
					Console.WriteLine();
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

		private static void WeekDayMenu()
		{
			Console.WriteLine();
			Console.WriteLine($" Week Day Menu:");
			Console.WriteLine();
			Console.WriteLine($" Please select a number from 1 to 7");
			Console.WriteLine($" to show the corresponding day of the week,");
			Console.WriteLine();
			Console.WriteLine($" or pless 0 to exit the program!");
			Console.WriteLine();
			Console.WriteLine($" Please make a valid selection:");
		}
	}
}
