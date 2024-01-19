using Blog.Application.Services.Abstract.Comment;
using Blog.Models.DTOs.Comment;

namespace Blog.Application.Services.Concrete.Comment
{
    public class CommentWriteService : ICommentWriteService
    {
        public Task Create(CommentCreateDTO model)
        {
            throw new NotImplementedException();
        }

        public Task<CommentCreateDTO> CreateComment()
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(CommentUpdateDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
