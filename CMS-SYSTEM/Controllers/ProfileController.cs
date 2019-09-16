using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS_SYSTEM.Models;
using CMS_SYSTEM.viewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CMS_SYSTEM.Controllers
{
    [Authorize]

    public class ProfileController : Controller
    {
        private readonly CMSPROJECT3Context _context;
        public ProfileController(CMSPROJECT3Context context)
        {
            _context = context;
        }
        // GET: UserProfile
        [HttpGet]
        public IActionResult Index()
        {
            //var data = await _context.Websites.Where(x => x.CreatedBy == currentUser).ToListAsync();

            /* Select List Of Websites From many to many Table (UserWebsites)
             * where the user email 
            */

            return View();


        }

        public JsonResult GetWebsites()
        {
            var currentUserEmail = _context.AspNetUsers.SingleOrDefault(u => u.UserName == User.Identity.Name).Email;
            var WebsitesData = (from userWebsites in _context.UserWebsites
                                join websites in _context.Websites
                                on userWebsites.WebsiteId equals websites.Id
                                where userWebsites.UserEmail == currentUserEmail
                                //where websites.IsDeleted == false
                                select new
                                {
                                    id = websites.Id,
                                    name = websites.WebsiteName == null ? "" : websites.WebsiteName,
                                    createdBy = websites.CreatedBy == null ? "" : websites.CreatedBy,
                                    domainUrl = websites.DomainUrl == null ? "" : websites.DomainUrl,
                                    isDeleted = websites.IsDeleted

                                }).ToList();

            return Json(WebsitesData);
        }

        // GET: UserProfile/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var websites = await _context.Websites
                .FirstOrDefaultAsync(m => m.Id == id);
            if (websites == null)
            {
                return NotFound();
            }

            return View(websites);
        }

        [HttpGet]
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
        public async Task<IActionResult> Create(Websites websites)
        {
            //([Bind("Id,CreatedBy,DomainUrl,WebsiteName")] Websites websites)

            if (ModelState.IsValid)
            {
       //         var userData = _context.AspNetUsers.SingleOrDefault(x => x.UserName == User.Identity.Name);
                var websitesData = _context.Websites.Where(x => x.CreatedBy == User.Identity.Name).ToList();
                for(int i =0; i<websitesData.Count;i++)
                {
                    if (websitesData[i].WebsiteName == websites.WebsiteName)
                    {
                        if (websitesData[i].IsDeleted == false)
                        {
                            ModelState.AddModelError(string.Empty, "This website name already exists . Please choose another name .. ");
                            return View();
                        }
                    }
                }
                _context.Add(websites);
                _context.SaveChanges();
                var websiteID = websites.Id;
                Widget widget = new Widget();
                widget.CreatedDate = DateTime.Now;
                widget.CreatedBy = User.Identity.Name;
                widget.Title = websites.WebsiteName + "-Document";
                widget.WidgetOrdinal = 0;
                try
                {
                    int widgettypeid = _context.WidgetType.SingleOrDefault(x => x.Name == "Document").Id;
                    widget.WidgetTypeId = widgettypeid;
                }
                catch
                {
                    WidgetType widgetType = new WidgetType();
                    widgetType.Name = "Document";
                    widgetType.Description = "Base Page for any website";
                    widgetType.Section = "Body";
                    _context.Add(widgetType);
                    await _context.SaveChangesAsync();
                    int widgettypeid = _context.WidgetType.SingleOrDefault(x => x.Name == "Document").Id;
                    widget.WidgetTypeId = widgettypeid;
                }
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

                UserWebsites userWebsites = new UserWebsites();
                userWebsites.WebsiteId = websiteID;
                userWebsites.UserEmail = User.Identity.Name;
                _context.Add(userWebsites);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(websites);
        }


        // GET: UserProfile/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var websites = await _context.Websites.FindAsync(id);
            if (websites == null)
            {
                return NotFound();
            }
            return View(websites);
        }
        // POST: UserProfile/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CreatedBy,DomainUrl,WebsiteName")] Websites websites)
        {
            if (id != websites.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(websites);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WebsitesExists(websites.Id))
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
            return View(websites);
        }
        // GET: UserProfile/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var websites = await _context.Websites
                .FirstOrDefaultAsync(m => m.Id == id);
            if (websites == null)
            {
                return NotFound();
            }

            return View(websites);
        }
        private bool WebsitesExists(int id)
        {
            return _context.Websites.Any(e => e.Id == id);
        }
        // POST: UserProfile/Delete/5   
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var websites = await _context.Websites.FindAsync(id);
            websites.IsDeleted = !websites.IsDeleted;
            _context.Update(websites);
            //_context.UserWebsites.Remove(userWebsites);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Open(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var websites = await _context.Websites.FirstOrDefaultAsync(m => m.Id == id);
            if (websites == null)
            {
                return NotFound();
            }

            return View(websites);
        }
        [HttpGet]
        public async Task<IActionResult> AddUser(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var websites = await _context.Websites.FindAsync(id);
            if (websites == null)
            {
                return NotFound();
            }
            return View();


        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddUser(int id, [FromServices] IServiceProvider serviceProvider, addUserModel users)
        {
            var UserManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
            //Assign Admin role to the main User here we have given our newly registered 
            //login id for Admin management
            IdentityUser user = new IdentityUser();

            user = await UserManager.FindByEmailAsync(users.Email);
            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Invalid user email.");
                return View();
            }


            UserWebsites userWebsites = new UserWebsites();
            userWebsites.UserEmail = users.Email;
            userWebsites.WebsiteId = id;
            _context.Add(userWebsites);
            await UserManager.AddToRoleAsync(user, users.RoleName);
            await _context.SaveChangesAsync();
            return View();
        }

    }



}
