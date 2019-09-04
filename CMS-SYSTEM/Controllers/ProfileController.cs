﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using CMS_SYSTEM.Models;
using System.Web;
using Microsoft.Office.Tools.Word;

namespace CMS_SYSTEM.Controllers
{

    [Authorize]
    public class ProfileController : Controller
    {

        CMSPROJECT3Context db = new CMSPROJECT3Context();
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult CreateWebsite()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateWebsite(string WebsiteName)
        {
            UserWebsites userWebsites = new UserWebsites();
            var currnetUser = User.Identity.Name;
            userWebsites.CreatedBy = currnetUser;
            userWebsites.WebsiteName = WebsiteName;
            db.UserWebsites.Add(userWebsites);
            db.SaveChanges();

            Widget widget = new Widget();
            widget.CreatedDate = DateTime.Now;
            widget.CreatedBy = currnetUser;
            widget.Title = WebsiteName + "-Document";
            widget.WidgetOrdinal = 0;
            widget.WidgetTypeId = 1;
            widget.HtmlBody = "<!DOCTYPE html>" +
                "< html lang = 'en' >" +
                    "< head >" +
                        "< meta charset = 'UTF-8' >" +
                        "< meta name = 'viewport' content = 'width=device-width, initial-scale=1.0' >" +
                        "< meta http - equiv = 'X-UA-Compatible' content = 'ie=edge' > " +
                        "< title > ${websiteName} </ title >" +
                    "</ head >" +
                    "< body >" +

                    "</ body >" +
                "</ html >";
            db.Widget.Add(widget);
            db.SaveChanges();

            //int widgetID = db.Widget.FirstOrDefault(x=>x.);
            WidgetParent widgetParent = new WidgetParent();


            int websiteID = db.UserWebsites.FirstOrDefault(x => x.CreatedBy == currnetUser).Id;
            return RedirectToAction("Interface", "Pages", new { Id = websiteID });
        }
    }
}