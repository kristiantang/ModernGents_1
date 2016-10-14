using ModernGents_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModernGents_1.Controllers
{
    public class BlogController : BaseController
    {
        // GET: Food
        public ActionResult Index(int id)
        {
            Category model = db.Categories.Find(id);
            return View(model);
        }
    }
}