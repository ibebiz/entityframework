using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;
using PagedList;
using PagedList.Mvc;

namespace WebApplication6.Controllers
{
    public class BlogController : Controller
    {
        private BlogContext db = new BlogContext();

        // GET: /Blog/
        public ActionResult Index(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 7;
            //return View(db.TrangSucs.ToList());
            return View(db.BlogPosts.ToList().OrderBy(n => n.Id).ToPagedList(pageNumber, pageSize));
        }

        // GET: /Blog/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QLBlog qlblog = db.BlogPosts.Find(id);
            if (qlblog == null)
            {
                return HttpNotFound();
            }
            return View(qlblog);
        }

        // GET: /Blog/Create
       
        public ActionResult CreateCategory()
        {
          
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateCategory([Bind(Include = "Id,Name")] Category category)
        {
           
            if (ModelState.IsValid)
            {
                category.Id = Guid.NewGuid();
                db.Categories.Add(category);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(category);
        }

        // POST: /Blog/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        public ActionResult Create()
        {
            ViewBag.Id = new SelectList(db.Categories.ToList().OrderBy(n => n.Name), "ID", "Name");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Title,Content,PublishDate,CategoryId")] QLBlog qlblog)
        {
            ViewBag.Id = new SelectList(db.Categories.ToList().OrderBy(n => n.Id), "Id", "Name"); 
            if (ModelState.IsValid)
            {
                qlblog.Id = Guid.NewGuid();
                db.BlogPosts.Add(qlblog);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(qlblog);
        }

        // GET: /Blog/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QLBlog qlblog = db.BlogPosts.Find(id);
            if (qlblog == null)
            {
                return HttpNotFound();
            }
            return View(qlblog);
        }

        // POST: /Blog/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Title,Content,PublishDate")] QLBlog qlblog)
        {
            if (ModelState.IsValid)
            {
                db.Entry(qlblog).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(qlblog);
        }

        // GET: /Blog/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QLBlog qlblog = db.BlogPosts.Find(id);
            if (qlblog == null)
            {
                return HttpNotFound();
            }
            return View(qlblog);
        }

        // POST: /Blog/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            QLBlog qlblog = db.BlogPosts.Find(id);
            db.BlogPosts.Remove(qlblog);
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
