using MyBlog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Core.RepositoryInterfaces
{
    public interface IBlogRepository
    {
        IQueryable<Post> GetPosts();

    }
}
