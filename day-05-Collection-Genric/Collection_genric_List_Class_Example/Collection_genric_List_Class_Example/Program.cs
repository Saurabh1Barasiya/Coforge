using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_genric_List_Class_Example
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee() { 
                 ID =1 ,
                 Name = "amit nag ".ToUpper(),
                 City = "harrai".ToUpper()
            };

            Employee emp2 = new Employee();
            emp2.ID = 2;
            emp2.Name = "raman boj".ToUpper();
            emp2.City = "Jabalpur".ToUpper();

            Employee emp3 = new Employee()
            {
                ID = 3,
                Name = "ranu sahu ".ToUpper(),
                City = "jabalpur".ToUpper()
            };

            // create a list aand add all employee.

            List<Employee> obj = new List<Employee>();
            obj.Add(emp1);
            obj.Add(emp2);
            obj.Add(emp3);


            Console.WriteLine("All Employee Details as Follows : ");
            Console.WriteLine("ID \t\t Name \t\t City");
            foreach (var ele in obj)
            {
                Console.Write($"{ele.ID} \t {ele.Name} \t {ele.City}");
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
