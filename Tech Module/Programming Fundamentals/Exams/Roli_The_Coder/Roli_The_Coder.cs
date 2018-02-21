using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDict = new Dictionary<Dictionary<string, string>, List<string>>();

            var input = Console.ReadLine();
            if (input == string.Empty) return;

            while (input != "Time for Code")
            {
            	
            var inputData = input.Split('@').Select(x => x.Trim()).ToArray();
            var values = inputData.Take(inputData.Length).Skip(1).Distinct().ToList();
            var idName = inputData[0].Split(new[] { '#' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
 
            if (idName.Length < 2) goto Next;
 
            var iD = idName[0];
            var eventName = idName[1];
            
            var keyDict = new Dictionary<string, string>();
            keyDict.Add(iD, eventName);
            var containsKey = false;
            

                foreach (var pair in myDict.Keys)
                {
                    if (pair.ContainsKey(iD))
                    {
                        if (pair.ContainsValue(eventName))
                        {
                            myDict[pair].AddRange(values);
                            containsKey = true;
                        }
                        else goto Next;
                    }
                   
                    else if (!pair.ContainsKey(iD) && pair.ContainsValue(eventName) ) goto Next;
                }

                if (!containsKey) myDict.Add(keyDict, values);

               Next: input = Console.ReadLine();
            }
            var chart = from pair in myDict orderby pair.Value.Count descending, pair.Key select pair;

            foreach (var pair in chart)
            {
                var events = pair.Key.Values.ToList();
                var noDupicates = pair.Value.Distinct().ToList();
                var participants = from list in noDupicates orderby list ascending select list;

                foreach (var member in events) Console.WriteLine("{0} - {1}", member ,noDupicates.Count);
                foreach (var participant in participants) Console.WriteLine("@{0}", participant);
            }
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);            
        }
    }
}