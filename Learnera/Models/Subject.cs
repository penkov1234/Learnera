using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Learnera.Models
{
    public class Subject
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The name must be at least 2 characters long.", MinimumLength = 2)]
        public string Name { get; set; }
        public virtual List<Presentation> Presentation { get; set; }
        public virtual List<ApplicationUser> Student { get; set; }
        public string Professor { get; set; }
    }
}