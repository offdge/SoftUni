using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
	class Program
	{
		public static void Main(string[] args)
		{
    		var input = Console.ReadLine().Split(' ').Select(s=>s.Trim()).Select(s=>int.Parse(s)).ToArray();
    		var result = (from element in input.Where(element => element > input.Average() ) orderby element descending select element).ToArray();
    		
    		if (input.Length == 1 || result.Length == 0)	Console.WriteLine("No");
    		else											Console.WriteLine(string.Join(" ", result.Take(5)));

		}
	}
}