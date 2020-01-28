using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Learnera.Models {
    public class ReplyApplicationUser {
        public ReplyApplicationUser() { }

        public List<Reply> Replies;
        public List<ApplicationUser> Users;
    }
}