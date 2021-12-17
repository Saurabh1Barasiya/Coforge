using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            // It works LiFO principle.
            // Last IN FIRST OUT.
            // push -- add element
            // pop -- return and delete element
            // peek --> it will give you top value.
            // it will work on diffrent data type as well.

            Stack s = new Stack();
            s.Push(10);
            s.Push(20);
            s.Push(30);
            s.Push(40);
            //foreach (var item in s)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine();

            s.Push("sam");
            s.Push("ram");


             var d= s.Pop();
            Console.WriteLine($"deleted item {d}");


            Console.WriteLine("-------------------------------------------");

            foreach (var item in s)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(s.Contains("sam"));
            Console.WriteLine($"Totel element {s.Count}");
            Console.WriteLine($"top value {s.Peek()}"); 
            Console.ReadLine();
        }
    }
}
