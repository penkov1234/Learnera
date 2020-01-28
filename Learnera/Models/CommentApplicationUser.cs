using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Learnera.Models
{
    public class CommentApplicationUser
    {
        public CommentApplicationUser() { }

        public List<Comment> Comments;
        public List<ApplicationUser> Users;
    }
}