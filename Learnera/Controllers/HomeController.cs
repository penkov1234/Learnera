using Learnera.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Data.Entity;

namespace Learnera.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ApplicationUser specificUser = new ApplicationUser();
        public List<Subject> subjects = new List<Subject>();
        public ActionResult Index()
        {
            string username = "";
            if (System.Web.HttpContext.Current.User.Identity.IsAuthenticated)
            {
                username = System.Web.HttpContext.Current.User.Identity.Name;
            }
            specificUser = db.Users.Where(u => u.Email == username).FirstOrDefault();
            subjects = specificUser.Subjects;
            return View(subjects.ToList());
        }


        public ActionResult Presentations(int id)
        {


            return View();

        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult EditUser(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            var userDTO = new UserDTO();
            userDTO.id = user.Id;
            userDTO.name = user.Name;
            userDTO.lastName = user.LastName;
            userDTO.phoneNumber = user.PhoneNumber;
            return View(userDTO);
        }

        [HttpPost]
        public ActionResult EditUser(UserDTO userDTO)
        {
            var user = db.Users.Find(userDTO.id);
            user.Name = userDTO.name;
            user.LastName = userDTO.lastName;
            user.PhoneNumber = userDTO.phoneNumber;
            db.SaveChanges();
            return View(userDTO);
        }

    }
}