using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Karaoke
{
	class Program
	{
		public static void Main(string[] args)
		{
			var participants      = Console.ReadLine();
			var availableSongs    = Console.ReadLine();

			var allParticipants = participants
							.Split(',')
							.Select(s => s.Trim())
                          	.ToArray();
			
			var allAvailableSongs = availableSongs
							.Split(',')
							.Select(s => s.Trim())
                          	.ToArray();

			var myDict = new Dictionary <string, List<string>>();
			
			var participantSongAward = Console.ReadLine();
			
				while (participantSongAward != "dawn") 
					{
                      var allParticipantSongAwards = participantSongAward
                                    .Split(',')
                                    .Select(s => s.Trim())
                                    .ToList();
                              
                           var participant = allParticipantSongAwards.First();
                           var song = allParticipantSongAwards[1];
                           var award = allParticipantSongAwards.Last();
                              
                        if (allParticipants.Contains(participant) && allAvailableSongs.Contains(song))
						{    
			              	if (!myDict.ContainsKey(participant))
			              	{
			              		myDict.Add(participant, new List<string>());
			              	}
			              	if (!myDict[participant].Contains(award))
			              	{
			              		myDict[participant].Add(award);
			              	}
                  		}
			           participantSongAward = Console.ReadLine();
					}
                                  
					if (myDict.Keys.Count == 0 )
			              	{
			              		Console.WriteLine("No awards");
			              	}
					
        		var chart = from pair in myDict orderby pair.Value.Count descending, pair.Key select pair;
 
                 foreach (var pair in chart)
                 {
                     Console.WriteLine("{0}: {1} awards" ,pair.Key, pair.Value.Count);
                 
                     var awards = from list in pair.Value orderby list ascending select list;
                 
                    foreach (var award in awards)
                    {
                         Console.WriteLine("--{0}", award);
                    }
            	}

		}
	}
}
		
		
