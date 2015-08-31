using MyBlog.Core.RepositoryInterfaces;
using System.Linq;
using MyBlog.Core.Entities;
using MyBlog.Core.DatabaseContexts;
using System.Data.Entity;
using System.Collections.Generic;
using System;

namespace MyBlog.Core.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        BlogContext _context;
        public BlogRepository(BlogContext context)
        {
            _context = context;
        }

        public IList<Post> GetPosts(int pageNumber, int pageSize)
        {
            var pagesToSkip = pageNumber == 1?0 : ( pageNumber > 1 ? (pageNumber - 1) : 1);

            return _context.Posts
                    .Where(p => p.Published)
                    .OrderByDescending(p => p.PostedOn)
                    .Skip(pagesToSkip * pageSize)
                    .Take(pageSize)
                    .Include(p => p.Category)
                    .ToList<Post>();
        }

        public int TotalPosts()
        {
            return _context.Posts.Where(p => p.Published).Count();
        }

        public IList<Post> GetPostsForCategory(string categorySlug, int pageNumber, int pageSize)
        {
            var pagesToSkip = pageNumber == 1 ? 0 : (pageNumber > 1 ? (pageNumber - 1) : 1);

            return _context.Posts
                    .Where(p => p.Category.UrlSlug == categorySlug && p.Published)
                    .OrderByDescending(p => p.PostedOn)
                    .Skip(pagesToSkip * pageSize)
                    .Take(pageSize)
                    .Include(p => p.Category)
                    .Include(p => p.Tags)
                    .ToList<Post>();
        }

        public int TotalPostsForCategory(string categorySlug)
        {
            return _context.Posts
                    .Where(p => p.Published && p.Category.UrlSlug == categorySlug)
                    .Count();

        }

        public Category Category(string categorySlug)
        {
            return _context.Categories
                    .FirstOrDefault<Category>(c=> c.UrlSlug == categorySlug);
        }

        public IList<Post> GetPostsForTag(string tagSlug, int pageNumber, int pageSize)
        {
            var pagesToSkip = pageNumber == 1 ? 0 : (pageNumber > 1 ? (pageNumber - 1) : 1);

            return _context.Posts
                    .Where(p => p.Published && p.Tags.Any(t => t.UrlSlug == tagSlug))
                    .OrderByDescending(p => p.PostedOn)
                    .Skip(pagesToSkip * pageSize)
                    .Take(pageSize)
                    .Include(p => p.Category)
                    .Include(p => p.Tags)
                    .ToList<Post>();
        }

        public int TotalPostsForTag(string tagSlug)
        {
            return _context.Posts
                    .Where(p => p.Published && p.Tags.Any(t => t.UrlSlug == tagSlug))
                    .Count();
        }

        public Tag Tag(string tagSlug)
        {
            return _context.Tags
                    .FirstOrDefault<Tag>(t => t.UrlSlug == tagSlug);
        }
    }
}
