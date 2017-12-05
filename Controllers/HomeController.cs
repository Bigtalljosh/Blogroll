using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Blogroll.Models;

namespace Blogroll.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult About() => View();

        public IActionResult Contact() => View();

        public IActionResult Blogs() => RedirectToAction("Index", "Blogs");

        public IActionResult Error() => View();
    }
}
