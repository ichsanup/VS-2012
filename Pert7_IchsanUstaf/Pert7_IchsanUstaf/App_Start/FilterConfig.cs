﻿using System.Web;
using System.Web.Mvc;

namespace Pert7_IchsanUstaf
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}