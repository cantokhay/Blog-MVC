using Blog.Models.DTOs.Like;
using Blog.Models.VMs;

namespace Blog.Application.Services.Abstract
{
    public interface ILikeReadService
    {
        Task<LikeVM> GetLikeById(int id);
        Task<List<LikeVM>> GetLikeList();
    }
}
