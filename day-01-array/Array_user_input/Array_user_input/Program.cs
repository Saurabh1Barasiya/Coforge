using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_user_input
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int num;
            
            Console.WriteLine("Please enter how  many number you want");
            num = int.Parse(Console.ReadLine());

            int[] arr1 = new int[num];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Enter element {i}");
                arr1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Your Array here");
            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }
            */

            // 2D Arraay

            int row, col;
            Console.WriteLine("Please enter rows");
            row = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter column");
            col = int.Parse(Console.ReadLine());

            int[,] arr1 = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                Console.WriteLine($"Please enter {i} array ");
                for (int j = 0; j < col; j++)
                {
                    arr1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Your array as follows ");
            foreach (var item in arr1)
            {
                Console.Write(item);
            }

            Console.WriteLine($"Capatity of array {arr1.Length}");

            Console.ReadKey();


            
        }
    }
}
