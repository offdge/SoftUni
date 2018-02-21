using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileNumber = int.Parse(Console.ReadLine());
            var allInput = new List<string>();
            var revisedInput = new List<string>();
           	var myDict = new Dictionary< string,long>();
           	var checkNo = true;
            
            for (int i = 0; i < fileNumber; i++)
            {
            	allInput.Add(Console.ReadLine());
            }
            
            var query = Console.ReadLine().Split(' ').ToArray();
            var queryRoot = query[2];
            var queryExtension = query[0];
            
            foreach (var element in allInput)
            { 
            	if (element.StartsWith(query[2]) && element.Contains("." + query[0] + ";"))
            	{
            		revisedInput.Add(element);
            		checkNo = false;
            	}
            }
            
            if (checkNo)
            {
            	Console.WriteLine("No");
            }
            
            else
            {
	            foreach (var element in revisedInput) 
	            {
	                var firstSplit = element.Split('\\').Where(x => !string.IsNullOrEmpty(x)).ToArray();
	                var secondSplit = firstSplit[firstSplit.Length-1].Split(';').ToArray();
	                var filename = secondSplit[0];
	                var filesize = long.Parse(secondSplit[1]);
	                
	                myDict.Add(filename,filesize);
	            }
	            
	            var result = from pair in myDict orderby pair.Value descending, pair.Key select pair;
	 
	            foreach (var element in result) 
	            {
	            	Console.WriteLine("{0} - {1} KB",element.Key,element.Value);
	            }
            }

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
        }
    }
}