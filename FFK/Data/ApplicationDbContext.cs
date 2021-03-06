using FFK.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using FFK.ViewModels;

namespace FFK.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<Story> Stories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<FFK.Models.Role> Role { get; set; }
        
        public DbSet<FFK.ViewModels.ChangePasswordViewModel> ChangePasswordViewModel { get; set; }
        
        public DbSet<FFK.ViewModels.EditUserViewModel> EditUserViewModel { get; set; }
    }
}
