using MVC_PARTIAL_VIEW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_PARTIAL_VIEW.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PAction()
        {
            return PartialView("MyPView");
        }

        public ActionResult PEmp()
        {
            List<Emp1> em = new List<Emp1>()
            {
                new Emp1(){Id=1,Name="sam",DOj=new DateTime(day:01,month:10,year:2021),Salary=2000},
                new Emp1(){Id=2,Name="pam",DOj=new DateTime(day:01,month:10,year:2021),Salary=1000},
                new Emp1(){Id=3,Name="jam",DOj=new DateTime(day:01,month:10,year:2021),Salary=5000},
                new Emp1(){Id=4,Name="tam",DOj=new DateTime(day:01,month:10,year:2021),Salary=12000},
            };
            return PartialView("MyPartialView", em);
        }
    }
}