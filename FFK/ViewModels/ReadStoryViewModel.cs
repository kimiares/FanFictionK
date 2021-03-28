using FFK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FFK.ViewModels
{
    public class ReadStoryViewModel
    {
        public Story Story { get; set; }
        public Category Category { get; set; }
        public IEnumerable<User> Users { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
    }
}
