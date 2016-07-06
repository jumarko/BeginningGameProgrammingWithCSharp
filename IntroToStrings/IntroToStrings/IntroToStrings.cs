using System;

namespace IntroToStrings
{
	/// <summary>
	///  Contains examples from String lecture:
	/// - https://www.coursera.org/learn/game-programming/lecture/knjII/6-1-intro-to-strings
	/// </summary>
	class StringIO
	{
		public static void Main(string[] args)
		{
			// first lecture

			// prompt for and read in gamertag
			Console.Write("Enter gamertag: ");
			string gamertag = Console.ReadLine();

			// prompt for and read in level
			Console.Write("Enter level: ");

			int level = int.Parse(Console.ReadLine());

			char firstGamertagCharacter = gamertag[0];

			// print out values
			Console.WriteLine();
			Console.WriteLine("Gamertag: " + gamertag);
			Console.WriteLine("Level: " + level);
			Console.WriteLine("First Gamertag character: " + firstGamertagCharacter);
		}
	}

}
