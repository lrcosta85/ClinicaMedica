﻿using LR.ClinicaMedica.UI.Site.Filters;
using System.Web;
using System.Web.Mvc;

namespace LR.ClinicaMedica.UI.Site
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new GlobalErrorHandler());
        }
    }
}
