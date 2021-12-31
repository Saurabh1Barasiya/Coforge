using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DisplayData.Models;

namespace DisplayData.Controllers
{
    public class ShowDataController : Controller
    {
        // GET: ShowData
        public ActionResult Index()
        {
            Student s = new Student()
            {
                Sid=1,Sname="Saurabh",Saddress="ward no 08",Scity="harrai"
            };
            ViewData["StudentData"] = s;
            return View();
        }
    }
}