using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {

            // here we  learn about array.

            // creating one dimensional array.

            //------------------------first way---------------------------------
            //int[] arr1 = new int[4];
            //arr1[0] = 1;
            //arr1[1] = 2;
            //arr1[2] = 3;
            //arr1[3] = 4;

            //---------------- secound  way ---------------------------

            //int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6 };

            // ------------------------------third  way-------------------------

            string[] arr1 = { "sam", "ram", "pam", "jam" };
            //arr1.Append("kam");

            Console.WriteLine("Index \t vallue");
            for(int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine($"{i} \t {arr1[i]}");
            }

            Console.WriteLine($"Lenght of array is {arr1.Length}");
            Console.WriteLine($"First element of sequence {arr1.First()}");


            double[] ab = new double[] { 5.00, 6.00, 4.00, 8.00 };
            foreach (double item in ab)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
