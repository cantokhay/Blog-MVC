using Blog.Models.DTOs.Post;

namespace Blog.Application.Services.Abstract
{
    public interface IPostWriteService
    {
        Task Create(PostCreateDTO model);
        Task Update(PostUpdateDTO model);
        Task Delete(int id);
        Task<PostCreateDTO> CreatePost();
    }
}
