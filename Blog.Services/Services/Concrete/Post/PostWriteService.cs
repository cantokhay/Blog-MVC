using Blog.Application.Services.Abstract.Post;
using Blog.Models.DTOs.Post;

namespace Blog.Application.Services.Concrete.Post
{
    public class PostWriteService : IPostWriteService
    {
        public Task Create(PostCreateDTO model)
        {
            throw new NotImplementedException();
        }

        public Task<PostCreateDTO> CreatePost()
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(PostUpdateDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
