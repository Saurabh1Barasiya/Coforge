using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EvenOddController : Controller
    {
        // GET: EvenOdd
        public ActionResult Index()
        {
            var v = new EvenOdd();
            v.Msg = "";
            return View(v);
        }

        [HttpPost]
        public ActionResult Index(string a)
        {
            var v = new EvenOdd();
            int num = int.Parse(a);
            if ((num % 2) == 0)
            {
                v.Msg = "Number is Even";
            }
            else
            {
                v.Msg = "Number is Odd";
            }
            return View(v);
        }



    }
}