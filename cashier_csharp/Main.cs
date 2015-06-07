using System;

namespace cashier_csharp
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			InitialEntry ();
		}

		public static void InitialEntry()
		{
			string amtDue;
			Console.Write (System.Environment.NewLine + "What is the amount due? ");
			Console.Write ("The amount you entered is: {0}", amtDue = Console.ReadLine());
			AmtDueCheck (amtDue);
		}

		public static void AmtDueCheck(string amtDue)
		{
			string pattern = "[A-Za-z]";

			if (System.Text.RegularExpressions.Regex.IsMatch(amtDue, pattern)) {
				Console.Write (System.Environment.NewLine + "Wrong input type");
				InitialEntry ();
			}
		}
	}
}