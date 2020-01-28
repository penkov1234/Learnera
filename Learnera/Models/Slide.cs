using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Learnera.Models
{
    public class Slide
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public virtual Presentation Presentation { get; set; }
        public virtual List<Comment> Comments { get; set; }
    }
}