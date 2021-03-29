using FFK.Data;
using FFK.Models;
using FFK.Services;
using FFK.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FFK.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        ApplicationDbContext context;
        UserManager<User> userManager;
        RoleManager<IdentityRole> roleManager;
        SignInManager<User> signInManager;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, UserManager<User> userManager, RoleManager<IdentityRole> roleManager, SignInManager<User> signInManager)
        {
            this.context = context;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.signInManager = signInManager;
            this.logger = logger;
        }

        

        public async Task<IActionResult> Index(int page = 1)
        {


            int pageSize = 5;



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
                Tags = context.Tags.Include(t => t.Stories).ToList(),
                Pagination = pagination


            };

            return View("Index", storyViewModel);
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
