using FFK.Data;
using FFK.Models;
using FFK.Services;
using FFK.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FFK.Controllers
{
    public class AdminController : Controller
    {
        ApplicationDbContext context;
        UserManager<User> userManager;
        RoleManager<IdentityRole> roleManager;
        SignInManager<User> signInManager;

        public AdminController(ApplicationDbContext context, UserManager<User> userManager, RoleManager<IdentityRole> roleManager, SignInManager<User> signInManager)
        {
            this.context = context;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AdminPage(int page = 1)
        {

            int pageSize = 10;



            IQueryable<Story> storiesTemp = context.Stories.Include(c => c.Category);
            var count = await storiesTemp.CountAsync();


            IEnumerable<Story> stories = storiesTemp.Skip((page - 1) * pageSize).Take(pageSize);
            Pagination pagination = new Pagination(count, page, pageSize);
            var storyViewModel = new StoryViewModel
            {
                //Stories = context.Stories.Where(s=>!s.IsPosted).ToList(),
                Stories = stories,
                Categories = context.Categories.ToList(),
                Users = userManager.Users.ToList(),
                Pagination = pagination


            };

            return View("AdminPage", storyViewModel);

        }

        // LISTS
        public IActionResult GetAllUsers()
        {
            return View(userManager.Users.ToList());
        }
        public IActionResult GetAllStories()
        {
            return View(userManager.Users.ToList());
        }

        public IActionResult GetAllRoles()
        {
            return View(roleManager.Roles.ToList());
        }
        public IActionResult GetAllCategories()
        {
            return View(context.Categories.ToList());
        }
        public IActionResult GetAllTags()
        {
            return View(context.Tags.ToList());
        }
    }
}
