using System;

namespace Lab3
{
	class MainClass
	{
		/// <summary>
		/// Do the conversions between fahrenheits and Celsius.
		/// Test this program with fahrenheit values 0, 32, and 212.
		/// Notice that 0 produces the different final value.
		/// </summary>
		/// <param name="args">The command-line arguments.</param>
		public static void Main(string[] args)
		{
			// we're gonna store the temperature in float variable 
			Console.Write("Enter temperature (Fahrenheit): ");
			float originalFahrenheit = float.Parse(Console.ReadLine());

			float celsius = (originalFahrenheit - 32) / 9 * 5;
			float fahrenheit = (celsius * 9 / 5) + 32;

			PrintResults(originalFahrenheit, celsius, fahrenheit);

			// floating-point arithmetic doesn't work precisely
			// we may want to use decimal
			Console.WriteLine("Now using decimals!");
			Console.Write("Enter temperature (Fahrenheit): ");
			decimal originalFahrenheitDecimal = decimal.Parse(Console.ReadLine());

			decimal celsiusDecimal = (originalFahrenheitDecimal - 32) / 9 * 5;
			decimal fahrenheitDecimal = (celsiusDecimal * 9 / 5) + 32;
			PrintResults(originalFahrenheitDecimal, celsiusDecimal, fahrenheitDecimal);
		}

		private static void PrintResults<T>(T originalFahrenheit, T celsius, T fahrenheit)
		{
			Console.WriteLine(originalFahrenheit + " degrees in fahrenheit is " + celsius + " degrees Celsius");
			Console.WriteLine(celsius + " degrees in Celsius is " + fahrenheit + " degrees Fahrenheit");
		}
	}
}
