using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_with_Employee
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            obj.Id = 111;
            obj.Name = "Saurabh Barasiya";
            obj.Email = "Saurabhbarasiya.sb@gmail.com";
            obj.Salary = 452132.0120;

            Employee obj1 = new Employee();
            obj1.Id = 222;
            obj1.Name = "Ram Barasiya";
            obj1.Email = "Rambarasiya.sb@gmail.com";
            obj1.Salary = 4521.0120;

            Employee obj2 = new Employee();
            obj2.Id = 333;
            obj2.Name = "Sonu Barasiya";
            obj2.Email = "Sonubarasiya.sb@gmail.com";
            obj2.Salary = 10000.23;

            Dictionary<int, Employee> emp = new Dictionary<int, Employee>();
            emp.Add(obj.Id, obj);
            emp.Add(obj1.Id, obj1);
            emp.Add(obj2.Id, obj2);


            foreach (KeyValuePair<int,Employee> item in emp)
            {
                Console.WriteLine($" -------------------- Details of Key {item.Key} ----------------------");
                Console.WriteLine($" ID {item.Value.Id}");
                Console.WriteLine($" Name {item.Value.Name}");
                Console.WriteLine($" Email {item.Value.Email}");
                Console.WriteLine($" Salary {item.Value.Salary}");
            }


            Console.WriteLine("-------------- Now i want Salary greater then 5000 ------------");

            Console.WriteLine(emp.Count(e => e.Value.Salary > 5000));

            Console.WriteLine("----------------------------------------------------------------------");

            Console.WriteLine(emp.FirstOrDefault(e => e.Value.Salary > 5000));

            //KeyValuePair<int, Employee> keyValuePair = emp.FirstOrDefault(e => e.Value.Salary > 5000);
            //Console.WriteLine(keyValuePair.Key);

            // find length in dictionary.

            Console.WriteLine($"Totel Element {emp.Count()} ");

            // clear 

            emp.Clear();
            Console.WriteLine($"Totel Element {emp.Count()} ");
            Dictionary<int, Employee> emp1 = new Dictionary<int, Employee>();
            emp1.Add(obj.Id, obj);
            emp1.Add(obj1.Id, obj1);
            emp1.Add(obj2.Id, obj2);





            //if (emp1.Keys.Contains(111))
            //{
            //    Console.WriteLine("Match found!!!");
            //    Console.WriteLine(emp1.Keys);
            //}
            //else
            //{
            //    Console.WriteLine("Match not found!!!");
            //}
            //Console.WriteLine(emp1.Keys);

            foreach (var item in emp1.Keys)
            {
                Console.WriteLine(item);
            }

            foreach (var key in emp1.Keys)
            {
                if(key == 111)
                {
                    Console.WriteLine("Match found");
                    Console.WriteLine(emp1[key].Id);
                    Console.WriteLine(emp1[key].Name);
                    Console.WriteLine(emp1[key].Email);
                    Console.WriteLine(emp1[key].Salary);
                    break;
                }
                else
                {
                    Console.WriteLine("No Match found!!!");
                }
            }


            Console.ReadKey();
        }
    }
}
