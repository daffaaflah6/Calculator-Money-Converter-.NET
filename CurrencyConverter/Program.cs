using System;

namespace CurrencyConverter
{
    class Program
    {
        enum smoney : int { usd = 13000, bath = 320, sgd = 9000, yen = 120, won = 15, pound = 18000, ringgit = 3400}
		static void Main(string[] args)
        {
            double yourmoney;
			string Choose;
			Console.WriteLine("=======================");
			Console.WriteLine("Welcome to my converter");
			Console.WriteLine("=======================");
			Console.WriteLine("How much money do you have?");
			yourmoney = Convert.ToInt32(Console.ReadLine());
			
			start:
				Console.WriteLine("");
				Console.WriteLine("What currency do you want to convert");
				Console.WriteLine("1. USD");
				Console.WriteLine("2. BATH");
				Console.WriteLine("3. SGD");
				Console.WriteLine("4. YEN");
				Console.WriteLine("5. WON");
				Console.WriteLine("6. POUND");
				Console.WriteLine("7. RINGGIT");
				Console.WriteLine("choose your currency do you want ");
				Choose = Console.ReadLine();
				Console.WriteLine("");
				
				if (Choose == "1")
				{
					yourmoney = yourmoney * Convert.ToInt16(smoney.usd);
					Console.WriteLine("Your Money Is = " + yourmoney + " Rupiah");
				}
				else if (Choose == "2")
				{
					yourmoney = yourmoney * Convert.ToInt16(smoney.bath);
					Console.WriteLine("Your money is = " + yourmoney + " Rupiah");
				}
				else if (Choose == "3")
				{
					yourmoney = yourmoney * Convert.ToInt16(smoney.sgd);
					Console.WriteLine("Your money is = " + yourmoney + " Rupiah");
				}
				else if (Choose == "4")
				{
					yourmoney = yourmoney * Convert.ToInt16(smoney.yen);
					Console.WriteLine("Your money is = " + yourmoney + " Rupiah");
				}
				else if (Choose == "5")
				{
					yourmoney = yourmoney * Convert.ToInt16(smoney.won);
					Console.WriteLine("Your money is = " + yourmoney + " Rupiah");
				}
				else if (Choose == "6")
				{
					yourmoney = yourmoney * Convert.ToInt16(smoney.pound);
					Console.WriteLine("Your money is = " + yourmoney + " Rupiah");
				}
				else if (Choose == "7")
				{
					yourmoney = yourmoney * Convert.ToInt16(smoney.ringgit);
					Console.WriteLine("Your money is = " + yourmoney + " Rupiah");
				}
				else {
					Console.WriteLine("Input Not Valid");
					goto start;
				}
        }
    }
}
