﻿using System;

namespace FebruaryContestEntry
{
	class Program
	{
		const char block = '▓';

		static void Main(string[] args)
		{
			// The solution implementation goes here

			new Shape(new Dimensions(15, 30), new Character(ForeColor.Yellow, block))
				.Border(new Character(ForeColor.Green, block))
				.Render();



			Console.WriteLine(block);
			Console.ResetColor();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Yay, a colorful shape!");
			Console.ReadLine();
		}
	}
}
