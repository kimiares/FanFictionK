using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FFK.Data;
using FFK.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FFK.Controllers
{
    [Authorize(Roles = "administrator")]
    public class CategoryController : Controller
    {
        ApplicationDbContext context;


        public CategoryController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(Category category)
        {
            context.Categories.Add(category);
            await context.SaveChangesAsync();
            return RedirectToAction("AdminPage", "Admin");
        }
        [HttpGet]
        public async Task<IActionResult> EditCategory(int? id)
        {
            if (id != null)
            {
                Category category = await context.Categories.FirstOrDefaultAsync(b => b.Id == id);
                if (category != null)
                {
                    return View(category);
                }

            }
            return NotFound();

        }
        [HttpPost]
        
        public async Task<IActionResult> EditCategory(Category category)
        {
            context.Categories.Update(category);
            await context.SaveChangesAsync();
            return RedirectToAction("AdminPage", "Admin");
        }
        public async Task<IActionResult> CategoryOnHomePage()
        {

            List<Category> categories = await context.Categories.ToListAsync();


            return PartialView("_CategoryOnHomePage", categories);
        }
    }
}
