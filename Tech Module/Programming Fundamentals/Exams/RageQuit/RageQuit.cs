using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace RageQuit
{
	class Program
	{
		public static void Main(string[] args)
		{
            var input = Console.ReadLine();   
            var pattern = @"(\D+)(\d+)";
            var regexMatch = Regex.Match(input, pattern);
            var rageMessage = new List <string>();
            
            while (regexMatch.Success) 
            {
                var stringToUpper = regexMatch.Groups[1].Value.ToUpper();
                int numberOfReps = int.Parse(regexMatch.Groups[2].Value);

                for (int i = 0; i < numberOfReps; i++)
                {
                    rageMessage.Add(stringToUpper);
                }

                regexMatch = regexMatch.NextMatch();
            }
                
            var symbolsCount = String.Join("",rageMessage).Distinct().Count();

            Console.WriteLine("Unique symbols used: {0}", symbolsCount);
            Console.WriteLine(String.Join("",rageMessage));
            
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}