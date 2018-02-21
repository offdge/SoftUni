using System;
using System.Collections.Generic;
using System.Linq;

namespace Hornet_Armada
{
    class Program
    {
        public static void Main(string[] args)
        {
            var mainDict = new Dictionary<string, long>();
            var armada = new List<Evolution>();
            var inputCount = int.Parse(Console.ReadLine());
            var result = new List<Evolution>();


            for (int i = 0; i < inputCount; i++)
            {
                var firstSplit = Console.ReadLine().Split(' ').Where(x => !string.IsNullOrEmpty(x)).ToArray();
                var secondSplit = firstSplit[4].Split(':').Where(x => !string.IsNullOrEmpty(x)).ToArray();
                var lastActivity = int.Parse(firstSplit[0]);
                var legionName = firstSplit[2];
                var soldierType = secondSplit[0];
                var soldierCount = int.Parse(secondSplit[1]);
                var evolution = new Evolution { lastActivity = lastActivity, legionName = legionName, soldierType = soldierType, soldierCount = soldierCount };

                armada.Add(evolution);
            }

            var legions = from evo in armada select evo.legionName;
            var legionsDistinct = legions.Distinct().ToList();

            foreach (var legion in legionsDistinct)
            {
                var highestActivity = from activity in armada where activity.legionName == legion select activity.lastActivity;
                var maxActivity = highestActivity.Max();

                foreach (var evol in armada)
                {
                    if (evol.legionName == legion)
                    {
                        evol.lastActivity = maxActivity;
                    }
                }
            }

            var command = Console.ReadLine().Split('\\').Where(x => !string.IsNullOrEmpty(x)).ToArray();

            if (command.Length > 1)
            {
                foreach (var evo in armada)
                {
                    if (evo.soldierType == command[1] && evo.lastActivity < int.Parse(command[0]))
                    {
                        result.Add(evo);
                    }
                }

                var keys = from evolution in result select evolution.legionName;
                var keysDistinct = keys.Distinct();

                foreach (var key in keysDistinct)
                {
                    mainDict.Add(key, 0);
                }

                foreach (var key in keysDistinct)
                {
                    foreach (var evo in result)
                    {
                        if (key == evo.legionName)
                        {
                            mainDict[evo.legionName] += evo.soldierCount;
                        }
                    }
                }

                var sortDict = from pair in mainDict orderby pair.Value descending, pair.Key select pair;

                foreach (var pair in sortDict)
                {
                    Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
                }
            }

            else
            {
                foreach (var evo in armada)
                {
                    if (evo.soldierType == command[0])
                    {
                        result.Add(evo);
                    }
                }

                var keys = from evolution in result select evolution.legionName;
                var keysDistinct = keys.Distinct();

                foreach (var key in keysDistinct)
                {
                    mainDict.Add(key, 0);
                }

                foreach (var key in keysDistinct)
                {
                    foreach (var evo in result)
                    {
                        if (key == evo.legionName)
                        {
                            mainDict[evo.legionName] = evo.lastActivity;
                        }
                    }
                }

                var sortDict = from pair in mainDict orderby pair.Value descending, pair.Key select pair;

                foreach (var pair in sortDict)
                {
                    Console.WriteLine("{1} : {0}", pair.Key, pair.Value);
                }
            }

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}

public class Evolution
{
    public int 		lastActivity 	{ get; set; }
    public string 	legionName 		{ get; set; }
    public string 	soldierType 	{ get; set; }
    public int 		soldierCount 	{ get; set; }
}