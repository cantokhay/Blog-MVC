using Blog.Application.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentReadService _readRepository;
        private readonly ICommentWriteService _writeRepository;

        public CommentController(ICommentReadService readRepository, ICommentWriteService writeRepository)
        {
            _readRepository = readRepository;
            _writeRepository = writeRepository;
        }
    }
}
