using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            var bulletPrice     = int.Parse(Console.ReadLine());
            var gunBarrelSize   = int.Parse(Console.ReadLine());
            var bullets         = new Stack<int>(Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            var locks           = new Queue<int>(Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            var valueOftheIntelligence = int.Parse(Console.ReadLine());
            var bulletsCount = bullets.Count;
            var countReload = 0;

            for (int i = 0; i < bulletsCount; i++)
            {
                if (bullets.Pop() <= locks.Peek())
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                if (++countReload % gunBarrelSize == 0)
                {
                    if (bullets.Count > 0)
                    {
                        Console.WriteLine("Reloading!");
                    }
                }
                if (locks.Count == 0)
                {
                    Console.WriteLine("{0} bullets left. Earned ${1}", bullets.Count, valueOftheIntelligence - ((bulletsCount - bullets.Count) * bulletPrice));
                    break;
                }
            }
            if (locks.Count > 0)
            {
                Console.WriteLine("Couldn't get through. Locks left: {0}", locks.Count);
            }
        }
    }
}
