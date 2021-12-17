using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            // In array we can not improve the size.
            // So we use ArrayList(Collection)  its like a python list , store multiple datatype as well.
            ArrayList arr1 = new ArrayList();
            arr1.Add(10);
            arr1.Add(20);
            arr1.Add(30);
            arr1.Add(40);
            arr1.Add(50);
            Console.WriteLine($"Size of the array is {arr1.Count}");
            //foreach (var item in arr1)
            //{
            //    Console.Write($"{item } ");
            //}
            //Console.WriteLine();
            //Console.WriteLine($"Capacity of array is  {arr1.Capacity}");   
            


            arr1.Add("sam");
            arr1.Add("jam");
            arr1.Add(4.2);
            arr1.Add(5321523.52);



            //foreach (var item in arr1)
            //{
            //    Console.Write($"{item } ");
            //}


            // delete data 

            // arr1.Remove("sam");  direct delection

            //arr1.RemoveAt(0);  // Index vise delection

            // ------- Insert --------------

            arr1.Insert(0, "First");

            var inde = arr1.IndexOf("First");
            Console.WriteLine($"Index is  {inde}");

            arr1.Clear(); // delete all the element in the array.

            if (arr1.Count == 0)
            {
                Console.WriteLine("Array list is Empty");
            }
            else
            {
                foreach (var item in arr1)
                {
                    Console.Write($"{item } ");
                }
            }


            ArrayList arr2 = new ArrayList();
            arr2.Add(5);
            arr2.Add(1);
            arr2.Add(100);
            arr2.Add(10);
            arr2.Add(20);
            arr2.Add(56);


            arr2.Sort();


            Console.WriteLine("Sorted Array");
            foreach (var item in arr2)
            {
                Console.Write($"{item } ");
            }


            Console.ReadKey();


        }
    }
}
