using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Learnera.Models {
    public class Reply {
        public Reply() {
            this.ReplyLikedBy = new List<ApplicationUser>();
        }

        public int Id { get; set; }
        public int LikesCount { get; set; }
        public string Text { get; set; }
        public virtual Comment CommentFrom { get; set; }
        public virtual ApplicationUser Author { get; set; }
        public virtual List<ApplicationUser> ReplyLikedBy{ get; set; }
    }
}