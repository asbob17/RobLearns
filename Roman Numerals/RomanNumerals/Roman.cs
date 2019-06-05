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

			while (x >= 0)
			{
				int input;
				Console.WriteLine("Enter a Number to convert - ");
				input = int.Parse(Console.ReadLine());
				Console.WriteLine("You entered - '{0}'", input);
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

			Console.Read();
		}
	}
}
