﻿using System.Web;
using System.Web.Mvc;

namespace AngularJS.ShopCart
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
