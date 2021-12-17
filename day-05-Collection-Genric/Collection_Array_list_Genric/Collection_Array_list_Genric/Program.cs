using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Collection_Array_list_Genric
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr1 = new List<int>();
            arr1.Add(10);
            arr1.Add(20);
            arr1.Add(30);
            arr1.Add(40);

            List<string> arr2 = new List<string>();
            arr2.Add("Sam");
            arr2.Add("Jam");
            arr2.Add("Tam");
            arr2.Add("Pam");

            List<bool> arr3 = new List<bool>();
            arr3.Add(true);
            arr3.Add(true);
            arr3.Add(true);
            arr3.Add(false);
            arr3.Add(false);

            Console.WriteLine("Integer Data ");
            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("String Data ");
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Bool Data ");
            foreach (var item in arr3)
            {
                Console.WriteLine(item);
            }




            Console.ReadKey();
        }
    }
}
