using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8_Recursive_Fibonacci
{
    class Program
    {
        private static long[] memo;

        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            memo = new long[n + 1];
            Console.WriteLine(GetFibonacci(n));
        }

        private static long GetFibonacci(long n)
        {
            if (n <= 2)
            {
                return 1;
            }

            if (memo[n] == 0)
            {
                memo[n] = GetFibonacci(n - 1) + GetFibonacci(n - 2);
            }

            return memo[n];
        }
    }
}