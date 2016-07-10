using System;

namespace Week3_Lab9_SwitchStatements
{
	/// <summary>
	/// Week 3 - Labe 9 Practicing If and Switch statements.
	/// Check https://www.coursera.org/learn/game-programming/supplement/OzK1s/labs-7-8-9-and-10
	/// </summary>
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine();
			Console.WriteLine("**************");
			Console.WriteLine("Menu:");
			Console.WriteLine();
			Console.WriteLine("N - New Game");
			Console.WriteLine("L - Load Game");
			Console.WriteLine("O - Options");
			Console.WriteLine("Q - Quit");
			Console.WriteLine("**************");

			Console.WriteLine();
			Console.WriteLine("Enter your choice: ");

			string input = Console.ReadLine();
			Console.WriteLine();
			if (input.Length > 1)
			{
				Console.WriteLine("ERROR: Only single letter can be entered, but found: " + input);
			}
			else 
			{
				char choice = input[0];

				// using if statement
				if (choice == 'N' || choice == 'n')
				{
					Console.WriteLine("Loading new game ...");
				}
				else if (choice == 'L' || choice == 'l')
				{
					Console.WriteLine("Loading game ...");
				}
				else if (choice == 'O' || choice == 'o')
				{
					Console.WriteLine("Showing options ...");
				}
				else if (choice == 'Q' || choice == 'q')
				{
					Console.WriteLine("Exiting ...");
				}
				else
				{
					Console.WriteLine("ERROR: Unknown choice: " + choice);
				}

				// now the same thing using switch statement...
				switch (choice)
				{
					case 'N':
					case 'n':
						Console.WriteLine("Loading new game ...");
						break;
					case 'L':
					case 'l':
						Console.WriteLine("Loading game ...");
						break;
					case 'O':
					case 'o':
						Console.WriteLine("Showing options ...");
						break;
					case 'Q':
					case 'q':
						Console.WriteLine("Exiting ...");
						break;
					default: 
						Console.WriteLine("ERROR: Unknown choice: " + choice);
						break;
				}
			}
		}
	}
}
