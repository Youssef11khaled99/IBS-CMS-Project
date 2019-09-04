﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CMS_SYSTEM.Controllers
{
    [Authorize]
    public class PagesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Interface(int Id)
        {
            return View();
        }
    }
}