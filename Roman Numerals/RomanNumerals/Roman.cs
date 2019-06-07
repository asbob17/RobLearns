using System;

namespace RomanNumerals
{
	class romans

	{
		static void Main(string[] args)
		{
			Console.WriteLine("Roman Numerals");

			int[] decimalValues = new int[] { 1000, 500, 100, 50, 10,9, 5, 4, 1 };
			string[] numerals = new string[] { "M", "D", "C", "L", "X","IX","V","IV","I" };

			var input = 1984;
			var output = "";
			for (var i = 0; i < numerals.Length; i++)
			{
				while (input >= decimalValues[i])
				{
					output += numerals[i];
					input -= decimalValues[i];
				}

			}

			Console.WriteLine(output);
			Console.Read();
		}

		private static void NumeralsAsIf()
		{
			Console.WriteLine("Roman Numerals");

			int x = 1;

			while (x > 0)
			{
				int input;
				Console.WriteLine("Enter a Number to convert - ");
				input = int.Parse(Console.ReadLine());
				x--;

				var output = string.Empty;

				while (input > 0)
				{
					if (input >= 1000)
					{
						output += "M";
						input -= 1000;
						continue;
					}

					if (input >= 500)
					{
						output += "D";
						input -= 500;
						continue;
					}

					if (input >= 100)
					{
						output += "C";
						input -= 100;
						continue;
					}

					if (input >= 50)
					{
						output += "L";
						input -= 50;
						continue;
					}

					if (input >= 10)
					{
						output += "X";
						input -= 10;
						continue;
					}

					if (input >= 9)
					{
						output += "IX";
						input -= 9;
						continue;
					}

					if (input >= 5)
					{
						output += "V";
						input -= 5;
						continue;
					}

					if (input >= 4)
					{
						output += "IV";
						input -= 4;
						continue;
					}

					output += "I";
					input -= 1;
				}

				Console.WriteLine(output);
			}
		}
	}
}
