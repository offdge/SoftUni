using System;
using System.Text.RegularExpressions;

namespace Regexmon
{
	class Program
	{
		public static void Main(string[] args)
		{
	        var currentInput = Console.ReadLine();
	        var didomon = new Regex(@"[^A-Za-z-]+");
	        var bojomon = new Regex(@"[A-Za-z]+-[A-Za-z]+");
	        var currentPattern = didomon;
	        var currentMatch = currentPattern.Match(currentInput);
	 
	        while (currentMatch.Success)
	        {
	            Console.WriteLine(currentMatch.Value);
	            currentInput = currentInput.Remove(0, currentMatch.Index + currentMatch.Length);
	 
	            if (currentPattern == didomon) currentPattern = bojomon;
	            else currentPattern = didomon;
	 
	            currentMatch = currentPattern.Match(currentInput);
	        }
	        
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}