using AutoMapper;
using Blog.Application.Services.Abstract;
using Blog.Domain.Repositories.Abstract.AppUserRepos;
using Blog.Domain.Repositories.Abstract.CommentRepos;
using Blog.Domain.Repositories.Abstract.PostRepos;
using Blog.Models.VMs;

namespace Blog.Application.Services.Concrete
{
    public class CommentReadService : ICommentReadService
    {
        private readonly ICommentReadRepository _commentReadRepository;
        private readonly IPostReadRepository _postReadRepository;
        private readonly IAppUserReadRepository _appUserReadRepository;
        private readonly IMapper _mapper;

        public CommentReadService(ICommentReadRepository commentReadRepository, IPostReadRepository postReadRepository, IAppUserReadRepository appUserReadRepository, IMapper mapper)
        {
            _commentReadRepository = commentReadRepository;
            _postReadRepository = postReadRepository;
            _appUserReadRepository = appUserReadRepository;
            _mapper = mapper;
        }

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
