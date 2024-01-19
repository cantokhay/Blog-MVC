using AutoMapper;
using Blog.Application.Services.Abstract;
using Blog.Domain.Repositories.Abstract.GenreRepos;
using Blog.Models.DTOs.Genre;

namespace Blog.Application.Services.Concrete
{
    public class GenreWriteService : IGenreWriteService
    {
        private readonly IGenreReadRepository _readRepo;
        private readonly IGenreWriteRepository _writeRepo;
        private readonly IMapper _mapper;

        public GenreWriteService(IGenreReadRepository readRepo, IGenreWriteRepository writeRepo, IMapper mapper)
        {
            _readRepo = readRepo;
            _writeRepo = writeRepo;
            _mapper = mapper;
        }

        public Task Create(GenreCreateDTO model)
        {
            throw new NotImplementedException();
        }

        public Task<GenreCreateDTO> CreateGenre()
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(GenreUpdateDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
