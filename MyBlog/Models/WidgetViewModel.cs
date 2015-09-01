﻿using MyBlog.Core.Entities;
using MyBlog.Core.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBlog.Models
{
    public class WidgetViewModel
    {
        public WidgetViewModel(IBlogRepository repo)
        {
            Categories = repo.GetCategories();
            Tags = repo.GetTags();
            LatestPosts = repo.GetPosts()
                            .Take(ConfigUtil.ReadFromConfig(Constants.LATEST_POSTS_COUNT))
                            .ToList<Post>();
        }

        public IList<Category> Categories{ get; private set; }
        public IList<Tag> Tags{ get; private set; }

        public IList<Post> LatestPosts { get; set; }
    }
}