using System;
using System.Numerics;

namespace Sino_The_Walker
{
	class Program
	{
		public static void Main(string[] args)
		{
			var timeThatSinoLeaves = Console.ReadLine();
			var numberOfSteps = int.Parse(Console.ReadLine());
			BigInteger timeForEachSteps = int.Parse(Console.ReadLine());
			
			string[] timeArray = timeThatSinoLeaves.Split(':');		
			
			var hoursToSeconds 	 = int.Parse(timeArray[0]) * 3600 ;
			var minutesToSeconds = int.Parse(timeArray[1]) * 60;
			var secondsToSeconds = int.Parse(timeArray[2]);
			
			var sumTimeSec = hoursToSeconds + minutesToSeconds + secondsToSeconds;
				
			var walkingTime = numberOfSteps*timeForEachSteps ;
			
			var totalTimeSeconds = sumTimeSec + walkingTime;
			
			var hoursArrive   = (totalTimeSeconds / 3600)  % 24;
			var minutesArrive = (totalTimeSeconds % 3600) / 60 ;
			var secondsArrive = (totalTimeSeconds % 60);

			Console.WriteLine ("Time Arrival: {0:00}:{1:00}:{2:00}",hoursArrive, minutesArrive, secondsArrive );
		}
	}
}