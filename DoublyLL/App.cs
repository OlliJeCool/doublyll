﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLL
{
    public class App
    {
        public void Run()
        {
            var doublyll = new doublyLL();
            bool proceed = true;
            while (proceed)
            {
                Console.Write("Array printed from head to tail: ");
                doublyll.Print();
                Console.Write("Array printed in reverse: ");
                doublyll.PrintRev();
                Console.Write("\n Input: ");
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
                        case "insert":
                            if (a.Length == 3)
                            {
                                var temp = Parse(a[2]);
                                if (temp != int.MaxValue)
                                {
                                    switch (a[1])
                                    {
                                        case "-h":
                                            doublyll.insertHead(temp);
                                            break;
                                        case "-t":
                                            doublyll.insertTail(temp);
                                            break;
                                        default:
                                            Console.WriteLine("Bad input!");
                                            break;
                                    }
                                }
                            }
                            if (a.Length == 4)
                            {
                                var item = doublyll.GetItem(Parse(a[2]));
                                var temp = Parse(a[3]);
                                if (item != null)
                                {
                                    switch (a[1])
                                    {
                                        case "-i":
                                            doublyll.insertInf(item, temp);
                                            break;
                                        case "-b":
                                            doublyll.insertBehind(item, temp);
                                            break;
                                        default:
                                            Console.WriteLine("Bad input!");
                                            break;
                                    }
                                }
                                else { Console.WriteLine("Item does not exist!"); }
                            }
                            break;
                        case "delete":
                            if (a.Length == 2)
                            {
                                switch (a[1])
                                {
                                    case "-h":
                                        doublyll.DeleteHead();
                                        break;
                                    case "-t":
                                        doublyll.DeleteTail();
                                        break;
                                    default:
                                        Console.WriteLine("Bad input!");
                                        break;

                                }
                            }
                            if (a.Length == 3)
                            {
                                var item = Parse(a[2]);
                                if (item != int.MaxValue)
                                {
                                    switch (a[1])
                                    {
                                        case "-i":
                                            doublyll.Delete(doublyll.GetItem(item));
                                            break;
                                        default:
                                            Console.WriteLine("Bad input!");
                                            break;
                                    }
                                }
                            }
                            break;
                        case "indexof":
                            var tempi = Parse(a[1]);
                            if (tempi != int.MaxValue)
                            {
                                Console.WriteLine($"Index of {tempi} in the list is: {doublyll.indexOf(tempi)}");
                            }
                            else { Console.WriteLine("Bad input!"); }
                            break;
                        case "contains":
                            var num = Parse(a[1]);
                            if (num != int.MaxValue)
                            {
                                var res = doublyll.Contains(num) ? "The list contains this item." : "The list does not contain this item.";
                                Console.WriteLine(res);
                            }
                            else { Console.WriteLine("Bad input!"); }
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
