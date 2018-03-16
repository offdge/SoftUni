using System;

namespace Minedraft
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var hammer = new HammerHarvester("Patzo", -12, 10);
            }
            catch (Exception x)
            {
                Console.WriteLine(x);
            }
        }
    }
}
