﻿using System.Web;
using System.Web.Mvc;

namespace Kickoff4Kids420
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}