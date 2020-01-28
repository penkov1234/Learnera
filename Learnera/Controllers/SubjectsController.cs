using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Learnera.Models;

namespace Learnera.Controllers
{
    public class SubjectsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private List<SubjectsDTO> subjects = new List<SubjectsDTO>();
        string username = "";
        public ApplicationUser specificUser = new ApplicationUser();
        // GET: Subjects
        public ActionResult Index()
        {
            SubjectsDTO subjectDTO;
            if (System.Web.HttpContext.Current.User.Identity.IsAuthenticated)
            {
                username = System.Web.HttpContext.Current.User.Identity.Name;
            }
            specificUser = db.Users.Where(u => u.Email == username).FirstOrDefault();


            foreach (var subject in db.subjects.ToList())
            {
                subjectDTO = new SubjectsDTO();
                subjectDTO.subject = subject;
                if (specificUser.Subjects.Contains(subject))
                {
                    subjectDTO.isSelected = true;
                }
                else
                {
                    subjectDTO.isSelected = false;
                }
                subjects.Add(subjectDTO);
            }
            return View(subjects);
        }

        public ActionResult editSubjects(List<_SubjectsViewModel> subject)
        {

            if (System.Web.HttpContext.Current.User.Identity.IsAuthenticated)
            {
                username = System.Web.HttpContext.Current.User.Identity.Name;
            }
            specificUser = db.Users.Where(u => u.Email == username).FirstOrDefault();
            db.Users.Where(u => u.Email == username).FirstOrDefault().Subjects.RemoveRange(0, specificUser.Subjects.Count);

            if (subject == null)
            {
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            List<Subject> tempSubjects = new List<Subject>();
            foreach (_SubjectsViewModel sub in subject)
            {
                var specificSubject = db.subjects.Where(s => s.Name == sub.Name && s.Professor == sub.Professor).FirstOrDefault();
                tempSubjects.Add(specificSubject);
            }
            db.Users.Where(u => u.Email == username).FirstOrDefault().Subjects = tempSubjects;
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult GetSubjects()
        {
            return PartialView("_Subjects_Partial",db.subjects.ToList());
        }
        public ActionResult GetAllSubjects()
        {
            var subjects = db.subjects.ToList();
            return View("AllSubjects",subjects);
        }
        // GET: Subjects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subject subject = db.subjects.Find(id);
            if (subject == null)
            {
                return HttpNotFound();
            }
            return View(subject);
        }

        // GET: Subjects/Create
        public ActionResult Create()
        {
            List<string> proffesors = db.subjects.ToList().Select(s => s.Professor).Distinct().ToList();
            ViewBag.professors = proffesors;
            return View();
        }

        // POST: Subjects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Professor")] Subject subject)
        {
            if (ModelState.IsValid)
            {
                db.subjects.Add(subject);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(subject);
        }

        // GET: Subjects/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subject subject = db.subjects.Find(id);
            if (subject == null)
            {
                return HttpNotFound();
            }
            return View(subject);
        }

        // POST: Subjects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] Subject subject)
        {
            if (ModelState.IsValid)
            {
                db.Entry(subject).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(subject);
        }

        // GET: Subjects/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subject subject = db.subjects.Find(id);
            if (subject == null)
            {
                return HttpNotFound();
            }
            return View(subject);
        }

        // POST: Subjects/Delete/5
        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            Subject subject = db.subjects.Find(id);
            foreach(ApplicationUser u in db.Users.ToList()){
                var user = db.Users.Where(us => us.Id == u.Id).First();
                user.Subjects.Remove(subject);
                db.SaveChanges();
            }
            db.subjects.Remove(subject);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
