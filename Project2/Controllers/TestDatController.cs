using Microsoft.AspNetCore.Mvc;
using Project2.Model.Helpers;
using Project2.Repository.Interfaces;
using Project2.Repository.Services;

namespace Project2.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class TestDatController : Controller
    {
        private readonly IPostService _postService;
        public TestDatController (IPostService postService) {
         _postService = postService;
        }

        [HttpGet("allpost")]
        public IActionResult Index()
        {
            ApiResponse Response = _postService.GetAllPosts();
            return Ok(Response);
        }
    }
}
