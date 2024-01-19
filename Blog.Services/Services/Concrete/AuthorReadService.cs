using AutoMapper;
using Blog.Application.Services.Abstract;
using Blog.Domain.Entities;
using Blog.Domain.Repositories.Abstract.AuthorRepos;
using Blog.Models.VMs;

namespace Blog.Application.Services.Concrete
{
    public class AuthorReadService : IAuthorReadService
    {
        private readonly IAuthorReadRepository _readRepo;
        private readonly IMapper _mapper;

        public AuthorReadService(IAuthorReadRepository readRepo, IMapper mapper)
        {
            _readRepo = readRepo;
            _mapper = mapper;
        }

        public async Task<AuthorVM> GetAuthorById(int id)
        {
            Author author = await _readRepo.GetFirstOrDefault(x => x.ID == id);
            return _mapper.Map<AuthorVM>(author);
        }

        public async Task<List<AuthorVM>> GetAuthorList()
        {
            List<AuthorVM> authorList = await _readRepo.GetFilteredList(
                                            select: x => new AuthorVM()
                                            {
                                                ID = x.ID,
                                                FirstName = x.FirstName,
                                                LastName = x.LastName
                                            },
                                            where: x => x.Status != Domain.Enums.Status.Deleted,
                                            orderBy: x => x.OrderBy(x => x.FirstName).ThenBy(x => x.CreateDate));
            return authorList;
        }
    }
}
