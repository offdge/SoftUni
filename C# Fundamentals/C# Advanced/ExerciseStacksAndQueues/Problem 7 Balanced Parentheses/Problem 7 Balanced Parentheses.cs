﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7_Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            // "{, [, (, ), ], }
            var input = Console.ReadLine();
            var stack = new Stack<char>();

            var flag = true;

            foreach (char para in input)
            {
                switch (para)
                {
                    case '[':
                    case '(':
                    case '{':
                        stack.Push(para);
                        break;

                    case '}':
                        if (!stack.Any())
                            flag = false;

                        else if (stack.Pop() != '{')
                            flag = false;
                        break;

                    case ')':
                        if (!stack.Any())
                            flag = false;

                        else if (stack.Pop() != '(')
                            flag = false;
                        break;

                    case ']':
                        if (!stack.Any())
                            flag = false;

                        else if (stack.Pop() != '[')
                            flag = false;
                        break;
                }

                if (!flag)
                    break;
            }

            // is balanced?
            Console.WriteLine(flag ? "YES" : "NO");
        }
    }
}