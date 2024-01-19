using AutoMapper;
using Blog.Application.Services.Abstract;
using Blog.Domain.Repositories.Abstract.AppUserRepos;
using Blog.Domain.Repositories.Abstract.CommentRepos;
using Blog.Domain.Repositories.Abstract.PostRepos;
using Blog.Models.DTOs.Comment;

namespace Blog.Application.Services.Concrete
{
    public class CommentWriteService : ICommentWriteService
    {
        private readonly ICommentReadRepository _commentReadRepository;
        private readonly ICommentWriteRepository _commentWriteRepository;
        private readonly IPostReadRepository _postReadRepository;
        private readonly IAppUserReadRepository _appUserReadRepository;
        private readonly IMapper _mapper;

        public CommentWriteService(ICommentReadRepository commentReadRepository, ICommentWriteRepository commentWriteRepository, IPostReadRepository postReadRepository, IAppUserReadRepository appUserReadRepository, IMapper mapper)
        {
            _commentReadRepository = commentReadRepository;
            _commentWriteRepository = commentWriteRepository;
            _postReadRepository = postReadRepository;
            _appUserReadRepository = appUserReadRepository;
            _mapper = mapper;
        }

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
