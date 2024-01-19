using Blog.Application.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LikeController : ControllerBase
    {
        private readonly ILikeReadService _readService;
        private readonly ILikeWriteService _writeService;

        public LikeController(ILikeReadService readService, ILikeWriteService writeService)
        {
            _readService = readService;
            _writeService = writeService;
        }
    }
}
