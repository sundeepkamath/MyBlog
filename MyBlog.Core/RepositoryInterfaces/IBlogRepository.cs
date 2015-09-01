using MyBlog.Core.Entities;
using System.Collections.Generic;
using System.Linq;

namespace MyBlog.Core.RepositoryInterfaces
{
    public interface IBlogRepository
    {
        IList<Post> GetPosts(int pageNumber, int pageSize);

        int TotalPosts();

        IList<Post> GetPostsForCategory(string categorySlug, int pageNumber, int pageSize);

        int TotalPostsForCategory(string categorySlug);

        Category Category(string categorySlug);

        IList<Post> GetPostsForTag(string tagSlug, int pageNumber, int pageSize);

        int TotalPostsForTag(string tagSlug);

        Tag Tag(string tagSlug);

        IList<Post> GetPostsForSearch(string search, int pageNumber, int pagesize);

        int TotalPostsForSearch(string search);

        Post GetPost(int year, int month, string urlSlug);

        IList<Category> GetCategories();

        IList<Tag> GetTags();

        IList<Post> GetPosts();
    }
}
