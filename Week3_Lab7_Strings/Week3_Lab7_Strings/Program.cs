using System;

namespace Week3_Lab7_Strings
{
	/// <summary>
	/// Lab 7 from Week 3
	/// Check https://www.coursera.org/learn/game-programming/supplement/OzK1s/labs-7-8-9-and-10
	/// </summary>
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine();

			Console.WriteLine("In what month were you born? ");
			string monthOfBirth = Console.ReadLine();

			Console.WriteLine("In what day were you born? ");
			int dayOfBirth = int.Parse(Console.ReadLine());

			Console.WriteLine();
			Console.WriteLine("Your birthday is " + monthOfBirth + " " + dayOfBirth);

			// reminder email
			Console.WriteLine("You'll receive reminder email on " + monthOfBirth + " " + (dayOfBirth - 1));

		}
	}
}
