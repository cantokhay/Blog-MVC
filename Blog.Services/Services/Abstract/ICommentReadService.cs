using Blog.Models.VMs;

namespace Blog.Application.Services.Abstract
{
    public interface ICommentReadService
    {
        Task<CommentVM> GetCommentById(int id);
        Task<List<CommentVM>> GetCommentList();
    }
}
