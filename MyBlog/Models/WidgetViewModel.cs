using MyBlog.Core.Entities;
using MyBlog.Core.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBlog.Models
{
    public class WidgetViewModel
    {
        public WidgetViewModel(IBlogRepository repo)
        {
            Categories = repo.GetCategories();
        }

        public IList<Category> Categories{ get; set; }
    }
}