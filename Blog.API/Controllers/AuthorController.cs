using Blog.Application.Services.Abstract.Author;
using Microsoft.AspNetCore.Mvc;

namespace Blog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorReadService _readService;
        private readonly IAuthorWriteService _writeService;

        public AuthorController(IAuthorReadService readService, IAuthorWriteService writeService)
        {
            _readService = readService;
            _writeService = writeService;
        }
    }
}
