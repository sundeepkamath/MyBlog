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

        public ListViewModel(IBlogRepository repo, string text, string type, int pageNumber)
        {
            switch(type)
            {
                case "Category":
                    Posts = repo.GetPostsForCategory(text, pageNumber, ConfigUtil.ReadFromConfig(Constants.PAGE_SIZE));
                    TotalPosts = repo.TotalPostsForCategory(text);
                    Category = repo.Category(text);
                    break;
                case "Tag":
                    Posts = repo.GetPostsForTag(text, pageNumber, ConfigUtil.ReadFromConfig(Constants.PAGE_SIZE));
                    TotalPosts = repo.TotalPostsForTag(text);
                    Tag = repo.Tag(text);
                    break;
                default:
                    Posts = repo.GetPostsForSearch(text, pageNumber, ConfigUtil.ReadFromConfig(Constants.PAGE_SIZE));
                    TotalPosts = repo.TotalPostsForSearch(text);
                    Search = text;
                    break;
            }
            
        }

        public IList<Post> Posts { get; private set; }
        public int TotalPosts { get; private set; }

        public Category Category { get; private set; }

        public Tag Tag { get; private set; }

        public string Search { get; private set; }
    }
}