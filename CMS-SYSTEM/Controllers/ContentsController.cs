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

        // POST: Contents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(widgetContentViewModel model)
        {
            /*
             * - Get ( WebsiteId - User - WidgetParent "document")
             * - Get Selected Widget ID From html add form 
             * - Add in (WidgetParent)
             * - Get WidgetParentID Current Add
             * - Add New Content
             */

            int websiteId = model.WebsiteId;
            
            if (websiteId != 0)
            {
                var websiteData = _context.Websites.SingleOrDefault(w => w.Id == websiteId);
                var parentData = _context.Widget.SingleOrDefault(p => p.CreatedBy == websiteData.CreatedBy
                                    && p.Title.Contains(websiteData.WebsiteName + "-Document"));

                if (ModelState.IsValid)
                {
                    var selectedWidgetID = model.SelectedWidgetId;
                    var widget = _context.Widget.SingleOrDefault(x => x.Id == selectedWidgetID);

                    WidgetParent widgetParent = new WidgetParent();

                    widgetParent.Pid = parentData.Id;
                    widgetParent.Wid = selectedWidgetID;
                    widgetParent.WebsitesId = websiteId;

                    _context.WidgetParent.Add(widgetParent);
                    await _context.SaveChangesAsync();


                    //
                    var currentWidgetParentId = widgetParent.Id;
                    //

                    var widgetData = _context.Widget.SingleOrDefault(w => w.Id == selectedWidgetID);
                    var userData = _context.AspNetUsers.SingleOrDefault(u => u.UserName == User.Identity.Name);

                    Content content = new Content();
                    content.Body = widgetData.HtmlBody;
                    content.Lid = 1;
                    content.Name = model.Name;
                    content.CreatedBy = userData.Email;
                    content.Title = model.Title;
                    content.MetaDescription = model.MetaDesc;
                    content.BaseWidgetId = widgetData.Id;
                    content.Pid = currentWidgetParentId;
                    content.CreatedDate = DateTime.Now;

                    _context.Content.Add(content);
                    await _context.SaveChangesAsync();

                    //return RedirectToAction("Index","Contents",new { websiteId = websiteId });
                    return RedirectToAction("Index","Contents",new { websiteId = websiteId });
                }
            }

            ViewBag.WidgetsList = new SelectList(_context.Widget.Where(w => !w.Title.Contains("Document")), "Id", "Title");
            return View(model);
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

            ViewBag.WebId = _context.WidgetParent.SingleOrDefault(x=>x.Id==content.Pid).WebsitesId;

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
    }
}
