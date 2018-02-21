using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
 
class EnduranceRally
{
    public static void Main()
    {
    	var drivers = Console.ReadLine().Split(' ');
    	var zones = Console.ReadLine().Split(' ').Select(s=>s.Trim()).Select(s=>double.Parse(s)).ToList();
    	var checkpoints = Console.ReadLine().Split(' ').Select(s=>s.Trim()).Select(s=>int.Parse(s)).ToArray();
    	var sumLiters = 0.0;

    	foreach (var driver in drivers)
    	{
    		sumLiters = driver[0];
    		
    		for (int i = 0; i < zones.Count; i++)
    	      {	
    				if (checkpoints.Contains(i))
    				{
    					sumLiters += zones[i];
    				}
    				else 
    				{
    					sumLiters -= zones[i];
    					
    					if (sumLiters <= 0) 
    					{
    						var lastZone = i;
    						Console.WriteLine("{0} - reached {1}", driver,lastZone);		
    						break;
    					}
    				}
    		  }
    	      if (sumLiters > 0) Console.WriteLine("{0} - fuel left {1:f2}",driver ,sumLiters);	
    	}
	}
}