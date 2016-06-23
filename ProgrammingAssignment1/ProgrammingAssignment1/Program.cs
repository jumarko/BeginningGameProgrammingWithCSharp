using System;

namespace ProgrammingAssignment1
{
	/// <summary>
	/// First Programming assignment - calculating the distance and angle between two points.
	/// </summary>
	class MainClass
	{
		/// <summary>
		/// Prints the welcome message.
		/// Reads x and y coordinates of two points and then compute and display the distance and angle (in degrees) between them.
		/// </summary>
		/// <param name="args">The command-line arguments.</param>
		public static void Main(string[] args)
		{
			// display welcome message
			Console.WriteLine("Hello.");
			Console.WriteLine("I will compute the distance and angle between two points for you.");
			Console.WriteLine();

			// read coordinates for 1. point
			Console.Write("Point 1 X: ");
			float point1X = float.Parse(Console.ReadLine());
			Console.Write("Point 1 Y: ");
			float point1Y = float.Parse(Console.ReadLine());

			// read coordinates for 2. point
			Console.Write("Point 2 X: ");
			float point2X = float.Parse(Console.ReadLine());
			Console.Write("Point 2 Y: ");
			float point2Y = float.Parse(Console.ReadLine());

			// compute distance between points
			float deltaX = point2X - point1X;
			float deltaY = point2Y - point1Y;
			double distance = Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY));

			// compute angle between points
			double angleInRadians = Math.Atan2(deltaY, deltaX);
			double angleInDegrees = angleInRadians * (180 / Math.PI);

			// display the result
			Console.WriteLine();
			Console.WriteLine("Distance between points: " +  distance.ToString("N3"));
			Console.WriteLine("Angle between points: " + angleInDegrees.ToString("N3") + " degrees");
			Console.WriteLine();
		}
	}
}
