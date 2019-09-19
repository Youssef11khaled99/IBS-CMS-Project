using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CMS_SYSTEM.Models;
using CMS_SYSTEM.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace CMS_SYSTEM.Controllers
{
    public class ContentsController : Controller
    {
        private readonly CMSPROJECT3Context _context;

        public ContentsController(CMSPROJECT3Context context)
        {
            _context = context;
        }

        public IActionResult tessst()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = User.Identity.Name;
            }

            return View();
        }
        // GET: Contents
        public IActionResult Index(int websiteId)
        {

            //HttpContext.Session.SetInt32("currentWebsiteId", websiteId);
            //var testId = HttpContext.Session.GetInt32("currentWebsiteId");

            ViewBag.WebsiteID = websiteId;
            var websiteData = _context.Websites.SingleOrDefault(w => w.Id == websiteId);

            var webParent = _context.Widget.SingleOrDefault(p => p.CreatedBy == websiteData.CreatedBy
                            && p.Title.Contains(websiteData.WebsiteName + "-Document"));

            if (webParent != null)
            {
                var contents = (from content in _context.Content
                                join widgetParent in _context.WidgetParent
                                on content.Pid equals widgetParent.Id
                                where widgetParent.Pid == webParent.Id
                                select content).ToList();


                //var contentss = _context.Content.Where(c => c.Pid == webParent.Id).ToList();
                if (contents.Count != 0)
                {
                    return View(contents);
                }
                else
                {
                    ViewBag.ContentsNotFound = "Sorry you dont have any Widgets ";
                    return View();
                }
            }
            return View();
        }

        // GET: Contents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var content = await _context.Content
                .Include(c => c.L)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (content == null)
            {
                return NotFound();
            }
            ViewBag.WebId = _context.WidgetParent.SingleOrDefault(x => x.Id == content.Pid).WebsitesId;
            return View(content);
        }

        // GET: Contents/Create
        public IActionResult Create(int id)
        {
            widgetContentViewModel model = new widgetContentViewModel();
            model.WebsiteId = id;
            ViewData["Lid"] = new SelectList(_context.Languages, "Id", "Name");
            ViewBag.WidgetsList = new SelectList(_context.Widget.Where(w => !w.Title.Contains("Document")), "Id", "Title");
            ViewBag.WebId = id;
            return View(model);
        }


        [HttpPost]
        public IActionResult CreateContent([FromBody]widgetContentViewModel model)
        {
            //widgetContentViewModel model = new widgetContentViewModel();
            /*
             * 1- Get ( WebsiteId - UserEmail - WidgetParent "document")
             * 2- Get Selected Widgets ID From html Pop form 
             * 3- Add widgetID - ParentID - WebsiteID in (WidgetParent)
             * 4- Get WidgetParentID that Current added
             * 5- Add New Content
             */

            int websiteId = model.WebsiteId;
            var websiteData = _context.Websites.SingleOrDefault(n => n.Id == websiteId);

            int parentId = _context.Widget.SingleOrDefault(p => p.Title.Contains(websiteData.WebsiteName + "-Document")
                                                           && p.CreatedBy == websiteData.CreatedBy).Id;
            string fullWidgetHtml = "";

            if (model.widgetList.Count() > 1)
            {

                for (int i = 0; i < model.widgetList.Count(); i++)
                {
                    var widgetData = _context.Widget.SingleOrDefault(w => w.Id == model.widgetList[i]);
                    fullWidgetHtml += widgetData.HtmlBody;

                    Widget widgetObj = new Widget
                    {
                        Title = websiteData.WebsiteName + "-" + widgetData.Title,
                        CreatedDate = DateTime.Now,
                        CreatedBy = User.Identity.Name,
                        // 16 =>  widget ID type that refers to a widgets created by user
                        WidgetTypeId = 16,
                        HtmlBody = widgetData.HtmlBody
                    };
                    _context.Widget.Add(widgetObj);
                    _context.SaveChanges();

                    int currentAddedWidgetID = widgetObj.Id;

                    WidgetParent widgetParentObj = new WidgetParent
                    {
                        WebsitesId = websiteId,
                        Wid = currentAddedWidgetID,
                        Pid = parentId
                    };

                    _context.WidgetParent.Add(widgetParentObj);
                    _context.SaveChanges();

                    int currentAddedWidgetParentId = widgetParentObj.Id;

                    Content contentObj = new Content
                    {
                        Name = model.Name + " Of " + widgetObj.Title,
                        Title = model.Title + " Of " + websiteData.WebsiteName,
                        MetaDescription = model.MetaDesc + " Of " + model.Name + " Of " + widgetObj.Title,
                        Body = widgetData.HtmlBody,
                        CreatedDate = DateTime.Now,
                        CreatedBy = User.Identity.Name,

                        Pid = widgetParentObj.Id
                    };
                    _context.Content.Add(contentObj);
                    _context.SaveChanges();

                }

                Widget widgetMaster = new Widget
                {
                    Title = websiteData.WebsiteName + "-" + "Master",
                    CreatedDate = DateTime.Now,
                    CreatedBy = User.Identity.Name,
                    // 16 =>  widget ID type that refers to a widgets created by user
                    WidgetTypeId = 16,
                    HtmlBody = fullWidgetHtml
                };
                _context.Widget.Add(widgetMaster);
                _context.SaveChanges();

                int widgetMasterId = widgetMaster.Id;

                WidgetParent widgetParentMaster = new WidgetParent
                {
                    WebsitesId = websiteId,
                    Wid = widgetMasterId,
                    Pid = parentId
                };
                _context.WidgetParent.Add(widgetParentMaster);
                _context.SaveChanges();

                int widgetParentMasterId = widgetParentMaster.Id;

                Content contentMaster = new Content
                {
                    Name = model.Name + " Of " + widgetMaster.Title,
                    Title = model.Title + " Of " + websiteData.WebsiteName,
                    MetaDescription = model.MetaDesc + " Of " + model.Name + " Of " + widgetMaster.Title,
                    Body = fullWidgetHtml,
                    CreatedDate = DateTime.Now,
                    CreatedBy = User.Identity.Name,
                    Pid = widgetParentMasterId
                };
                _context.Content.Add(contentMaster);
                _context.SaveChanges();

                return Json(true);


            }
            else
            {
                for (int j = 0; j < model.widgetList.Count(); j++)
                {
                    var widgetData = _context.Widget.SingleOrDefault(x => x.Id == model.widgetList[j]);

                    Widget widgetMaster = new Widget
                    {
                        Title = websiteData.WebsiteName + "-" + "Master",
                        CreatedDate = DateTime.Now,
                        CreatedBy = User.Identity.Name,
                        // 16 =>  widget ID type that refers to a widgets created by user
                        WidgetTypeId = 16,
                        HtmlBody = widgetData.HtmlBody
                    };
                    _context.Widget.Add(widgetMaster);
                    _context.SaveChanges();

                    int widgetMasterId = widgetMaster.Id;

                    WidgetParent widgetParentMaster = new WidgetParent
                    {
                        WebsitesId = websiteId,
                        Wid = widgetMasterId,
                        Pid = parentId
                    };
                    _context.WidgetParent.Add(widgetParentMaster);
                    _context.SaveChanges();

                    int widgetParentMasterId = widgetParentMaster.Id;

                    Content contentMaster = new Content
                    {
                        Name = model.Name + " Of " + widgetMaster.Title,
                        Title = model.Title + " Of " + websiteData.WebsiteName,
                        MetaDescription = model.MetaDesc + " Of " + model.Name + " Of " + widgetMaster.Title,
                        Body = widgetData.HtmlBody,
                        CreatedDate = DateTime.Now,
                        CreatedBy = User.Identity.Name,
                        Pid = widgetParentMasterId
                    };
                    _context.Content.Add(contentMaster);
                    _context.SaveChanges();


                }

                return Json(true);
            }







            #region Old-Logic

            //(1)..
            //int websiteId = model.WebsiteId;

            //if (websiteId != 0)
            //{
            //    var websiteData = _context.Websites.SingleOrDefault(w => w.Id == websiteId);
            //    var parentData = _context.Widget.SingleOrDefault(p => p.CreatedBy == websiteData.CreatedBy
            //                        && p.Title.Contains(websiteData.WebsiteName + "-Document"));

            //    if (model.widgetList.Count() > 1)
            //    {
            //        //    select more than one widget, so i will create for him 
            //        //    new Widget have all the HTML of selected widgets
            //        //    first get the html of all widgets and compin together inside one widget\
            //        string selectedWidgetHtml = "";
            //        for (int i = 0; i < model.widgetList.Count(); i++)
            //        {
            //            var currentHtmlWidgets = _context.Widget.SingleOrDefault(x => x.Id == model.widgetList[i]).HtmlBody;
            //            selectedWidgetHtml = selectedWidgetHtml + currentHtmlWidgets;

            //        }
            //        Widget widget = new Widget
            //        {
            //            HtmlBody = selectedWidgetHtml,
            //            Title = _context.Websites.SingleOrDefault(w => w.Id == model.WebsiteId).WebsiteName + "-Widgets",
            //            CreatedBy = User.Identity.Name,
            //            CreatedDate = DateTime.Now,
            //            // 16 =>  widget ID type that refers to a widgets created by user
            //            WidgetTypeId = 16,
            //        };
            //        _context.Widget.Add(widget);
            //        _context.SaveChanges();

            //        int currentWidgetId = widget.Id;
            //        WidgetParent widgetParent = new WidgetParent
            //        {
            //            Pid = parentData.Id,
            //            WebsitesId = websiteId,
            //            Wid = currentWidgetId
            //        };
            //        _context.WidgetParent.Add(widgetParent);
            //        _context.SaveChanges();

            //        int currentWidgetParentId = widgetParent.Id;

            //        Content content = new Content
            //        {
            //            Body = widget.HtmlBody,

            //        };


            //    }
            //    else
            //    {

            //    }

            //    if (ModelState.IsValid)
            //    {
            //        //(2)..
            //        var selectedWidgetID = model.SelectedWidgetId;
            //        var widget = _context.Widget.SingleOrDefault(x => x.Id == selectedWidgetID);

            //        WidgetParent widgetParent = new WidgetParent();

            //        widgetParent.Pid = parentData.Id;
            //        widgetParent.Wid = selectedWidgetID;
            //        widgetParent.WebsitesId = websiteId;

            //        _context.WidgetParent.Add(widgetParent);
            //        _context.SaveChanges();


            //        //
            //        var currentWidgetParentId = widgetParent.Id;
            //        //

            //        var widgetData = _context.Widget.SingleOrDefault(w => w.Id == selectedWidgetID);
            //        var userData = _context.AspNetUsers.SingleOrDefault(u => u.UserName == User.Identity.Name);
            //        string finalHtml = "";
            //        for (int i = 0; i < model.widgetList.Count(); i++)
            //        {
            //            int currentId = model.widgetList[i];
            //            string currentHtml = _context.Widget.SingleOrDefault(x => x.Id == currentId).HtmlBody;
            //            finalHtml = finalHtml + currentHtml;
            //        }

            //        Content content = new Content();
            //        content.Body = finalHtml;

            //        //content.Body = widgetData.HtmlBody;

            //        content.Lid = 1;
            //        content.Name = model.Name;
            //        content.CreatedBy = userData.Email;
            //        content.Title = model.Title;
            //        content.MetaDescription = model.MetaDesc;
            //        content.BaseWidgetId = widgetData.Id;
            //        content.Pid = currentWidgetParentId;
            //        content.CreatedDate = DateTime.Now;

            //        _context.Content.Add(content);
            //        _context.SaveChangesAsync();

            //        //return RedirectToAction("Index","Contents",new { websiteId = websiteId });
            //        return Json(new { websiteId = websiteId });
            //    }
            //}

            //return Json(false);
            #endregion
            #region Hashed
            //ViewBag.WidgetsList = new SelectList(_context.Widget.Where(w => !w.Title.Contains("Document")), "Id", "Title");
            //return View(model);
            #endregion
        }

        // GET: Contents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var content = await _context.Content.FindAsync(id);
            if (content == null)
            {
                return NotFound();
            }
            ViewData["Lid"] = new SelectList(_context.Languages, "Id", "Name", content.Lid);

            ViewBag.WebId = _context.WidgetParent.SingleOrDefault(x => x.Id == content.Pid).WebsitesId;

            return View(content);
        }

        // POST: Contents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Title,Lid,MetaDescription,Body,IsValid,BaseWidgetId,CreatedDate,UpdatedDate,CreatedBy,ModifiedBy,Pid")] Content content)
        {
            if (id != content.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(content);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContentExists(content.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Lid"] = new SelectList(_context.Languages, "Id", "Name", content.Lid);
            return View(content);
        }

        // GET: Contents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var content = await _context.Content
                .Include(c => c.L)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (content == null)
            {
                return NotFound();
            }

            return View(content);
        }

        // POST: Contents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var content = await _context.Content.FindAsync(id);
            _context.Content.Remove(content);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContentExists(int id)
        {
            return _context.Content.Any(e => e.Id == id);
        }




        [HttpGet]
        public JsonResult GetWidgetsList()
        {

            var widgetsData = _context.Widget.Where(w => !w.Title.Contains("-Document")).Select(a => new
            {
                id = a.Id,
                htmlBody = a.HtmlBody,
                title = a.Title

            }).ToList();

            return Json(widgetsData);
        }

        public ActionResult Test()
        {
            return View();
        }
    }
}
