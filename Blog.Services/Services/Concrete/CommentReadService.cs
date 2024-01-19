using AutoMapper;
using Blog.Application.Services.Abstract;
using Blog.Domain.Entities;
using Blog.Domain.Repositories.Abstract.AppUserRepos;
using Blog.Domain.Repositories.Abstract.CommentRepos;
using Blog.Domain.Repositories.Abstract.PostRepos;
using Blog.Models.VMs;
using Microsoft.EntityFrameworkCore;

namespace Blog.Application.Services.Concrete
{
    public class CommentReadService : ICommentReadService
    {
        private readonly ICommentReadRepository _commentReadRepository;
        private readonly IAppUserReadRepository _appUserReadRepository;
        private readonly IMapper _mapper;

        public CommentReadService(ICommentReadRepository commentReadRepository, IAppUserReadRepository appUserReadRepository, IMapper mapper)
        {
            _commentReadRepository = commentReadRepository;
            _appUserReadRepository = appUserReadRepository;
            _mapper = mapper;
        }

        public async Task<CommentVM> GetCommentById(int id)
        {
            Comment comment = await _commentReadRepository.GetFirstOrDefault(x => x.ID == id);
            CommentVM model = _mapper.Map<CommentVM>(comment);
            model.Users = await _appUserReadRepository.GetFilteredList(
                                                    select: x => new AppUserVM
                                                    {
                                                        Id = x.Id,
                                                        UserName = x.UserName,
                                                    },
                                                    where: x => x.Status != Domain.Enums.Status.Deleted,
                                                    orderBy: x => x.OrderBy(x => x.Likes.Count()));

            return model;
        }

        public async Task<List<CommentVM>> GetCommentList()
        {
            List<CommentVM> commentList = await _commentReadRepository.GetFilteredList(
                                                select: x => new CommentVM
                                                {
                                                    ID = x.ID,
                                                    Content = x.Content,
                                                    Title = x.Title
                                                },
                                                where: x => x.Status != Domain.Enums.Status.Deleted,
                                                orderBy: x => x.OrderBy(x => x.CreateDate),
                                                include:  x => x.Include(x => x.AppUser).Include(x => x.Post));
            return commentList;
        }
    }
}
