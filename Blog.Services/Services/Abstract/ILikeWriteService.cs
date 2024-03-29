﻿using Blog.Models.DTOs.Like;

namespace Blog.Application.Services.Abstract
{
    public interface ILikeWriteService
    {
        Task Create(LikeCreateDTO model);
        Task<LikeCreateDTO> CreateLike();
        Task Update(LikeUpdateDTO model);
        Task Delete(int id);
    }
}
