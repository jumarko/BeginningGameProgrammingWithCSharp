using System;

namespace SwitchStatements
{
	/// <summary>
	/// Demonstrates switch statements
	/// </summary>
	class MainClass
	{
		public static void Main(string[] args)
		{
			// ask for and get user answer
			Console.WriteLine("Pick up the shiny thing? (y, n): ");
			char answer = Console.ReadLine()[0];

			// print appropriate message
			switch (answer)
			{
				case 'y':
				case 'Y':
					Console.WriteLine("You have the shiny thing");
					break;
				case 'n':
				case 'N':
					Console.WriteLine("You don't have the shiny thing");
					break;
				default:
					Console.WriteLine("You are n00b.");
					break;
			}
		}
	}
}
