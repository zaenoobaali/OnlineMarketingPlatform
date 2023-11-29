using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using Project2.Data.Enum;
using Newtonsoft.Json;
using Project2.Model;
using Project2.Model.Entities;
using Project2.DTOs;
using Project2.Repository.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using Project2.Model.Helpers;

namespace Project2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        private readonly IHttpContextAccessor _HttpContextAccessor;
        private readonly IMarketerService _MarketerServer;
        private readonly IPostServices _postService;
        private readonly IDeliverService _DeliverService;

        public HomeController(IPostServices postService,  IHttpContextAccessor httpContextAccessor, IMarketerService marketerServer, IDeliverService deliverService)
        {
            _HttpContextAccessor = httpContextAccessor;
            _postService = postService;
            _MarketerServer = marketerServer;
            _DeliverService = deliverService;
        }
        //pop product ..
        //[HttpGet(Name = "GetHomePage")]
        //public IActionResult Index()
        //{

        //    var currentLoginModel = HttpContext.Session.GetString("CurrentLoginModel");
        //    var loginModel = JsonConvert.DeserializeObject<LoginModel>(currentLoginModel);


        //    var claimsPrincipal = (ClaimsPrincipal)User;
            
        //    var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        //    // قم بتحويل معرّف المستخدم إلى int إذا كان من النوع int
        //    var UserId = int.Parse(userId);

        //    var marketers = _context.Popularizations
        //                            .Include(p => p.Marketer)
        //                            .Select(p => p.Marketer)
        //                            .Distinct()
        //                            .ToList();

        //    var followingPages = _context.FollowingPages.Include(fp => fp.Marketer)
        //                                    .Where(fp => fp.userId == UserId)
        //                                    .ToList();

        //    var friends = _context.Friends.Include(f => f.Customer)
        //                                  .Where(f => f.userId == UserId)
        //                                  .ToList();



        //    var posts = new List<Post>();

        //    // استعلم عن منشورات الصفحات المتابعة
        //    foreach (var page in followingPages)
        //    {
        //        var pagePosts = _context.Posts.Include(p => p.Marketer)
        //                                      .Include(p => p.Product)
        //                                      .Where(p => p.marketerId == page.pageId)
        //                                      .ToList();

        //        posts.AddRange(pagePosts);
        //    }

        //    // استعلم عن منشورات الأصدقاء
        //    foreach (var friend in friends)
        //    {
        //        var friendPosts = _context.Posts.Include(p => p.Marketer)
        //                                       .Include(p => p.Product)
        //                                       .Where(p => p.marketerId == friend.friendId)
        //                                       .ToList();

        //        posts.AddRange(friendPosts);
        //    }

        //    var response = new
        //    {
        //        posts = posts,
        //        stores = marketers,
        //       // userType = user_Type
        //    };

        //    return Json(response);


        //}

        [HttpGet("friendsposts")]
        public IActionResult FriendsPosts()
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_HttpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _postService.ViewPostForCustomer(UserId);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        [HttpGet("followpagesposts")]
        public IActionResult PagesPosts()
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_HttpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _postService.ViewPostForMarketer(UserId);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        [HttpGet("allmarketers")]
        public IActionResult AllMarketer()
        {
            ApiResponse response = _MarketerServer.AllMarketers();
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        [HttpGet("alldelivers")]
        public IActionResult AllDelivers()
        {
            ApiResponse response = _DeliverService.AllDeliver();
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        [HttpGet("allposts")]
        public IActionResult allPosts()
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_HttpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _postService.allPosts(UserId);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }
    }
}
