using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Update_and_search_in_MVC.Models;
using System.Data;
using System.Data.SqlClient;

namespace Update_and_search_in_MVC.Controllers
{
    public class StudentUpdateSearchController : Controller
    {
        // GET: StudentUpdateSearch
        public ActionResult SUdata()
        {
            ViewBag.searchResult = "";
            ViewBag.updateResult = "";
            Stu s = new Stu();
            s.Sid = "";
            s.SFname = "";
            s.SLname = "";
            s.Scity = "";
            return View(s);
        }
        [HttpPost]
        public ActionResult SUdata(string Sid, string cbutton,string SFname,string SLname,string Scity)
        {
            Stu s = new Stu();
            if (cbutton == "Search") {

                string mycon = "Data Source=DESKTOP-3BLA6L2\\SQLEXPRESS; Initial Catalog=Registration; Integrated Security=true";
                string query = "select * from Student where  Sid="+Convert.ToInt32(Sid);
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
            }

            else if(cbutton == "Update")
            {
                string mycon = "Data Source=DESKTOP-3BLA6L2\\SQLEXPRESS; Initial Catalog=Registration; Integrated Security=true";
                string query = "update Student set SFname='"+SFname+"', SLname='"+SLname+ "',Scity='"+Scity+ "' where Sid="+Convert.ToInt32(Sid) ;
                SqlConnection con = new SqlConnection(mycon);
                con.Open();
                SqlCommand cmd = new SqlCommand
                {
                    CommandText = query,
                    Connection = con,
                };
                cmd.ExecuteNonQuery();
                con.Close();

                s.Sid = "";
                s.SFname = "";
                s.SLname = "";
                s.Scity = "";
                ViewBag.updateResult = "Data has been Updated Sucessfully roll no "+Sid;
            }
            return View(s);
        }

    }
}