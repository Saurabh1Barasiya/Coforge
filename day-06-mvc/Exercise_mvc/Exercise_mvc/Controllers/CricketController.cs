using Exercise_mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercise_mvc.Controllers
{
    public class CricketController : Controller
    {
        // GET: Cricket
        public ActionResult Home()
        {
             List<WorldCupData> cr = new List<WorldCupData>() { 
             new WorldCupData(){TeamID=1,TeamName="India",TeamLogo="India Logo",NoWC=2},
             new WorldCupData(){TeamID=2,TeamName="Austarilia",TeamLogo="India Logo",NoWC=2},
             new WorldCupData(){TeamID=4,TeamName="England",TeamLogo="India Logo",NoWC=1},
            };
            return View(cr);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }


    }
}