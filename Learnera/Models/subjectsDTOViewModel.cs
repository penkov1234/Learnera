using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Learnera.Models
{
    public class subjectsDTOViewModel
    {
        public bool isSelected { get; set; }
        public List<_SubjectsViewModel> subject { get; set; }
    }
}