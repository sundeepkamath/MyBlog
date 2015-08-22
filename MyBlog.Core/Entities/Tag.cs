using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyBlog.Core.Entities
{
    public class Tag
    {
        public Tag()
        {
            this.Posts = new List<Post>();
        }

        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [MaxLength(50)]
        [Required]
        public string UrlSlug { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }
        public virtual ICollection<Post> Posts{ get; set; }
    }
}
