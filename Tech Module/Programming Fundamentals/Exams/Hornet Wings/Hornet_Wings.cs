using System;

namespace Hornet_Wings
{
	class Program
	{
		public static void Main()
		{
			var wingFlaps 		= long.Parse(Console.ReadLine());
			var distance  		= double.Parse(Console.ReadLine());
			var endurance 		= int.Parse(Console.ReadLine());
			var hornetRest 		= (wingFlaps / endurance) * 5 ;
			var metersTraveled 	= (wingFlaps / 1000) * distance ;
			var secondsPassed 	= (wingFlaps / 100) + hornetRest;
			
			Console.WriteLine("{0:f2} m.",metersTraveled);
			Console.WriteLine("{0} s.",secondsPassed);
		}
	}
}