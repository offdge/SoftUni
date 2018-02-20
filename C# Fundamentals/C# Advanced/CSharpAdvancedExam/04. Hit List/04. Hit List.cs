using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Hit_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDict = new Dictionary<string, Dictionary<string, string>>();
            var targetInfoindex = int.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            //////////Dictionary Fill
            while (input != "end transmissions")
            {
                var firstSplit = input.Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
                var secondSplit = firstSplit[1].Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
                var name = firstSplit[0];

                if (!myDict.ContainsKey(name))
                {
                    myDict.Add(name, new Dictionary<string, string>());
                }
                foreach (var item in secondSplit)
                {
                    var thirdSplit = item.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
                    var infoKey = thirdSplit[0];
                    var infoValue = thirdSplit[1];

                    if (myDict[name].ContainsKey(infoKey))
                    {
                        myDict[name][infoKey] = infoValue;
                    }
                    else
                    {
                        myDict[name].Add(infoKey, infoValue);
                    }
                }
                input = Console.ReadLine();
            }
            var killInput = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            //////////Output
            Console.WriteLine("Info on {0}:", killInput[1]);

            foreach (var item in myDict.Where( x => x.Key == killInput[1]))
            {
                var keyLengthCount = 0;
                foreach (var element in item.Value.OrderBy(x => x.Key))
                {
                    Console.WriteLine("---{0}: {1}", element.Key, element.Value);
                    keyLengthCount += element.Key.Length + element.Value.Length;
                }
                
                Console.WriteLine("Info index: {0}", keyLengthCount);
                
                if (keyLengthCount > targetInfoindex)
                {
                    Console.WriteLine("Proceed");
                }
                else
                {
                    Console.WriteLine("Need {0} more info.", targetInfoindex - keyLengthCount);
                }
            }
        }
    }
}