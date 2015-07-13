using System;

namespace cashier_csharp
{
	class Program
	{
		public static void Main(string[] args)
		{
			string due = AmtDueInput();
			string tendered = AmtTenderedInput();
			decimal totalDiff = Calculate(due, tendered);
			
			Console.WriteLine("Your change is " + totalDiff);
			Console.ReadLine();
		}
		
		public static string AmtDueInput()
		{
			string amtDue;
			Console.WriteLine(System.Environment.NewLine + "What is the amount due? ");
			Console.WriteLine("The amount due is: {0}", amtDue = Console.ReadLine());
			if (AmtCheck (amtDue) == false) {
				return AmtDueInput ();
			} else {
				return amtDue;
			}
			
		}
		
		public static bool AmtCheck(string amt)
		{
			string pattern = "[A-Za-z]";
			
			if (System.Text.RegularExpressions.Regex.IsMatch (amt, pattern)) {
				Console.WriteLine(System.Environment.NewLine + "Wrong input type");
				return false;
			} else {
				return true;
			}
			
		}
		
		public static string AmtTenderedInput()
		{
			string amtTendered;
			Console.WriteLine(System.Environment.NewLine + "What is the amount tendered?");
			Console.WriteLine("The amount tendered is: {0}", amtTendered = Console.ReadLine());
			if (AmtCheck (amtTendered) == false) {
				return AmtTenderedInput();
			} else {
				return amtTendered;
			}
		}
		
		
		public static decimal Calculate(string due, string tendered)
		{
			decimal diff = Convert.ToDecimal(due) - Convert.ToDecimal(tendered);
			return diff;
		}
	}
}