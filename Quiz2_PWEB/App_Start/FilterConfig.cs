﻿using System.Web;
using System.Web.Mvc;

namespace Quiz2_PWEB
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
