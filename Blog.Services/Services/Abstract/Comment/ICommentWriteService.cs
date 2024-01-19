using Blog.Models.DTOs.Comment;

namespace Blog.Application.Services.Abstract.Comment
{
    public interface ICommentWriteService
    {
        Task Create(CommentCreateDTO model);
        Task<CommentCreateDTO> CreateComment();
        Task Update(CommentUpdateDTO model);
        Task Delete(int id);
    }
}
