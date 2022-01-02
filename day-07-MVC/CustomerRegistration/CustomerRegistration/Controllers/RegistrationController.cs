using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace CustomerRegistration.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult SaveData()
        {
            ViewBag.Result = "";
            return View();
        }
        [HttpPost]

        public ActionResult SaveData(string Cname,string Cage,string Ccity)
        {
            Console.WriteLine("data here");
            Console.WriteLine(Cname, Cage, Ccity);

            string query = "insert into CustomerRes(Cname,Cage,Ccity) values('"+Cname+"','"+Cage+"','"+Ccity+"')";

            string mycon = "Data Source=DESKTOP-3BLA6L2\\SQLEXPRESS; Initial Catalog=Registration; Integrated Security=true";

            SqlConnection con = new SqlConnection(mycon);
            con.Open();
            SqlCommand cmd = new SqlCommand
            {
                CommandText = query,
                Connection = con,
            };
            cmd.ExecuteNonQuery();
            ViewBag.Result = "Data has been Saved";
            return View();
        }
    }
}