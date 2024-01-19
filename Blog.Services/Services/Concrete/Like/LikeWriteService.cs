using Blog.Application.Services.Abstract.Like;
using Blog.Models.DTOs.Like;

namespace Blog.Application.Services.Concrete.Like
{
    public class LikeWriteService : ILikeWriteService
    {
        public Task Create(LikeCreateDTO model)
        {
            throw new NotImplementedException();
        }

        public Task<LikeCreateDTO> CreateLike()
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(LikeUpdateDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
