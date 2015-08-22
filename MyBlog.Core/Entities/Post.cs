﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Core.Entities
{
    public class Post   
    {
        public Post()
        {
            this.Tags = new List<Tag>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Meta { get; set; }
        public string UrlSlug { get; set; }
        public bool Published { get; set; }
        public DateTime PostedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public Category Category{ get; set; }
        public virtual ICollection<Tag> Tags { get; set; }

    }
}
