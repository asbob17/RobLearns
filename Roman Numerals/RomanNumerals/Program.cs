﻿using System;

namespace RomanNumerals
{
	class romans
	
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Roman Numerals");

			int[] intArray1 = new int[7];
			intArray1[0] = 1;
			intArray1[1] = 5;
			intArray1[2] = 10;
			intArray1[3] = 50;
			intArray1[4] = 100;
			intArray1[5] = 500;
			intArray1[6] = 1000;

			int x = 0;

			while (x <= 3)
			{
				for (int i = 0; i < intArray1.Length; i++)
					Console.WriteLine(intArray1[i]);
				x++;
			}

			//for(int i =0; i < intArray1.Length; i++)
			//	Console.WriteLine(intArray1[i]);
		
			//Console.WriteLine(intArray1[0]);
			//Console.WriteLine(intArray1[1]);
			//Console.WriteLine(intArray1[2]);
			//Console.WriteLine(intArray1[3]);
			//Console.WriteLine(intArray1[4]);
			//Console.WriteLine(intArray1[5]);
			//Console.WriteLine(intArray1[6]);

			Console.Read();
		}
	}
}
