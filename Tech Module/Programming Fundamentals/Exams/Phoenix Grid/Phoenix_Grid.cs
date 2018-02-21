using System;
using System.Linq;
using System.Collections.Generic;

namespace Phoenix_Grid
{
	class Program
	{
		public static void Main(string[] args)
		{
			var output = new List <string>();
			var input = Console.ReadLine();
			var checkNo = false;
			
			while (input != "ReadMe")
			{
				output.Add(input);
				input = Console.ReadLine();
			}
			
			foreach (var message in output) 
			{
				if (message.Contains(" ") || message.Contains("_") || message.Length < 3)	Console.WriteLine("NO");
				else
				{
					//^([^_\s]{3})(\.([^_\s]{3}))*$
					var temp = message.Split('.').Where(x => !string.IsNullOrEmpty(x)).ToList();

					foreach (var element in temp) 
					{
						if (element.Length != 3) 
						{
							Console.WriteLine("NO");
							checkNo = true;
							break;
						}
					}
					
					if (!checkNo) 
					{
						var tempString = string.Join("",temp);
						if (tempString == string.Join("",tempString.Reverse()))		Console.WriteLine("YES");
						else														Console.WriteLine("NO");
					}
				}
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}