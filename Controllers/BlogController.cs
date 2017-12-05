using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Blogroll.Models;

namespace Blogroll.Controllers
{
    public class BlogsController : Controller
    {
        private readonly BloggingContext _context;
        private readonly ILogger<BlogsController> _logger;


        public BlogsController(BloggingContext context, ILogger<BlogsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
           // var posts = _context.Posts.ToList();
            //Return the posts where the blog id equals the first blog because we only have one blog
            return View(); //posts.TakeWhile(p => p.BlogId == _context.Blogs.FirstOrDefault().BlogId));
        }

        //public IActionResult Create()
        //{
        //    return View();
        //}

        //public IActionResult Search(string search)
        //{
        //    return View(_context.Posts.ToList().TakeWhile(p => p.Tags.Contains(search)));
        //}

        //public IActionResult Test()
        //{
        //    return View();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Create(Post post)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            //For now we only have one blog, so set the ID to be that blog.
        //            post.BlogId = _context.Blogs.FirstOrDefault().BlogId;

        //            _context.Posts.Add(post);
        //            _context.SaveChanges();
        //        }
        //        catch (Exception ex)
        //        {
        //            _logger.LogError($"Failed to save post. Details: {ex.Message}");
        //            RedirectToAction("Error", "Home");
        //        }
                
        //        return RedirectToAction("Index");
        //    }

        //    return View(post);
        //}
    }
}
