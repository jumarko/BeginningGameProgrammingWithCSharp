using System;

namespace Lab2
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			printAge();

			Console.WriteLine();

			printScore();
		}

		private static void printAge()
		{
			int age = 30;
			Console.WriteLine("Hello, my age is: " + age);

		}

		private static void printScore()
		{
			const int MAX_SCORE = 100;
			int score = 58;
			float percent = (float) score / MAX_SCORE * 100;
			Console.WriteLine("Score percentage is: " + percent + "%");
			Console.WriteLine();

		}
	}
}
