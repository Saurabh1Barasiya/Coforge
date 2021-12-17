using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genric_Example
{
    class Check
    {
        //public static int Sum1(int a,int b)
        //{
        //    //Console.WriteLine($"Sum is {a+b}");
        //    return a + b;
        //}
        //public static double Sum1(double a,double b)
        //{
        //    //Console.WriteLine($"Sum is {a+b}");
        //    return a + b;
        //}
        //public static string Sum1(string a,string b)
        //{
        //    //Console.WriteLine($"Sum is {a+b}");
        //    return a + b;
        //}

        // ye sab kamm karne ke liye hamko baar baar function ko overload karna pad raha h.
        // so we dont want to overload  
        // thats why we use Genric.

        public static void Sum1<T>(T a,T b)
        {
            //bool c = a.Equals(b);
            //int c = a + b;   // Operator '+' cannot be applied to operands of type 'T' and 'T'

            // Thats way we use dynamic

            dynamic num1 = a;
            dynamic num2 = b;
            dynamic c = num1+num2;
            Console.WriteLine($"Result is {c}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Genric are used to create our datatype
            Check.Sum1(5, 5);

            Check.Sum1(5.012, 5.20);

            Check.Sum1("Amit ", "Nag");
            
            Console.ReadKey();


        }
    }
}
