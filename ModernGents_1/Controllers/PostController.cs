using ModernGents_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModernGents_1.Controllers
{
    public class PostController : BaseController
    {
        // GET: Post
        public ActionResult Detail(int id)
        {
            Posts model = db.Posts.Find(id);

            return View(model);
        }

        //public ActionResult UpdateProduct(Posts model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
        //    db.SaveChanges();
        //    return Ok(model);
        //}

        //public ActionResult Delete(int id)
        //{
        //    Posts Posts = new Posts();
        //    Posts.DeletePost(Id);
        //    return RedirectToAction("UserPanel");
        //}
    }
}