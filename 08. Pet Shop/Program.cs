using System;

namespace _08._Pet_Shop
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int foodForDogs = int.Parse(Console.ReadLine());
			int foodForCats = int.Parse(Console.ReadLine());
						
			double totalSum = foodForDogs * 2.50 + foodForCats * 4;
			Console.WriteLine($"{totalSum} lv.");
		}
	}
}
