﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5_Calculate_Sequence_with_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());

            var queue = new Queue<long>();
            queue.Enqueue(n);
            int index = 0;

            while (queue.Count > 0)
            {
                index++;
                long current = queue.Dequeue();
                Console.Write(current + " ");
                if (index == 50)
                {
                    Environment.Exit(0);
                }
                queue.Enqueue(current + 1);
                queue.Enqueue(2 * current + 1);
                queue.Enqueue(current + 2);
            }
        }
    }
}