using System;
using System.Linq;

namespace Pokemon_Don_t_Go
{
	class Program
	{
		public static void Main()
		{
			var sequence 	= Console.ReadLine().Split(' ').Select(s => s.Trim()).Select(int.Parse).ToList();
			var incDecrease = 0;
			var output 		= 0;
			
			while (sequence.Count > 0) 
			{	
				var index = int.Parse(Console.ReadLine());
				
				if (index < 0)
				{
					incDecrease = sequence.First();
					sequence[0] = sequence.Last();
				}
				else if (index >= sequence.Count)
				{
					incDecrease = sequence.Last();
					sequence[sequence.Count-1] 	= sequence.First();
				}
				else
				{
					incDecrease = sequence[index];
					sequence.RemoveAt(index);
				}
				
				output += incDecrease;
				
				for (int i = 0; i < sequence.Count; i++) 
				{
					if (sequence[i] <= incDecrease ) sequence[i] += incDecrease;
					else sequence[i] -= incDecrease;
				}
			}

			Console.WriteLine(output);
		}
	}
}