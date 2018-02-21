using System;
using System.Linq;

namespace LastKNumbersSumsSequence
{
	class Program
	{
		public static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var k = int.Parse(Console.ReadLine());
			 
			long[] array = new long[n + k];
			array[k] = 1;
			
			for (int i = 1; i < n; i++)
			{
				array[k+i] = array.Skip(i).Take(k).Sum();
			}
			
			Console.WriteLine( string.Join( " ", array.Skip(k)));
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}