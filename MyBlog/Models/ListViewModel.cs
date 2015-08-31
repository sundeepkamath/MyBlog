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

        public ListViewModel(IBlogRepository repo, string urlSlug, string type, int pageNumber)
        {
            switch(type)
            {
                case "Tag":
                    Posts = repo.GetPostsForTag(urlSlug, pageNumber, ConfigUtil.ReadFromConfig(Constants.PAGE_SIZE));
                    TotalPosts = repo.TotalPostsForTag(urlSlug);
                    Tag = repo.Tag(urlSlug);
                    break;
                default:
                    Posts = repo.GetPostsForCategory(urlSlug, pageNumber, ConfigUtil.ReadFromConfig(Constants.PAGE_SIZE));
                    TotalPosts = repo.TotalPostsForCategory(urlSlug);
                    Category = repo.Category(urlSlug);
                    break;
            }
            
        }

        public IList<Post> Posts { get; set; }
        public int TotalPosts { get; set; }

        public Category Category { get; set; }

        public Tag Tag { get; set; }
    }
}