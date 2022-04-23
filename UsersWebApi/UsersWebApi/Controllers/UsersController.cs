using Microsoft.AspNetCore.Mvc;

namespace UsersWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;

        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
            return await Task.FromResult(Ok("Hello World"));
        }
    }
}