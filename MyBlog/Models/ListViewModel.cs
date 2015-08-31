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

        public IList<Post> Posts { get; set; }
        public int TotalPosts { get; set; }
    }
}