using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Dectionary_Genric
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary
            // it is a genric type.
            // Contain Key and Value.

            // If you declare a dictionary in a specfic data type so its always same data type value.

            Dictionary<int, string> myDict = new Dictionary<int, string>();
            myDict.Add(1, "Amit");
            myDict.Add(2, "Rahul");
            myDict.Add(3, "Tinu");
            myDict.Add(4, "Basant");
            myDict.Add(5, "Jinna");

            foreach (KeyValuePair<int,string> item in myDict)
            {
                Console.WriteLine($"Key {item.Key} and value {item.Value}");
            }
            

            Console.WriteLine("--------------------------------------------------");

            foreach (var item in myDict.Keys)
            {
                Console.WriteLine($"Key {item} and Value {myDict[item]}");
            }


            Console.WriteLine($"Id greater than 3 is {myDict.Count(e => e.Key > 3)}");


            Console.ReadKey();
        }
    }
}
