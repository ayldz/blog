using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Blog.Core;
using Blog.Core.Models;

namespace Blog
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            using (BlogContext db = new BlogContext())
            {
                db.Database.CreateIfNotExists();
                
                /*Category category = new Category() { Name = "Category 1" };
                Category category2 = new Category() { Name = "Category 2" };
                Category category3 = new Category() { Name = "Category 3" };
                Category category4 = new Category() { Name = "Category 4" };
                Category category5 = new Category() { Name = "Category 5" };

                db.Categories.Add(category);
                db.Categories.Add(category2);
                db.Categories.Add(category3);
                db.Categories.Add(category4);
                db.Categories.Add(category5);

                db.SaveChanges();
                

                Post post = new Post() { Title = "I Love Food", ShortDescription = "", Description = "", Published="", PostedOn=DateTime.Now, Category= category };
                db.Posts.Add(post);
                db.SaveChanges();*/

            }

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
