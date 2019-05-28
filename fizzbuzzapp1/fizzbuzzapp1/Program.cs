using System;

namespace fizzbuzzapp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			for (int i = 1; i <= 100; i++)
			{
				 if (i % 3 == 0 && i % 5 == 0)
				{
					Console.WriteLine("FizzBuzz!");
				}

				else if (i % 3 == 0)
				{
					Console.WriteLine("Fizz");
				}
				else if (i % 5 == 0)
				{
					Console.WriteLine("Buzz");

				}
				
				else { Console.WriteLine(i); }
			}

			/*
			 * using System;

namespace fizzbuzzapp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			for (int i = 1; i <= 100; i++)
			{
				var output = "";
				if (i % 3 == 0)
					output = "fizz";

				if (i % 5 == 0)
					output += "buzz";

				if (string.IsNullOrEmpty(output))
					output = i.ToString();

				Console.WriteLine(output);
			}



			Console.Read();
		}
	}
}
*/
			

			Console.Read();
		}
	}
}
