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
    }
}
