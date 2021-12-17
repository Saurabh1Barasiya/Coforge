using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection_Qube
{
    class Program
    {
        static void Main(string[] args)
        {
            // Queue -> A line or Sequence of people.
            // work in FIFO principle First in first out.

            Queue q = new Queue();
            q.Enqueue(10);  // insert data.
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(40);

            //var d = q.Dequeue();
            //Console.WriteLine($"Deleted item {d}");


            Console.WriteLine($"Peek value {q.Peek()}");
            Console.WriteLine($"Totel value {q.Count}");

            Console.WriteLine(q.Contains(40));

            q.Clear();
            if (q.Count == 0)
            {
                Console.WriteLine("Emplty queue");
            }
            else {
                foreach (var item in q)
                {
                    Console.WriteLine(item);
                }
            }

            
            Console.ReadKey();
        }
    }
}
