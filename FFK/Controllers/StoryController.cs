using FFK.Data;
using FFK.Models;
using FFK.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using FFK.Services;

namespace FFK.Controllers
{
    public class StoryController : Controller
    {
        UserManager<User> userManager;
        readonly ApplicationDbContext context;
        List<Category> categories = new List<Category>();
        List<Tag> tags = new List<Tag>();
        public StoryController(UserManager<User> userManager, ApplicationDbContext context)
        {
            this.userManager = userManager;
            this.context = context;
        }
        [HttpGet]
        public IActionResult CreateStory()
        {
            ViewBag.Category = new SelectList(context.Categories.ToList(), "Id", "Name");
            List<Tag> tags = context.Tags.ToList();
            ViewBag.Tag = new MultiSelectList(tags, "Id", "Name");


            return View();

        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateStory(Story story, string tags)
        {

            Category category = categories.FirstOrDefault(c => c.Id == story.CategoryId);

            


            story.IsPosted = true;
            story.EditingDate = DateTime.Now;
            story.Image = "image";
            story.User = userManager.Users.FirstOrDefault(u => u.UserName== User.Identity.Name);

            //tags
            

            //end 





            //story.Tags.AddRange(tags)
            //story.Tags = tags;




            context.Stories.Add(story);
            await context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            ViewBag.Category = new SelectList(context.Categories.ToList(), "Id", "Name");
            Story story = await context.Stories.FirstOrDefaultAsync(s => s.Id == id);
            if (story != null)
            {
                return View(story);
            }

            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Story story)
        {
            Category category = categories.FirstOrDefault(c => c.Id == story.CategoryId);
            story.EditingDate = DateTime.Now;
            context.Stories.Update(story);
            await context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> ReadSelectStory(int id)
        {
            Story storySelected = await context.Stories.FirstOrDefaultAsync(s => s.Id == id);
            Category categorySelected = await context.Categories.FirstOrDefaultAsync(s => s.Id == storySelected.CategoryId);
            /*User userSelected = await context.Users.FirstOrDefaultAsync(u => u.UserName == storySelected.User.UserName);*/


            var ReadStoryViewModel = new ReadStoryViewModel
            {
                Story = storySelected,
                Category = categorySelected,
                Users = userManager.Users.ToList()

            };

            return View(ReadStoryViewModel);

        }
        [HttpPost]
        public async Task<IActionResult> MultiplyStoryDelete(int[] storiesIds)
        {
            if (storiesIds != null)
            {


                foreach (var s in storiesIds)
                {
                    Story storyToDelete = await context.Stories.FirstOrDefaultAsync(st => st.Id == s);

                    if (storyToDelete != null)
                    {
                        //context.Stories.Remove(storyToDelete);
                        context.Remove(storyToDelete);



                        await context.SaveChangesAsync();

                    }
                    else
                    {
                        ModelState.AddModelError("", "Story Not Found");
                    }

                }
            }
            return RedirectToAction("AdminPage", "Admin");




        }
        public async Task<IActionResult> StoriesOnHomePage(int page = 1)
        {
            int pageSize = 3;
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

            return PartialView("_StoriesOnHomePage", storyViewModel);
        }
        
    }
}
