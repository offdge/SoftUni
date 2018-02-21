using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HornetComm
{
    class Program
    {
        public static void Main(string[] args)
        {
            var messages = new List<Data>();
            var broadcasts = new List<Data>();
            var input = Console.ReadLine();
            
            while (input != "Hornet is Green")
            {
                var messageRegex = Regex.Match(input, @"^(?<recipient>[\d]+) <-> (?<recipientMessage>[a-zA-Z0-9]+)$");
                if (messageRegex.Success)
                {
                    var recipient 			= messageRegex.Groups["recipient"].Value;
                    var recipientMessage	= messageRegex.Groups["recipientMessage"].Value;
                    var message 			= new Data { FirstQuery = recipient, SecondQuery = recipientMessage };
                    messages.Add(message);
                }

                var broadcastRegex = Regex.Match(input, @"^(?<frequency>[^\d]+) <-> (?<broadcastMessage>[a-zA-Z0-9]+)$");
                if (broadcastRegex.Success)
                {
                    var frequency 			= broadcastRegex.Groups["frequency"].Value;
                    var broadcastMessage	= broadcastRegex.Groups["broadcastMessage"].Value;
                    var broadcast 			= new Data { FirstQuery = frequency, SecondQuery = broadcastMessage };
                    broadcasts.Add(broadcast);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count > 0)
            {
                foreach (var broadcast in broadcasts)
                {
                    var lowerToUpper = broadcast.SecondQuery.ToList();
					
                    for (int i = 0; i < broadcast.SecondQuery.Length; i++)
                    {
                        if (char.IsLetter(broadcast.SecondQuery[i]))
                        {
                            if (char.IsLower(broadcast.SecondQuery[i]))			lowerToUpper[i] = char.ToUpper(broadcast.SecondQuery[i]);
                            else 												lowerToUpper[i] = char.ToLower(broadcast.SecondQuery[i]);
                        }
                    }
                    Console.WriteLine("{0} -> {1}", string.Join("", lowerToUpper), broadcast.FirstQuery);
                }
            }
            else	Console.WriteLine("None");

            Console.WriteLine("Messages:");
            if (messages.Count > 0) 	messages.ForEach(i => Console.WriteLine("{0} -> {1}", string.Join("", i.FirstQuery.Reverse()), i.SecondQuery));
            else						Console.WriteLine("None");

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
public class Data
{
    public string FirstQuery { get; set; }
    public string SecondQuery { get; set; }
}