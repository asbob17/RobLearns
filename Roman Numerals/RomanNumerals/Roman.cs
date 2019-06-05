using System;

namespace RomanNumerals
{
	class romans

	{
		static void Main(string[] args)
		{
			Console.WriteLine("Roman Numerals");

			int[] inputvalues = new int[] { 1000, 500, 100, 50, 10, 5, 1 };
			string[] romans = new string[]
				{ "M", "D", "C", "L", "X", "V", "I" };

			int x = 1;

				while (x > 0)
			{
				string input;
				Console.WriteLine("Enter a Roman Numeral to convert - ");
				input = Console.ReadLine();
				Console.WriteLine("You entered - '{0}'", input);
				x--;
			}

			Console.Read();
		}
	}
}
