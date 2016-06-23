using System;

namespace FloatingPointNumbers
{
	/// <summary>
	/// Demonstrates floating point numbers
	/// </summary>
	class MainClass
	{
		public static void Main(string[] args)
		{
			int score = 1356;
			int totalSecondsPlayed = 10000;

			// Watch Out! The result is zero!!! -> Integer division
			float pointsPerSecond = score / totalSecondsPlayed;
			Console.WriteLine("Points per second: " + pointsPerSecond);
			Console.WriteLine();

			// force floating-point divison
			float pointsPerSecondFloat = (float) score / totalSecondsPlayed;
			Console.WriteLine("Points per second: " + pointsPerSecondFloat);
			Console.WriteLine();
		}
	}
}
