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
    public class ProfileController : Controller
    {
        private readonly CMSPROJECT3Context _context;

        public ProfileController(CMSPROJECT3Context context)
        {
            _context = context; 
        }

        // GET: UserProfile
        public async Task<IActionResult> Index()
        {
            var currentUser = User.Identity.Name;
            var data = await _context.UserWebsites.Where(x => x.CreatedBy == currentUser).ToListAsync();
            if (data != null)
            {
                return View(data);
            }
            else
            {
                return NotFound();
            }
            
        }

        // GET: UserProfile/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userWebsites = await _context.UserWebsites
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userWebsites == null)
            {
                return NotFound();
            }

            return View(userWebsites);
        }

        // GET: UserProfile/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserProfile/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CreatedBy,DomainUrl,WebsiteName")] UserWebsites userWebsites)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userWebsites);
                await _context.SaveChangesAsync();
                Widget widget = new Widget();
                widget.CreatedDate = DateTime.Now;
                widget.CreatedBy = User.Identity.Name;
                widget.Title = userWebsites.WebsiteName + "-Document";
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
                _context.Add(widget);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userWebsites);
        }

        // GET: UserProfile/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userWebsites = await _context.UserWebsites.FindAsync(id);
            if (userWebsites == null)
            {
                return NotFound();
            }
            return View(userWebsites);
        }

        // POST: UserProfile/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CreatedBy,DomainUrl,WebsiteName")] UserWebsites userWebsites)
        {
            if (id != userWebsites.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userWebsites);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserWebsitesExists(userWebsites.Id))
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
            return View(userWebsites);
        }

        // GET: UserProfile/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userWebsites = await _context.UserWebsites
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userWebsites == null)
            {
                return NotFound();
            }

            return View(userWebsites);
        }

        // POST: UserProfile/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userWebsites = await _context.UserWebsites.FindAsync(id);
            userWebsites.isDeleted = true;
            _context.Update(userWebsites);
            //_context.UserWebsites.Remove(userWebsites);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserWebsitesExists(int id)
        {
            return _context.UserWebsites.Any(e => e.Id == id);
        }

        public async Task<IActionResult> Open(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userWebsites = await _context.UserWebsites
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userWebsites == null)
            {
                return NotFound();
            }

            return View(userWebsites);
        }
    }
}
