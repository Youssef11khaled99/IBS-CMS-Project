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

        //[Authorize]
        public ActionResult LinkTo()
        {

            return View();
        }

        // GET: Contents
        public IActionResult Index(int websiteId)
        {

            HttpContext.Session.SetInt32("currentWebsiteId", websiteId);
            //var testId = HttpContext.Session.GetInt32("currentWebsiteId");

            return RedirectToAction("Create", "Contents", new { id = websiteId });
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

            return View(content);
        }

        // GET: Contents/Create
        public IActionResult Create(int id)
        {
            widgetContentViewModel model = new widgetContentViewModel();
            model.WebsiteId = id;
            ViewData["Lid"] = new SelectList(_context.Languages, "Id", "Name");
            ViewBag.WidgetsList = new SelectList(_context.Widget, "Id", "Title");
            return View(model);
        }

        // POST: Contents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(widgetContentViewModel model)
        {
            var tessst = model.SelectedWidgetId;
            /*
             * - Get ( WebsiteId - User - WidgetParent "document" )
             * - Get Selected Widget ID From html add form 
             * - Add in (WidgetParent)
             * - Get WidgetParentID Current Add
             * - Add New Content
             */

            int websiteId = model.WebsiteId;
            if (websiteId != 0)
            {
                if (ModelState.IsValid)
                {
                    var selectedWidgetID = model.SelectedWidgetId;

                    var widget = _context.Widget.SingleOrDefault(x => x.Id == selectedWidgetID);
                    WidgetParent widgetParent = new WidgetParent();

                    widgetParent.Pid = 6;
                    widgetParent.Wid = selectedWidgetID;
                    widgetParent.WebsitesId = websiteId;

                    _context.WidgetParent.Add(widgetParent);
                    await _context.SaveChangesAsync();


                    //
                    var currentWidgetParentId = widgetParent.Id;
                    //


                    Content content = new Content();
                    content.Body = model.HtmlBody;
                    content.Pid = currentWidgetParentId;

                    //return RedirectToAction("Index","Contents",new { websiteId = websiteId });
                    return View();
                }
            }

            //ViewData["Lid"] = new SelectList(_context.Languages, "Id", "Name", content.Lid);
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
