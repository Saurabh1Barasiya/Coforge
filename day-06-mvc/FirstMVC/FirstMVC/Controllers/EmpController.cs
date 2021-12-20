using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVC.Models;

namespace FirstMVC.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Details()
        {
            List<EmployeeModel> emp = new List<EmployeeModel>() { 
            new EmployeeModel(){ ID = 111,Name="Sam",City="Jbp",Salary=10000},
            new EmployeeModel(){ ID = 222,Name="Ram",City="Jbp",Salary=20000},
            new EmployeeModel(){ ID = 333,Name="Tam",City="Jbp",Salary=30000},
            new EmployeeModel(){ ID = 444,Name="Ram",City="Jbp",Salary=40000},
            new EmployeeModel(){ ID = 555,Name="Jam",City="Jbp",Salary=50000},
            };
            ViewBag.no = emp.Count;
            return View(emp);
        }
    }
}