using Blog.Models.VMs;

namespace Blog.Application.Services.Abstract
{
    public interface IPostReadService
    {
        Task<PostVM> GetPostById(int id);
        Task<List<PostVM>> GetPostList();
        Task<PostVM> GetPostDetails(int id);
    }
}
