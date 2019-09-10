using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Web.Mvc;
//using System.Web.Mvc;
using CMS_SYSTEM.Models;
using CMS_SYSTEM.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CMS_SYSTEM.Controllers
{
    public class WidgetController : Controller
    {
        CMSPROJECT3Context db = new CMSPROJECT3Context();

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetWidgets()
        {
            var cuurntUser = User.Identity.Name;
            var data = db.Widget.Where(x => x.CreatedBy == cuurntUser && x.IsValid == true).Select(w => new
            {
                id = w.Id,
                title = w.Title,
                createdDate = w.CreatedDate.Day + "/" + w.CreatedDate.Month + "/" + w.CreatedDate.Year,
                createdBy = w.CreatedBy,
                updatedDate = w.UpdatedDate == null ? "" : w.UpdatedDate.Value.Day + "/" + w.UpdatedDate.Value.Month + "/" + w.UpdatedDate.Value.Year,
                updatedBy = w.ModifiedBy == null ? "" : w.ModifiedBy,
                isPublished = w.IsPublished == null ? false : w.IsPublished,
                isActive = w.IsActive == null ? false : w.IsActive,
                baseWID = w.BaseId,

                htmlBody = w.HtmlBody

            }).OrderByDescending(q => q.id).ToList();

            return Json(data);
        }

        [HttpGet]
        public JsonResult GetWidget(int id)
        {
            var data = db.Widget.Where(x => x.Id == id).Select(w => new
            {
                id = w.Id,
                title = w.Title,
                htmlBody = w.HtmlBody

            }).SingleOrDefault();

            return Json(data);
        }


        [HttpPost]
        public JsonResult AddWidget([FromBody]WidgetViewModel PostData)
        {
            Widget objAdd = new Widget()
            {
                Title = PostData.Title,
                IsPublished = true,
                CreatedBy = User.Identity.Name,
                CreatedDate = DateTime.Now,
                IsValid = true,
                WidgetTypeId = 1,
                IsActive = true,
                HtmlBody = PostData.HtmlBody
            };

            db.Widget.Add(objAdd);
            db.SaveChanges();
            return Json(true);
        }

        [HttpPost]
        public JsonResult EditWidget(int id, [FromBody]WidgetViewModel PostData)
        {

            Widget currentWidget = db.Widget.Where(a => a.Id == id).SingleOrDefault();
            currentWidget.IsValid = false;
            currentWidget.IsActive = false;
            currentWidget.IsPublished = false;

            Widget objAdd = new Widget()
            {
                Title = PostData.Title,
                HtmlBody = PostData.HtmlBody,
                IsPublished = true,
                IsValid = true,
                IsActive = true,
                CreatedBy = User.Identity.Name,
                CreatedDate = DateTime.Now,
                ModifiedBy = User.Identity.Name,
                UpdatedDate = DateTime.Now,
                WidgetTypeId = 1,
                BaseId = id

            };

            db.Widget.Add(objAdd);
            db.SaveChanges();
            return Json(true);

        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var widgetDetails = db.Widget.SingleOrDefault(x => x.Id == id);

            if (widgetDetails == null)
            {
                return NotFound();
            }

            return View(widgetDetails);
        }


        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var widget = db.Widget.SingleOrDefault(x => x.Id == id);

            if (widget == null)
            {
                return NotFound();
            }

            WidgetViewModel PostData = new WidgetViewModel();
            PostData.Title = widget.Title;
            PostData.IsActive = widget.IsActive;
            PostData.IsPublished = widget.IsPublished;
            PostData.IsValid = widget.IsValid;
            PostData.ModifiedBy = widget.ModifiedBy;
            PostData.UpdatedDate = widget.UpdatedDate;
            PostData.HtmlBody = widget.HtmlBody;
            PostData.CreatedDate = widget.CreatedDate;
            PostData.BaseId = widget.BaseId;



            return View(PostData);
        }

        [HttpPost]
        public IActionResult Edit(int id, WidgetViewModel PostData)
        {
            var currentWidget = db.Widget.SingleOrDefault(x => x.Id == id);

            currentWidget.Title = PostData.Title;
            currentWidget.HtmlBody = PostData.HtmlBody;

            db.SaveChanges();

            return View();
        }
    }
}