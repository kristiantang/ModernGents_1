using ModernGents_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModernGents_1.Controllers
{
    public class BaseController : Controller
    {
        public DataContext db = new DataContext();

        public BaseController()
        {
            var SessionContext = System.Web.HttpContext.Current.Session;

            if (SessionContext["Menu"] == null)
            {
                SessionContext["Menu"] = db.Categories.ToList();
            }
        }
    }
}