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

			Console.WriteLine(romans[0]);

			Console.Read();
		}
	}
}
