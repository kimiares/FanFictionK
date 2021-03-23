using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FFK.Models
{
    public class Story
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Lead { get; set; }
        public string Text { get; set; }
        public DateTime CreatingDate { get; set; } = DateTime.Now;
        public DateTime? EditingDate { get; set; }
        public bool IsPosted { get; set; }
        public User User { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Tag> Tags { get; set; } = new List<Tag>();
    }
}
