using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace CustomerRegistrationWithoutModel.Controllers
{
    public class CustomerRegistrationController : Controller
    {
        // GET: CustomerRegistration
        public ActionResult SaveData()
        {
            ViewBag.result = "";
            return View();
        }
        [HttpPost]
        public ActionResult SaveData(string Cname,string Cemail,string Ccity)
        {
            string query = "insert into CustoerDetails(Cname,Cemail,Ccity) values('"+Cname+ "','" + Cemail + "','" + Ccity + "')";

            string mycon = @"Data Source=DESKTOP-3BLA6L2\SQLEXPRESS; Initial Catalog=Registration; Integrated Security=true";

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