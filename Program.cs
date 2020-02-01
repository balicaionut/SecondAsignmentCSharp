using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecondAsignmentCSharp.Exercise1;
using SecondAsignmentCSharp.Exercise2;
using SecondAsignmentCSharp.Exercise3;

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
					BoolContinue();
					return true;
				case "2":
					ExerciseTwo.IsCompiling();
					BoolContinue();
					return true;
				case "3":
					ExerciseThree.WhatAndWhy();
					BoolContinue();
					return true;
				case "4":

					BoolContinue();
					return true;
				case "5":

					BoolContinue();
					return true;
				case "6":

					BoolContinue();
					return true;
				case "7":

					BoolContinue();
					return true;
				case "8":

					BoolContinue();
					return true;
				case "9":

					BoolContinue();
					return true;
				case "10":

					BoolContinue();
					return true;
				case "11":

					BoolContinue();
					return true;
				case "12":

					BoolContinue();
					return true;
				case "0":

					return false;
				default:
					Console.WriteLine(" Error: invalid selection");
					BoolContinue();
					return true;
			}
		}
		private static bool BoolContinue()
		{
			Console.WriteLine();
			Console.WriteLine($" press Enter to continue");
			switch (Console.ReadLine())
			{
				default:
					return false;
			}
		}
    }
}
