using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LargerNumber.Models;

namespace LargerNumber.Controllers
{
    public class FindLargestController : Controller
    {
        // GET: FindLargest
        public ActionResult Index()
        {
            var c = new Compare();
            c.result = "";
            return View(c);
        }

        [HttpPost]
        public ActionResult Index(string a , string b)
        {
            int num1 = int.Parse(a);
            int num2 = int.Parse(b);
            var c = new Compare();
            if (num1 > num2)
            {
                c.result = $" Larger number is  {num1}";
            }
            else
            {
                c.result = $" Larger number is  {num2}";
            }
            return View(c);
        }
    }
}