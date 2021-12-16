using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Ado_Session
{
    class Program
    {
        static void Main(string[] args)
        {
            day01Entities db;


            // ------------------------- select all data ----------------------------------------
            //try
            //{
            //    db = new day01Entities();
            //    //Console.WriteLine(db.Emp);
            //    //Console.WriteLine( db.Emp.GetType());
            //    //Console.ReadLine();
            //    Console.WriteLine("Id \t Name \t Desigtion \t Salary \t Doj");

            //    foreach (var ele in db.Emp)
            //    {
            //        Console.Write($" {ele.Eid} \t");
            //        Console.Write($" {ele.Ename} \t");
            //        Console.Write($" {ele.Edeig} \t");
            //        Console.Write($" {ele.Esalary} \t");
            //        Console.Write($" {ele.Doj} \t");
            //        Console.WriteLine();
            //    }

            //}
            //catch (Exception e) { Console.WriteLine(e.Message); }
            //finally { Console.ReadKey(); }


            // -------------------------- search data -------------------------------

            //try {
            //    db = new day01Entities();

            //    Console.WriteLine("Please enter id to search :  ");
            //    int id = int.Parse(Console.ReadLine());

            //    Emp obj = db.Emp.SingleOrDefault(p => p.Eid == id);
            //    //Console.WriteLine(obj);

            //    if (obj == null)
            //    {
            //        Console.WriteLine("No Record Found");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Data found!!!");
            //        Console.WriteLine("Id \t Name \t Desigtion \t Salary \t Doj");
            //        Console.Write($" {obj.Eid} \t");
            //        Console.Write($" {obj.Ename} \t");
            //        Console.Write($" {obj.Edeig} \t");
            //        Console.Write($" {obj.Esalary} \t");
            //        Console.Write($" {obj.Doj} \t");
            //    }
            //}

            //catch (Exception e) { Console.WriteLine(e.Message); }
            //finally { Console.ReadKey(); }



            //----------------------- delete data ---------------------------------

            //try {
            //    db = new day01Entities();
            //    Console.WriteLine("Please enter Id to  delete Employee: ");
            //    int id = int.Parse(Console.ReadLine());

            //    Emp obj = db.Emp.SingleOrDefault(p => p.Eid == id);
            //    if (obj != null)
            //    {
            //        db.Emp.Remove(obj);
            //        db.SaveChanges();
            //        Console.WriteLine("Data deleted Sucessfully !!!!!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No record Found!!!!");
            //    }
            //}
            //catch (Exception e) { Console.WriteLine(e.Message); }
            //finally { Console.ReadKey(); }




            // ------------------- insert data into database ------------------------

            //try {
            //    db = new day01Entities();
            //    Emp obj = new Emp();
            //    Console.WriteLine("Enter Employee ID");
            //    obj.Eid = int.Parse(Console.ReadLine());


            //    Console.WriteLine("Enter Employee Name");
            //    obj.Ename = Console.ReadLine();

            //    Console.WriteLine("Enter Employee Designation ");
            //    obj.Edeig = Console.ReadLine();

            //    Console.WriteLine("Enter Employee Salary ");
            //    obj.Esalary = float.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter Employee Doj");
            //    obj.Doj = DateTime.Parse(Console.ReadLine());

            //    db.Emp.Add(obj);
            //    db.SaveChanges();

            //    Console.WriteLine("Record Insert Succesfully !!!");

            //}
            //catch (Exception e) { Console.WriteLine(e.Message); }
            //finally { Console.ReadKey(); }


            // --------------------------- update -------------------------------

            //try {
            //    db = new day01Entities();


            //    Console.WriteLine("Please Enter Employee id to update : ");
            //    int id = int.Parse(Console.ReadLine());

            //    Emp obj = db.Emp.SingleOrDefault(p => p.Eid == id);

            //    if (obj != null)
            //    {
            //        Console.WriteLine("Enter Employee Name");
            //        obj.Ename = Console.ReadLine();
            //        Console.WriteLine("Enter Employee Designation");
            //        obj.Edeig = Console.ReadLine();
            //        Console.WriteLine("Enter Employee Salary");
            //        obj.Esalary = float.Parse(Console.ReadLine());
            //        Console.WriteLine("Enter Employee DOJ");
            //        obj.Doj = DateTime.Parse(Console.ReadLine());
            //        db.SaveChanges();
            //        Console.WriteLine("Employee Details updated Sucessfully !!!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No record found !!! ");
            //    }

            //}
            //catch (Exception e) { Console.WriteLine(e.Message); }
            //finally { Console.ReadKey(); }



            // -------------------- select  name -------------------------


            //try
            //{
            //    db = new day01Entities();

            //    Console.WriteLine("Please Enter Employee Name to search : ");
            //    string name = Console.ReadLine();

            //    //Emp obj = db.Emp.FirstOrDefault(p => p.Ename == name);
            //    Emp obj = db.Emp.First(p => p.Ename == name);

            //    if (obj != null) {
            //        Console.WriteLine("Details Macthed!!!");
            //        Console.WriteLine($"ID : {obj.Eid} ");
            //        Console.WriteLine($"Name : {obj.Ename} ");
            //        Console.WriteLine($"Salary : {obj.Esalary} ");
            //        Console.WriteLine($"Designation : {obj.Edeig} ");
            //        Console.WriteLine($"Date of joining : {obj.Doj} ");
            //    }
            //    else { Console.WriteLine("No records  found!!!"); }

            //}
            //catch (Exception e) { Console.WriteLine(e.Message); }
            //finally { Console.ReadKey(); }



            //----------------------------- Search Duplicated Record by name ---------------------------------------

            try
            {
                db = new day01Entities();

                Console.WriteLine("Please Enter Employee Name to search : ");
                string name = Console.ReadLine();

                //Emp obj = db.Emp.FirstOrDefault(p => p.Ename == name);
                var  result = from EmpName in db.Emp.Where(e => e.Ename == name) select EmpName;
                //Console.WriteLine(result);
                //Console.WriteLine(result.GetType());
                //Console.WriteLine(result.ToList());


                if (result.ToList().Count >= 1)
                {
                    Console.WriteLine("Details Macthed!!!");
                    foreach (var e in result)
                    {
                        Console.WriteLine($"ID : {e.Eid} ");
                        Console.WriteLine($"Name : {e.Ename} ");
                        Console.WriteLine($"Salary : {e.Esalary} ");
                        Console.WriteLine($"Designation : {e.Edeig} ");
                        Console.WriteLine($"Date of joining : {e.Doj} ");
                        Console.WriteLine();
                    }
                    
                    
                }
                else { Console.WriteLine("No records  found!!!"); }

            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            finally { Console.ReadKey(); }


        }
    }
}
