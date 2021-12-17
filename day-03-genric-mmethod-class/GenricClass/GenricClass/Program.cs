using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenricClass
{
    //public class Box
    //{
    //    int b;
    //    public Box(int b)
    //    {
    //        this.b = b;
    //    }

    //    public void dis()
    //    {
    //        Console.WriteLine($"Value of b {b}");
    //    }
    //}


    public class Box<T>
    {
        //T b;
        //public Box(T b)
        //{
        //    this.b = b;
        //}

        //public void dis()
        //{
        //    Console.WriteLine($"Value of b {b}");
        //}

        // property

        public T ID { get; set; }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Box obj = new Box(5);
            // if  i want to paas string values.
            //public class Box

            // thats why we use genric classs

            //Box<int> obj = new Box<int>(5);
            //Box<string> obj1 = new Box<string>("sam");
            //Box<double> obj2 = new Box<double>(52312.242);
            //Box<char> obj3 = new Box<char>('A');


            //obj.dis();
            //obj1.dis();
            //obj2.dis();
            //obj3.dis();

            Box<int> obj = new Box<int>();
            obj.ID = 10;
            Console.WriteLine(obj.ID);


            Box<string> obj1 = new Box<string>();
            obj1.ID = "d01";
            Console.WriteLine(obj1.ID);


            Console.ReadKey();
        }
    }
}
