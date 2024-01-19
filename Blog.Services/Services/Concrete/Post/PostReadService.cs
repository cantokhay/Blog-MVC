using Blog.Application.Services.Abstract.Post;
using Blog.Models.VMs;

namespace Blog.Application.Services.Concrete.Post
{
    public class PostReadService : IPostReadService
    {
        public Task<PostVM> GetPostById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PostVM> GetPostDetails(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PostVM>> GetPostList()
        {
            throw new NotImplementedException();
        }
    }
}
