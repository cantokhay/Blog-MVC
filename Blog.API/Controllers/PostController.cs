using Blog.Application.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostReadService _readService;
        private readonly IPostWriteService _writeService;

        public PostController(IPostReadService readService, IPostWriteService writeService)
        {
            _readService = readService;
            _writeService = writeService;
        }
    }
}
