using MyBlog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
