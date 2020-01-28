using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Learnera.Models
{
    public class Presentation
    {
        public int Id { get; set; }
        public string name { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual List<Slide> Slides { get; set; }
        public int Lesson { get; set; }

    }
}