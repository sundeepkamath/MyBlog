using MyBlog.Core.RepositoryInterfaces;
using System;
using System.Linq;
using MyBlog.Core.Entities;
using MyBlog.Core.DatabaseContexts;

namespace MyBlog.Core.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        BlogContext _context;
        public BlogRepository(BlogContext context)
        {
            _context = context;
        }

        public IQueryable<Post> GetPosts()
        {
            return _context.Posts;
        }
    }
}
