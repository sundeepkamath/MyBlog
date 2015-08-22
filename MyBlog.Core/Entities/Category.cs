using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyBlog.Core.Entities
{
    public class Category
    {
        public Category()
        {
            this.Posts = new List<Post>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string UrlSlug { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
