using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FFK.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Story> Stories { get; set; } = new List<Story>();
    }
}
