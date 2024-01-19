using Blog.Application.Services.Abstract.Like;
using Blog.Models.VMs;

namespace Blog.Application.Services.Concrete.Like
{
    public class LikeReadService : ILikeReadService
    {
        public Task<LikeVM> GetLikeById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<LikeVM>> GetLikeList()
        {
            throw new NotImplementedException();
        }
    }
}
