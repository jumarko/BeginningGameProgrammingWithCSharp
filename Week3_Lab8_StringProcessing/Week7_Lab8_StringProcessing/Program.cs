using System;

namespace Week7_Lab8_StringProcessing
{
	/// <summary>
	/// Week 3 Lab 8 - Practicing string processing.
	/// Check https://www.coursera.org/learn/game-programming/supplement/OzK1s/labs-7-8-9-and-10 for more details.
	/// </summary>
	class MainClass
	{
		public static void Main(string[] args)
		{
			// read in string in format: <pyramid slot number>,<block letter>,<whether or not the block should be lit>
			Console.WriteLine("Enter string in format: <pyramid slot number>,<block letter>,<whether or not the block should be lit>");

			string inputLine = Console.ReadLine();

			// extract print all three variables
			string[] strings = inputLine.Split(',');

			int pyramidSlotNumber = int.Parse(strings[0]);
			Console.WriteLine("Pyramid slot number: " + pyramidSlotNumber);

			char blockLetter = char.Parse(strings[1]);
			Console.WriteLine("block letter: " + blockLetter);

			Boolean blockShouldBeLit = Boolean.Parse(strings[2]);
			Console.WriteLine("Whether or not the block should be lit: " + blockShouldBeLit);
			Console.WriteLine("In other words...")
			if (blockShouldBeLit)
			{
				Console.WriteLine("Block should be lit.");
			}
			else
			{
				Console.WriteLine("Block should not be lit.");
			}

			Console.WriteLine();
		}
	}
}
