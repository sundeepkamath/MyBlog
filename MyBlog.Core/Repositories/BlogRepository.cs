using MyBlog.Core.RepositoryInterfaces;
using System;
using System.Linq;
using MyBlog.Core.Entities;

namespace MyBlog.Core.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        public IQueryable<Post> GetPosts()
        {
            throw new NotImplementedException();
        }
    }
}
