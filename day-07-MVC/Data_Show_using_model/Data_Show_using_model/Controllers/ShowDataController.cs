using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data_Show_using_model.Models;
using System.Data;
using System.Data.SqlClient;

namespace Data_Show_using_model.Controllers
{
    public class ShowDataController : Controller
    {
        // GET: ShowData
        public ActionResult Show()
        {
            Stu s = new Stu();
            
            s.Sid = "";
            s.SFname = "";
            s.SLname = "";
            s.Scity = "";
            ViewBag.searchResult = "";

            return View(s);
        }

        [HttpPost]
        public ActionResult Show(string Sid)
        {
            Stu s = new Stu();
            
            string mycon = @"Data Source=DESKTOP-3BLA6L2\SQLEXPRESS; Initial Catalog=Registration; Integrated Security=true";
            string query = "select * from Student where  Sid=" + Convert.ToInt32(Sid);
            SqlConnection con = new SqlConnection(mycon);
            SqlCommand cmd = new SqlCommand
            {
                CommandText = query,
                Connection = con,
            };

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                ViewBag.searchResult = "Roll number has been found";
                s.Sid = Sid;
                s.SFname = ds.Tables[0].Rows[0]["SFname"].ToString();
                s.SLname = ds.Tables[0].Rows[0]["SLname"].ToString();
                s.Scity = ds.Tables[0].Rows[0]["Scity"].ToString();
            }
            else
            {
                ViewBag.searchResult = "Roll number has not found";
            }
            con.Close();

            return View(s);
        }
    }
}