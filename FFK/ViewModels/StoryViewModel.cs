using FFK.Models;
using FFK.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FFK.ViewModels
{
    public class StoryViewModel
    {
        public IEnumerable<Story> Stories { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<User> Users { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
        public Pagination Pagination { get; set; }
    }
}
