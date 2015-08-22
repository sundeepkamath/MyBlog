﻿using MyBlog.Core.Entities;
using System.Collections.Generic;
using System.Linq;

namespace MyBlog.Core.RepositoryInterfaces
{
    public interface IBlogRepository
    {
        IList<Post> GetPosts(int pageNumber, int pageSize);

        int TotalPosts();
    }
}
