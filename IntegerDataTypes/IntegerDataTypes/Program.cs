using System;

namespace IntegerDataTypes
{
	/// <summary>
	/// Demonstrates integer data types
	/// </summary>
	class MainClass
	{
		/// <summary>
		/// Demonstrates integer data types
		/// </summary>
		/// <param name="args">The command-line arguments.</param>
		public static void Main(string[] args)
		{
			// you can let compiler to figure out variable type but don't do it regularly
			// var seconds = 100;

			// declare integer variable and constant
			int totalSecondsPlayed = 100;
			const int SECONDS_PER_MINUTE = 60;

			// calculate minutes and seconds
			int minutes = totalSecondsPlayed / SECONDS_PER_MINUTE;
			int seconds = totalSecondsPlayed % SECONDS_PER_MINUTE;

			// print results - integer division
			Console.WriteLine("Minutes: " + minutes);
			Console.WriteLine("Seconds: " + seconds);

			// overflow - but compiler will detect it!
			// Console.WriteLine("Result: " + (2147483647 + 1));

			Console.WriteLine();
		}
	}
}
