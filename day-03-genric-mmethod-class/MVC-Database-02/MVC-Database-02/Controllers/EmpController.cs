using MVC_Database_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Database_02.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        public ActionResult Index()
        {

            List<Emp> listEmps = new List<Emp>
            {
                new Emp{EID=1,EName="Saurabh",EDsign="Developer",ESalary=24000,Doj=new DateTime(day:18,month:10,year:2021)},
                new Emp{EID=2,EName="samm",EDsign="Developer",ESalary=24000,Doj=new DateTime(day:18,month:10,year:2021)},
                new Emp{EID=3,EName="pam",EDsign="Developer",ESalary=24000,Doj=new DateTime(day:18,month:10,year:2021)},
                new Emp{EID=4,EName="Saurabh",EDsign="Developer",ESalary=24000,Doj=new DateTime(day:18,month:10,year:2021)},
                new Emp{EID=5,EName="Saurabh",EDsign="Developer",ESalary=24000,Doj=new DateTime(day:18,month:10,year:2021)},
            };
            return View(listEmps);
        }
    }
}