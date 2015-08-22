using MyBlog.Core.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
