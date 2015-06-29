using System;

namespace cashier_csharp
{
	class MainClass
	{
		public static Main (string[] args)
		{
			due = AmtDueInput();
			tendered = AmtTenderedInput();
			totalDiff = Calculate(due, tendered);
			Console.Write (System.Environment.NewLine + "Your change is: {0}", totalDiff);
		}

		public static string AmtDueInput()
		{
			string amtDue;
			Console.Write (System.Environment.NewLine + "What is the amount due? ");
			Console.Write ("The amount due is: {0}", amtDue = Console.ReadLine());
			if (AmtCheck (amtDue) == false) {
				AmtDueInput ();
			} else {
				return amtDue;
			}

		}

		public static string AmtCheck(string amt)
		{
			string pattern = "[A-Za-z]";

			if (System.Text.RegularExpressions.Regex.IsMatch (amt, pattern)) {
				Console.Write (System.Environment.NewLine + "Wrong input type");
				return false;
			} else {
				return true;
			}
		
		}

		public static string AmtTenderedInput ()
		{
			string amtTendered;
			Console.Write (System.Environment.NewLine + "What is the amount tendered?");
			Console.Write ("The amount tendered is: {0}", amtTendered = Console.ReadLine ());
			if (AmtCheck (amtTendered) == false) {
				AmtTenderedInput ();
			} else {
				return amtTendered;
			}
		}


		public static double Calculate(string due, string tendered)
		{
			float diff = (Convert.ToDouble (due)) - (Convert.ToDouble (tendered));
			return diff;
		}
	}
}