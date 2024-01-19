using Blog.Models.VMs;

namespace Blog.Application.Services.Abstract.Comment
{
    public interface ICommentReadService
    {
        Task<CommentVM> GetCommentById(int id);
        Task<List<CommentVM>> GetCommentList();
    }
}
