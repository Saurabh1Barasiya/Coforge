using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jaccked_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr1 = new int[3][];
            arr1[0] = new[]  { 1, 2, 3 };
            arr1[1] = new[]  { 1,2,3,4,5};
            arr1[2] = new[]  { 1,2,3,4,5,6,7,8};

            Console.WriteLine("first");
            Console.WriteLine(arr1[0][0]);
            Console.WriteLine(arr1[0][1]);
            Console.WriteLine(arr1[0][2]);

            Console.WriteLine("secound");
            Console.WriteLine(arr1[1][0]);
            Console.WriteLine(arr1[1][1]);
            Console.WriteLine(arr1[1][2]);
            Console.WriteLine(arr1[1][3]);
            Console.WriteLine(arr1[1][4]);

            Console.WriteLine("third");
            Console.WriteLine(arr1[2][0]);
            Console.WriteLine(arr1[2][1]);
            Console.WriteLine(arr1[2][2]);
            Console.WriteLine(arr1[2][3]);
            Console.WriteLine(arr1[2][4]);
            Console.WriteLine(arr1[2][5]);
            Console.WriteLine(arr1[2][6]);
            Console.WriteLine(arr1[2][7]);


            Console.WriteLine("----------------------------");

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine($"---- {i} array-------------");
                for (int j = 0; j < arr1[i].Length; j++)
                {
                    Console.Write(arr1[i][j]);
                }
                Console.WriteLine();
            }


            // using foreach loop
            Console.WriteLine("using foreach loop");
            foreach (var row in arr1)
            {
                foreach (var val in row)
                {
                    Console.Write(val);
                }

            }



            //int[,] arr2 = new int[2, 3] { {1,2,3 }, {4,5,6 } };
            //int[,] arr2 = new int[,] { {1,2,3 }, {4,5,6 } };
            int[,] arr2 = { {1,2,3 }, {4,5,6 } };

            Console.WriteLine("-----------------arr2---------------------");
            foreach (var item in arr2)
            {
                Console.Write(item);
            }

            Console.ReadKey();
        }
    }
}
