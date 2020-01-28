using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Learnera.Models {
    public class Comment {
        public Comment() {
            this.Replies = new List<Reply>();
            this.CommentLikedBy = new List<ApplicationUser>();
        }

        public int Id { get; set; }
        public int LikesCount { get; set; }
        public string Text { get; set; }
        public virtual Slide Slide { get; set; }
        public virtual List<Reply> Replies { get; set; }
        public virtual ApplicationUser Author { get; set; }
        public virtual List<ApplicationUser> CommentLikedBy { get; set; }
        
    }
}