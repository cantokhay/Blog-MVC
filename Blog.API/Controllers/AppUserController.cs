using Blog.Application.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly IAppUserReadService _readService;
        private readonly IAppUserWriteService _writeService;

        public AppUserController(IAppUserReadService readService, IAppUserWriteService writeService)
        {
            _readService = readService;
            _writeService = writeService;
        }
    }
}
