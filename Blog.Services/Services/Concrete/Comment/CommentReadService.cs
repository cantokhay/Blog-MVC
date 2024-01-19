using Blog.Application.Services.Abstract.Comment;
using Blog.Models.VMs;

namespace Blog.Application.Services.Concrete.Comment
{
    public class CommentReadService : ICommentReadService
    {
        public Task<CommentVM> GetCommentById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CommentVM>> GetCommentList()
        {
            throw new NotImplementedException();
        }
    }
}
