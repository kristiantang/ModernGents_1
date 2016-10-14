using ModernGents_1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ModernGents_1.Controllers
{
    public class AdminController : BaseController
    {
        // GET: Admin
        public ActionResult Index()
        {
            List<Posts> model = db.Posts.ToList();

            return View(model);
        }

        [Authorize]
        public ActionResult UserPanel()
        {
            List<Posts> Posts = db.Posts.ToList();

            return View(Posts);
        }

        public ActionResult Create()
        {
            var getCategoryList = db.Categories.ToList();
            SelectList CategoryList = new SelectList(getCategoryList, "Id", "Name");
            ViewBag.CategoryListName = CategoryList;
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(Posts Post)
        {
            if (ModelState.IsValid)
            {
                db.Posts.Add(Post);
                db.SaveChanges();
                return RedirectToAction("UserPanel");
            }

            return View(Post);
        }

        // GET: Posts/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            var getCategoryList = db.Categories.ToList();
            SelectList CategoryList = new SelectList(getCategoryList, "Id", "Name");
            ViewBag.CategoryListName = CategoryList;

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Posts post = db.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        // POST: Posts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Posts post)
        {
            if (ModelState.IsValid)
            {
                db.Entry(post).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("UserPanel");
            }
            return View(post);
        }


        // GET: Posts/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Posts posts = db.Posts.Find(id);
            if (posts == null)
            {
                return HttpNotFound();
            }
            return View(posts);
        }

        // POST: Posts/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Posts posts = db.Posts.Find(id);
            db.Posts.Remove(posts);
            db.SaveChanges();
            return RedirectToAction("UserPanel");
        }
    }
}