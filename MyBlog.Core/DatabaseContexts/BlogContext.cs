using MyBlog.Core.Entities;
using System.Data.Entity;

namespace MyBlog.Core.DatabaseContexts
{
    public class BlogContext : DbContext
    {
        public BlogContext() : base("name=DefaultConnection")
        {

        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Category> Categories{ get; set; }
    }
}
