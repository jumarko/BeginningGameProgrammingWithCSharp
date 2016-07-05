using System;
using System.Diagnostics.Contracts;

namespace ClassesAndObjects
{
	class Program
	{
		/// <summary>
		/// Demonstrates using the Deck class
		/// </summary>
		/// <param name="args">The command-line arguments.</param>
		public static void Main(string[] args)
		{
			Deck deck = new Deck();

			Console.WriteLine("Empty: " + deck.Empty);

			// tell the deck to shuffle itself
			deck.Print();
			deck.Shuffle();
			Console.WriteLine();
			deck.Print();

			Console.WriteLine();
		}
	}

	/// <summary>
	/// This is hand-written class based on necessary functionality shown in the lecture video.
	/// </summary>
	class Deck
	{
		private bool empty;

		public Deck()
		{
		}

		public bool Empty
		{
			get
			{
				return empty;
			}
		}

		public void Shuffle()
		{
			// do some shuffling
		}

		public void Print() 
		{
			Console.WriteLine("Print Deck content.");
		}

		public void Cut(int location)
		{
		}

		public Card TakeTopCard()
		{
			return null;
		}
	}

	public class Card
	{
	}
}
