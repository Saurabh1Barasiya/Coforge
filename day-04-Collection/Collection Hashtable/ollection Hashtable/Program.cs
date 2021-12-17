using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ollection_Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hash Table Like a python dictionary.
            // It has no order.
            // Data can not store in order wise .
            // we can acess using key.



            // Syntex 1
            Hashtable ht = new Hashtable();
            ht.Add("Id", 01);
            ht.Add("Name", "amit");
            ht.Add("Ismarried", false);
            ht.Add("Doj", new DateTime(day: 10, month: 12, year: 2021));
            ht.Add("Salary", 10000.00);


            //Console.WriteLine($"Id {ht["Id"]} ");
            //Console.WriteLine($"Name {ht["Name"]} ");
            //Console.WriteLine($"Ismarried {ht["Ismarried"]} ");
            //Console.WriteLine($"Doj {ht["Doj"]} ");
            //Console.WriteLine($"Salary {ht["Salary"]} ");


            // secound syntex.

            Hashtable ht2 = new Hashtable()
            {
                { "Id", 01},
                { "Name", "amit"},
                { "Ismarried", false},
                { "Doj", new DateTime(day: 10,month:12,year:2021)},
                { "Salary", 10000.00},
            };


            //Console.WriteLine("Details of h2 ");
            //Console.WriteLine($"Id {ht2["Id"]} ");
            //Console.WriteLine($"Name {ht2["Name"]} ");
            //Console.WriteLine($"Ismarried {ht2["Ismarried"]} ");
            //Console.WriteLine($"Doj {ht2["Doj"]} ");
            //Console.WriteLine($"Salary {ht2["Salary"]} ");

            // Remove()  - delete a value

            ht2.Remove("Salary");

            //foreach (var item in ht2.Keys)
            //{
            //    Console.WriteLine($"Key {item} value {ht[item]}" );
            //}

            // if you want only value
            //foreach (var item in ht2.Values)
            //{
            //    Console.WriteLine($"value {item} ");
            //}




            // clear() --- it remove all the element from Hashtable.

            ht2.Clear();

            if (ht2.Count == 0)
            {
                Console.WriteLine("empty hash");
            }
            else
            {
                foreach (var item in ht2.Keys)
                {
                    Console.WriteLine($"value {ht[item]} ");
                }

            }



             var c =ht.Contains("Id");  // it returns true or false (bool type).
             dynamic c1 =ht.Contains("age");  // it returns true or false (bool type).
             Console.WriteLine($"Key present  {c1}");

            var v1 = ht.ContainsKey("Id");   // bool
            Console.WriteLine(v1);

            var v2 = ht.ContainsValue("amit"); // bool 
            Console.WriteLine(v2);



            Console.WriteLine("Aman".GetHashCode());

            Console.WriteLine("Id".GetHashCode());






            Console.ReadKey();

        }
    }

}
