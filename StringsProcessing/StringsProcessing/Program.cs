using System;

namespace StringsProcessing

{
	/// <summary>
	///  Contains examples from String lecture:
	/// - https://www.coursera.org/learn/game-programming/lecture/1jQEC/6-2-string-operations
	/// </summary>
	class StringsProcessing
	{
		public static void Main(string[] args)
		{
			// read in csv string
			Console.Write("Enter name and percent (name,percent): ");
			string csvString = Console.ReadLine();

			// find comma location
			int commaLocation = csvString.IndexOf(",", StringComparison.Ordinal);

			// extract name and percent
			string name = csvString.Substring(0, commaLocation);
			float percent = float.Parse(csvString.Substring(commaLocation + 1));

			// print name and percent;
			Console.WriteLine();
			Console.WriteLine("name: " + name);
			Console.WriteLine("percent: " + percent);
		}
	}
}
