﻿using System.Web;
using System.Web.Mvc;

namespace MVC_PARTIAL_VIEW
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
