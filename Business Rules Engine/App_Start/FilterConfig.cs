﻿using System.Web;
using System.Web.Mvc;

namespace Business_Rules_Engine
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
