using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
  
            var fieldSize = int.Parse(Console.ReadLine());
            var ladybugsIndexes = Console.ReadLine().Split(' ').Select(s => s.Trim()).Select(int.Parse).ToArray();
            var ladybugsField = new int[fieldSize];

            for (int i = 0; i < fieldSize; i++)
            {
                if (ladybugsIndexes.Contains(i)) ladybugsField[i] = 1;
            }

            var input = Console.ReadLine();

            while (input != "end")
            {
                var commands = input.Split(' ').Select(s => s.Trim()).ToList();
                var ladybugIndex = int.Parse(commands[0]);
                var direction = commands[1];
                var flyLength = int.Parse(commands[2]);

                if (direction == "left") flyLength = -flyLength;
                
                var fieldsToMove = flyLength;
                
                if (ladybugIndex >= 0 && ladybugIndex < fieldSize)
                {	
                	if (ladybugsField[ladybugIndex] == 1)
                	{
                		ladybugsField[ladybugIndex] = 0;
                	}
                	else break;
                	
                }
                

                if (ladybugIndex + fieldsToMove >= 0 && ladybugIndex + fieldsToMove < fieldSize)
                {
                    if (ladybugsField[ladybugIndex + fieldsToMove] == 0)
                    {
                        ladybugsField[ladybugIndex + fieldsToMove] = 1; 
                    }
                    
                    else if (ladybugsField[ladybugIndex + fieldsToMove] == 1)
                    {
                        fieldsToMove += flyLength;
                        
                        while (ladybugIndex + fieldsToMove >= 0 && ladybugIndex + fieldsToMove < fieldSize)
                        {
                        	if (ladybugsField[ladybugIndex + fieldsToMove] == 0)
                        	{
                        		ladybugsField[ladybugIndex + fieldsToMove] = 1;
                        		
                        		break;
                        	}
                        	
                        	fieldsToMove +=flyLength;
                        }
                    }
                }
                
               input = Console.ReadLine(); 
            }

            Console.Write(string.Join(" ", ladybugsField));
        }
    }
}
