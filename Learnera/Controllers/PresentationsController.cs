using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Learnera.Models;

namespace Learnera.Controllers
{
    public class PresentationsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Presentations
        public ActionResult Show(int id)
        {

            var pres = db.presentantions.Where(p => p.Subject.Id == id).ToList();

            return View(pres);
            
        }
        public ActionResult Slides(int id) {
            var pres = db.slides.Where(s => s.Presentation.Id == id).ToList();
            return View(pres);

        }
        public ActionResult Index()
        {
            return View(db.presentantions.ToList());
        }

        [HttpGet]
        public async Task<ActionResult> ShowComments(int id)
        {
            var com = db.comments.ToList();

            var model = db.comments.ToList().Where(c => c.Slide.Id == id).ToList();
            Console.WriteLine("Got model: " + id);

            return PartialView("ShowComments", model);
        }
        [HttpPost]
        public async Task<ActionResult> AddComment(String email, String text, int slideId)
        {
            var user = db.Users.Where(u => u.UserName == email).FirstOrDefault();
            var slide = db.slides.Where(s => s.Id == slideId).First();
            Comment com = new Comment();
            com.Author = user;
            com.Text = text;
            com.Slide = slide;
            db.comments.Add(com);
            db.SaveChanges();
            var model = com;
            return PartialView("_NewCommentPartial", model);
        }
        [HttpPost]
        public async Task<ActionResult> AddReply(String email, String text, string commentId)
        {
            var user = db.Users.Where(u => u.UserName == email).First();
            var commentIdParsed = Int32.Parse(commentId);
            var comment = db.comments.Where(c => c.Id == commentIdParsed).First();
            Reply reply = new Reply();
            reply.Author = user;
            reply.CommentFrom = comment;
            reply.Text = text;
            db.replies.Add(reply);
            db.SaveChanges();
            var model = reply;
            return PartialView("_NewReplyPartial", model);
        }

        // GET: Presentations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Presentation presentation = db.presentantions.Find(id);
            if (presentation == null)
            {
                return HttpNotFound();
            }
            return View(presentation);
        }

        // GET: Presentations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Presentations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,name")] Presentation presentation)
        {
            if (ModelState.IsValid)
            {
                db.presentantions.Add(presentation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(presentation);
        }

        // GET: Presentations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Presentation presentation = db.presentantions.Find(id);
            if (presentation == null)
            {
                return HttpNotFound();
            }
            return View(presentation);
        }

        // POST: Presentations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,name")] Presentation presentation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(presentation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(presentation);
        }

        // GET: Presentations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Presentation presentation = db.presentantions.Find(id);
            if (presentation == null)
            {
                return HttpNotFound();
            }
            return View(presentation);
        }

        [HttpPost]
        public void ChangeCommentLikes(int id, int value) {
            var com = db.comments.Where(c => c.Id == id).FirstOrDefault();
            com.LikesCount += value;
            db.SaveChanges();
        }

        [HttpPost]
        public void ChangeReplyLikes(int id, int value) {
            var rep = db.replies.ToList().Find(c => c.Id == id);
            rep.LikesCount += value;
            db.SaveChanges();
        }

        // POST: Presentations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Presentation presentation = db.presentantions.Find(id);
            db.presentantions.Remove(presentation);
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
