using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstApproch.Controllers
{
    public class DataAccessHomeController : Controller
    {
        // GET: DataAccessHome
        public ActionResult Index()
        {
            RegistrationEntities entity = new RegistrationEntities();

            return View(from CustoerDetail in entity.CustoerDetails select CustoerDetail);
        }
    }
}