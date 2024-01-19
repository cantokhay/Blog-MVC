﻿using Blog.Domain.Entities;
using Blog.Domain.Repositories.Abstract.BaseRepos;

namespace Blog.Domain.Repositories.Abstract.PostRepos
{
    public interface IPostWriteRepository : IBaseWriteRepository<Post>
    {
    }
}
