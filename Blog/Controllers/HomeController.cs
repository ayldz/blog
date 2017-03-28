using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.Core;
using Blog.Core.Models;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            BlogContext blogContext = new BlogContext();

            var Posts = blogContext.Posts.ToList();

            return View(Posts);
        }

        public ActionResult byCategories(int id)
        {
            BlogContext blogContext = new BlogContext();

            var posts = blogContext.Posts.Where(p => p.Category.Id == id).ToList();

            return View(posts);
        }

        public ActionResult Post(int id)
        {
            BlogContext blogContext = new BlogContext();

            var Posts = blogContext.Posts.Find(id);

            return View(Posts);
        }
    }
}