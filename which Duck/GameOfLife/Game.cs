using System;

namespace GameOfLife
{
	class GOL

	{
		static void Main(string[] args)
		{

			for (var i = 0; i < 20; i++) //down
			{
				for (int j = 0; j < 20; j++) //horizontal
				{
					Console.Write(" 0");
				}

				Console.WriteLine();
			}

			Console.ReadLine();
		}
	}
}