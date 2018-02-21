using System;

namespace Triangle
{
    class Triangle
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}", new string('#', (4 * n) + 1));

            for (int i = 1; i <= n; i++)
            {

                if (i == n / 2 + 1)
                {
                    Console.WriteLine("{0}{1}{2}(@){2}{1}{0}",
                    new string('.', i),
                    new string('#', (((4 * n) + 1) - (2 * i - 1) - 2 * i) / 2),
                    new string(' ', (i - 2)));
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}",
                    new string('.', i),
                    new string('#', (((4 * n) + 1) - (2 * i - 1) - 2 * i) / 2),
                    new string(' ', (2 * i - 1)));
                }
            }

            for (int j = 1; j <= n; j++)
            {
                Console.WriteLine("{0}{1}{0}",
                    new string('.', n + j),
                    new string('#', ((4 * n) + 1) - 2 * (n + j)));
            }
        }
    }
}
