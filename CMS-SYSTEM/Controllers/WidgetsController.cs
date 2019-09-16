using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CMS_SYSTEM.Models;

namespace CMS_SYSTEM.Controllers
{
    public class WidgetsController : Controller
    {
        private readonly CMSPROJECT3Context _context;

        public WidgetsController(CMSPROJECT3Context context)
        {
            _context = context;
        }

        // GET: Widgets
        public async Task<IActionResult> Index()
        {
            var cMSPROJECT3Context = _context.Widget.Include(w => w.WidgetType);
            return View(await cMSPROJECT3Context.ToListAsync());
        }

        // GET: Widgets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var widget = await _context.Widget
                .Include(w => w.WidgetType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (widget == null)
            {
                return NotFound();
            }

            return View(widget);
        }

        // GET: Widgets/Create
        public IActionResult Create()
        {
            ViewData["WidgetTypeId"] = new SelectList(_context.WidgetType, "Id", "Description");
            return View();
        }

        // POST: Widgets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,IsPublished,CreatedDate,UpdatedDate,CreatedBy,ModifiedBy,WidgetOrdinal,IsValid,BaseId,IsActive,WidgetTypeId,HtmlBody")] Widget widget)
        {
            if (ModelState.IsValid)
            {
                _context.Add(widget);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["WidgetTypeId"] = new SelectList(_context.WidgetType, "Id", "Description", widget.WidgetTypeId);
            return View(widget);
        }

        // GET: Widgets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var widget = await _context.Widget.FindAsync(id);
            if (widget == null)
            {
                return NotFound();
            }
            ViewData["WidgetTypeId"] = new SelectList(_context.WidgetType, "Id", "Description", widget.WidgetTypeId);
            return View(widget);
        }

        // POST: Widgets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,IsPublished,CreatedDate,UpdatedDate,CreatedBy,ModifiedBy,WidgetOrdinal,IsValid,BaseId,IsActive,WidgetTypeId,HtmlBody")] Widget widget)
        {
            if (id != widget.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(widget);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WidgetExists(widget.Id))
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
            ViewData["WidgetTypeId"] = new SelectList(_context.WidgetType, "Id", "Description", widget.WidgetTypeId);
            return View(widget);
        }

        // GET: Widgets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var widget = await _context.Widget
                .Include(w => w.WidgetType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (widget == null)
            {
                return NotFound();
            }

            return View(widget);
        }

        // POST: Widgets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var widget = await _context.Widget.FindAsync(id);
            _context.Widget.Remove(widget);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WidgetExists(int id)
        {
            return _context.Widget.Any(e => e.Id == id);
        }
    }
}
