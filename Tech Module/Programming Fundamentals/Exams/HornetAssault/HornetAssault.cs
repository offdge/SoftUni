    using System;
    using System.Collections.Generic;
    using System.Linq;

namespace HornetAssault
{
	class Program
	{
		public static void Main(string[] args)
		{
            var beehives 		= Console.ReadLine().Split().Select(long.Parse).ToList();
            var hornets 		= Console.ReadLine().Split().Select(long.Parse).ToList();
            var powerOfHornets 	= hornets.Sum();

            for (int i = 0; i < beehives.Count; i++)
            {
            	if (hornets.Count == 0) break;
            	
                if (beehives[i] >= powerOfHornets)
                {
                    beehives[i] -= powerOfHornets;
                    hornets.RemoveAt(0);
                }
                
                else	beehives[i] = 0;

                powerOfHornets = hornets.Sum();
            }

            if (beehives.Any(e => e > 0))	Console.Write(string.Join(" ",beehives.Where(e => e > 0)));
            else							Console.WriteLine(string.Join(" ",hornets));

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}