using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using teqBlogModel;

namespace teqBlog.Controllers
{
    public class HomeController : Controller
    {
       teqBlogEntities context = new teqBlogEntities();
    
        //
        // GET: /Home/

       public ActionResult Index()
       {
           var blogPosts = (from p in context.BlogPosts
                            select p).OrderByDescending(x=>x.BlogPostID);


           return View(blogPosts.ToList());
       }
       //
       //GET: /Home/Create
       public ActionResult Create()
       {
           return View();
       }

       //
       //POST: /Home/Create
       [HttpPost]
       public ActionResult Create(BlogPost post)
       {
           if (ModelState.IsValid)
           {
               //set datetime values
               post.DateCreated = DateTime.Now;
               context.BlogPosts.AddObject(post);
               context.SaveChanges();
               return RedirectToAction("Index");
           }
           return View(post);
       }
    }
}
