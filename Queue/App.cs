﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class App
    {
        public void Run()
        {
            var queue = new Queue();
            bool proceed = true;
            while (proceed)
            {
                string[] a = Console.ReadLine().Split(" ");
                Console.Clear();
                if (a.Length < 1)
                {
                    Console.WriteLine("Bad input!");
                }
                else
                {
                    switch (a[0])
                    {
                        case "push":
                            int temp;
                            if ((temp = Parse(a[1])) != int.MaxValue) { queue.Insert(temp); }
                            break;
                        case "remove":
                            queue.Remove();
                            break;
                        case "empty":
                            Console.WriteLine(queue.isEmpty());
                            break;
                        case "first":
                            Item? top = queue.getFirst();
                            if (top != null)
                            {
                                Console.WriteLine($"First item is: {top.Value}");
                            }
                            else { Console.WriteLine("Empty!"); }
                            break;
                        case "exit":
                            proceed = false;
                            break;
                        default:
                            Console.WriteLine("Bad input!");
                            break;
                    }
                }
            }
        }
        public int Parse(string x)
        {
            if (int.TryParse(x, out int result))
            {
                return result;
            }
            else { Console.WriteLine("Bad input!"); return int.MaxValue; }
        }
    }
}
