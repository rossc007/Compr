﻿using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Compr.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ComprControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}