using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_genric_class_Example
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public string City { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Employee<int> obj = new Employee<int>()
            //{
            //    ID = 5,
            //    Name = "city",
            //};

            List<Employee> emps = new List<Employee>() {
                new Employee(){ ID=1,Name="Sam",Dob=new DateTime(day:10,month:10,year:1997),City="jabalpur"},
                new Employee(){ ID=2,Name="Ram",Dob=new DateTime(day:10,month:10,year:1997),City="jabalpur"},
                new Employee(){ ID=3,Name="Pam",Dob=new DateTime(day:10,month:10,year:1997),City="jabalpur"},
            };

            Console.WriteLine("Id \t Name \t Dob \t City");
            foreach (var item in emps)
            {
                Console.Write($"{item.ID} \t {item.Name} \t {item.Dob} \t {item.City}");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
