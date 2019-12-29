using BlogEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogEngine.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Blog blog)
        {
            if (ModelState.IsValid)
            {
                var ctx = new ApplicationDbContext();

                ctx.Blogs.Add(blog);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult Generic()
        {
            return View();
        }
    }
}