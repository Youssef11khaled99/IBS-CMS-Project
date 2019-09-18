using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS_SYSTEM.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CMS_SYSTEM.Controllers
{
    public class PreviewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Previews([FromBody]ModelHtml model)
        {

            return Json(true);
        }

        public IActionResult Prev([FromBody]ModelHtml model)
        {

            return View(model);
        }
    }


}