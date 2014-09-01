using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_Project.Models.EntityModel;

namespace MVC_Project.Controllers
{
    public class NewRelDbsController : Controller
    {
        private TestDbEntities db = new TestDbEntities();

        // GET: NewRelDbs
        public ActionResult Index()
        {
            var newRelDbs = db.NewRelDbs.Include(n => n.Article).Include(n => n.Mistake);
            return View(newRelDbs.ToList());
        }

        // GET: NewRelDbs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewRelDb newRelDb = db.NewRelDbs.Find(id);
            if (newRelDb == null)
            {
                return HttpNotFound();
            }
            return View(newRelDb);
        }

        // GET: NewRelDbs/Create
        public ActionResult Create()
        {
            ViewBag.ArticleNo = new SelectList(db.Articles, "ArticleNo", "ArticleName");
            ViewBag.MistakeNo = new SelectList(db.Mistakes, "MistakeNo", "MistakeDescription");
            return View();
        }

        // POST: NewRelDbs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Field1,ArticleNo,MistakeNo")] NewRelDb newRelDb)
        {
            if (ModelState.IsValid)
            {
                db.NewRelDbs.Add(newRelDb);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ArticleNo = new SelectList(db.Articles, "ArticleNo", "ArticleName", newRelDb.ArticleNo);
            ViewBag.MistakeNo = new SelectList(db.Mistakes, "MistakeNo", "MistakeDescription", newRelDb.MistakeNo);
            return View(newRelDb);
        }

        // GET: NewRelDbs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewRelDb newRelDb = db.NewRelDbs.Find(id);
            if (newRelDb == null)
            {
                return HttpNotFound();
            }
            ViewBag.ArticleNo = new SelectList(db.Articles, "ArticleNo", "ArticleName", newRelDb.ArticleNo);
            ViewBag.MistakeNo = new SelectList(db.Mistakes, "MistakeNo", "MistakeDescription", newRelDb.MistakeNo);
            return View(newRelDb);
        }

        // POST: NewRelDbs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Field1,ArticleNo,MistakeNo")] NewRelDb newRelDb)
        {
            if (ModelState.IsValid)
            {
                db.Entry(newRelDb).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ArticleNo = new SelectList(db.Articles, "ArticleNo", "ArticleName", newRelDb.ArticleNo);
            ViewBag.MistakeNo = new SelectList(db.Mistakes, "MistakeNo", "MistakeDescription", newRelDb.MistakeNo);
            return View(newRelDb);
        }

        // GET: NewRelDbs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewRelDb newRelDb = db.NewRelDbs.Find(id);
            if (newRelDb == null)
            {
                return HttpNotFound();
            }
            return View(newRelDb);
        }

        // POST: NewRelDbs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NewRelDb newRelDb = db.NewRelDbs.Find(id);
            db.NewRelDbs.Remove(newRelDb);
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
