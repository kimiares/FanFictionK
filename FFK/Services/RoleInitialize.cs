using FFK.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FFK.Services
{
    public class RoleInitialize
    {
        public static async Task InitializeAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            string adminEmail = "admin@gmail.com";
            string password = "123";
            if (await roleManager.FindByNameAsync("AdminRole") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("AdminRole"));

            }
            if (await roleManager.FindByNameAsync("AuthorRole") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("AuthorRole"));
            }
            if (await userManager.FindByNameAsync(adminEmail) == null)
            {
                User admin = new() { Email = adminEmail, UserName = adminEmail, IsActive = true };
                IdentityResult result = await userManager.CreateAsync(admin, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, "AdminRole");

                }
            }
        }
    }
}
