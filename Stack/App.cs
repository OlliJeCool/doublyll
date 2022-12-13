using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class App
    {
        public void Run()
        {
            var stack = new Stack();
            bool proceed = true;
            while (proceed)
            {
                string[] a = Console.ReadLine().Split(" ");
                Console.Clear();
                if (a.Length < 1)
                {
                    Console.WriteLine("Wrong input!");
                }
                else
                {
                    switch (a[0])
                    {
                        case "push":
                            stack.Push(Parse(a[1]));
                            break;
                        case "pop":
                            stack.Pop();
                            break;
                        case "empty":
                            Console.WriteLine(stack.isEmpty());
                            break;
                        case "top":
                            Item? top = stack.GetTop();
                            if(top != null)
                            {
                                Console.WriteLine(top.Value);
                            }
                            else { Console.WriteLine("Empty!"); }
                            break;
                        case "exit":
                            proceed = false;
                            break;
                        default:
                            Console.WriteLine("Wrong input!");
                            break;
                    }

                }
            }
        }


        public int Parse(string x)
        {
            if(int.TryParse(x, out int result))
            {
                return result;
            }
            else { throw new Exception("Wrong input!"); }
        }
    }
}
