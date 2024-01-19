using AutoMapper;
using Blog.Application.Services.Abstract;
using Blog.Domain.Repositories.Abstract.GenreRepos;
using Blog.Models.VMs;

namespace Blog.Application.Services.Concrete
{
    public class GenreReadService : IGenreReadService
    {
        private readonly IGenreReadRepository _readRepo;
        private readonly IMapper _mapper;

        public GenreReadService(IGenreReadRepository readRepo, IMapper mapper)
        {
            _readRepo = readRepo;
            _mapper = mapper;
        }

        public Task<GenreVM> GetGenreById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<GenreVM>> GetGenreList()
        {
            throw new NotImplementedException();
        }
    }
}
