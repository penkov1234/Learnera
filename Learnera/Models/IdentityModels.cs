using System.Collections.Generic;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Learnera.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        //public int broj { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public virtual List<Learnera.Models.Subject> Subjects { get; set; }
        public virtual List<Learnera.Models.Comment> LikedComments { get; set; }
        public virtual List<Learnera.Models.Reply> LikedReplies { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
           
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<Learnera.Models.Subject> subjects { get; set; }
        public System.Data.Entity.DbSet<Learnera.Models.Presentation> presentantions { get; set; }
        public System.Data.Entity.DbSet<Learnera.Models.Slide> slides { get; set; }
        public System.Data.Entity.DbSet<Learnera.Models.Comment> comments { get; set; }
        public System.Data.Entity.DbSet<Learnera.Models.Reply> replies { get; set; }

    }
}