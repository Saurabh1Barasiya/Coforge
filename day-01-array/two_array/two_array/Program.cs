using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[3, 4] // Rectangular array.
            {
                {1,2,3,4},
                {5,6,7,8},
                {8,9,10,11}
            };

            Console.WriteLine($"Dimension of arry {arr1.Rank}");
            Console.WriteLine($"length of rows {arr1.GetLength(0)}");  //new int[3, 4]
            Console.WriteLine($"length of columns {arr1.GetLength(1)}");  //new int[3, 4]


            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr1.GetLength(1); j++)
            //    {
            //        Console.Write($"{arr1[i, j]} \t");
            //    }
            //    Console.WriteLine();
            //}


            foreach (var i in arr1)
            {
                Console.Write($"{ i} ");
            }

            Console.ReadKey();
        }
    }
}
