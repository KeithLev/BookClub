using Microsoft.AspNetCore.Mvc;

namespace BookClubAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        [HttpGet]
        public string hello()
        {
            return "Hello";
        }

    }
}
