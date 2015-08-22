using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyBlog.Core.Entities
{
    public class Post   
    {
        public Post()
        {
            this.Tags = new List<Tag>();
        }

        public int Id { get; set; }

        [MaxLength(500)]
        [Required]
        public string Title { get; set; }

        [MaxLength(5000)]
        [Required]
        public string ShortDescription { get; set; }

        [MaxLength(5000)]
        [Required]
        public string Description { get; set; }

        [MaxLength(1000)]
        [Required]
        public string Meta { get; set; }

        [MaxLength(200)]
        [Required]
        public string UrlSlug { get; set; }

        [Required]
        public bool Published { get; set; }

        [Required]
        public DateTime PostedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public virtual Category Category{ get; set; }

        public virtual ICollection<Tag> Tags { get; set; }

    }
}
