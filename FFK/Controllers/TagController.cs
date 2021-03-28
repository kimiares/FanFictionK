using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FFK.Data;
using FFK.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FFK.Controllers
{
    [Authorize(Roles = "administrator")]
    public class TagController : Controller
    {
        ApplicationDbContext context;
        public TagController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult CreateTag()
        {

            return View();

        }
        [HttpPost]
        public async Task<IActionResult> CreateTag(Tag tag)
        {
            context.Tags.Add(tag);
            await context.SaveChangesAsync();
            return RedirectToAction("AdminPage", "Admin");

        }

    }
}
