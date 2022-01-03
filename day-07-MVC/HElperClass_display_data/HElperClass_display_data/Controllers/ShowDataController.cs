using HElperClass_display_data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HElperClass_display_data.Controllers
{
    public class ShowDataController : Controller
    {
        // GET: ShowData
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(StuData s)
        {
            return View(s);
        }
    }
}