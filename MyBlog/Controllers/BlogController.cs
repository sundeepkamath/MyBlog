using MyBlog.Core.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlog.Controllers
{
    public class BlogController : Controller
    {
        IBlogRepository _repo;

        public BlogController(IBlogRepository repo)
        {
            _repo = repo;
        }
        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }
    }
}