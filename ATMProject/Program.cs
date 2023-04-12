using ATMProject.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMProject
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write("-------------");
			Console.Write("MOHAMMAD ATM");
			Console.Write("-------------");
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("Welcome To My ATM");
			bool isCardCorrect = false;
			while (!isCardCorrect)
			{
				Console.WriteLine("PLEASE ENTER YOU CRAD NUMBER!!");
				string cardNumberStr = Console.ReadLine();
				if (long.TryParse(cardNumberStr,out long CardNumber))
				{
					Console.WriteLine($"\n{CardNumber} Is it Your Card? Press 1 for Yes, 2 for No!!");
					string isItMyCard = Console.ReadLine();
					if (isItMyCard == "1")
					{
						isCardCorrect = true;
					}
					else if (isItMyCard != "2")
					{
						Console.WriteLine("Invalid input. Please try again.");
					}
				}
				else
				{
					Console.WriteLine("Invalid input. Please enter a valid number.");
				}
				
			}

		}
	}
}
