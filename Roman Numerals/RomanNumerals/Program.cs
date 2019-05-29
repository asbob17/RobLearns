using System;

namespace RomanNumerals
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Who  is the Duck?");
			for (int i = 1; i <= 60; i++)
			{
				if (i % 2 == 0 && i % 3 == 0 && i % 5 == 0)
				{
					Console.WriteLine("DUCKTALES!");
				}

				else if (i % 2 == 0 && i % 3 == 0)
				{
					Console.WriteLine("HueyLouey!");
				}

				else if (i % 2 == 0 && i % 5 == 0)
				{
					Console.WriteLine("HueyDouey!");
				}

				else if (i % 3 == 0 && i % 5 == 0)
				{
					Console.WriteLine("LoueyDouey!");
				}

				else if (i % 2 == 0)
				{
					Console.WriteLine("Huey");
				}

				else if (i % 3 == 0)
				{
					Console.WriteLine("Louey");
				}
				else if (i % 5 == 0)
				{
					Console.WriteLine("Douey");

				}

				else { Console.WriteLine(i); }
			}

			Console.Read();
		}
	}
}
