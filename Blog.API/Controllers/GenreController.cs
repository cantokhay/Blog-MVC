using Blog.Application.Services.Abstract.Genre;
using Microsoft.AspNetCore.Mvc;

namespace Blog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IGenreReadService _readService;
        private readonly IGenreWriteService _writeService;

        public GenreController(IGenreReadService readService, IGenreWriteService writeService)
        {
            _readService = readService;
            _writeService = writeService;
        }
    }
}
