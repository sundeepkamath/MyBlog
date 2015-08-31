﻿using MyBlog.Core.RepositoryInterfaces;
using MyBlog.Models;
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
        public ViewResult Posts(int pageNumber = 1)
        {
            var viewModel = new ListViewModel(_repo, pageNumber);

            ViewBag.Title = "Latest Posts";

            return View("List", viewModel);
        }

        public ViewResult Category(string category, int pageNumber = 1)
        {
            var viewModel = new ListViewModel(_repo, category, pageNumber);

            if (viewModel.Category == null)
                throw new HttpException(404, "Category Not found");

            ViewBag.Title = string.Format(@"Latest posts on category ""{0}""", 
                                            viewModel.Category.Name);

            return View("List", viewModel);

        }
    }
}