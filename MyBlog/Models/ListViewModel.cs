using MyBlog.Core.Entities;
using MyBlog.Core.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBlog.Models
{
    public class ListViewModel
    {
        public ListViewModel(IBlogRepository repo, int pageNumber)
        {
            Posts = repo.GetPosts(pageNumber, ConfigUtil.ReadFromConfig(Constants.PAGE_SIZE));
            TotalPosts = repo.TotalPosts();
        }

        public ListViewModel(IBlogRepository repo, string category, int pageNumber)
        {
            Posts = repo.GetPostsForCategory(category, pageNumber, ConfigUtil.ReadFromConfig(Constants.PAGE_SIZE));
            TotalPosts = repo.TotalPostsForCategory(category);
            Category = repo.Category(category);
        }

        public IList<Post> Posts { get; set; }
        public int TotalPosts { get; set; }

        public Category Category { get; set; }
    }
}