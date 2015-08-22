using MyBlog.Core.Entities;
using System.Linq;

namespace MyBlog.Core.RepositoryInterfaces
{
    public interface IBlogRepository
    {
        IQueryable<Post> GetPosts();

    }
}
