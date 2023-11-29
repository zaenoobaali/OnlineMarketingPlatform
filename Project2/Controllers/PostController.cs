using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using Project2.Model.Helpers;
using Project2.Repository.Interfaces;
using Project2.DTOs.PostDTOs;

namespace Project2.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class PostController : Controller
    {
        private readonly IPostService _PostService;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        private readonly IPostServices _PostServices;
        public PostController(IPostService PostService, IHttpContextAccessor httpContextAccessor, IPostServices postServices)
        {
            _PostService = PostService;
            _HttpContextAccessor = httpContextAccessor;
            _PostServices = postServices;
        }
        //[HttpPost("GetAllPosts")]
        //public IActionResult GetAllPosts(ComplexFilter Filter)
        //{
        //    ApiResponse Response = _PostService.GetAllPosts(Filter);
        //    return Ok(Response);
        //}

        //[HttpPost("GetAllFriendsPosts")]
        //public IActionResult GetAllFriendsPosts(ComplexFilter Filter)
        //{
        //    JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

        //    int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_HttpContextAccessor.HttpContext
        //        .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

        //    ApiResponse Response = _PostService.GetAllFriendsPosts(UserId, Filter);
        //    return Ok(Response);
        //}

        //[HttpPost("GetAllFollowingPagesPosts")]
        //public IActionResult GetAllFollowingPagesPosts(ComplexFilter Filter)
        //{
        //    JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

        //    int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_HttpContextAccessor.HttpContext
        //        .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

        //    ApiResponse Response = _PostService.GetAllFollowingPagesPosts(UserId, Filter);
        //    return Ok(Response);
        //}

        //[HttpPost("GetFriendPostByFriendId")]
        //public IActionResult GetFiendPostByFriendId(int FriendId, ComplexFilter Filter)
        //{
        //    ApiResponse Response = _PostService.GetFriendPostByFriendId(FriendId, Filter);
        //    return Ok(Response);
        //}

        [HttpPost("addpost")]
        public async Task<IActionResult> AddPost(AddPostViewModel postViewModel)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_HttpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = await _PostServices.AddPost(UserId, postViewModel);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        [HttpGet("details/{id}")]
        public IActionResult PostDetails(int id)
        {
            ApiResponse response = _PostServices.ShowPostDetails(id);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeletePost(int id)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_HttpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _PostServices.DeletePost(UserId, id);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        [HttpPost("update/{id}")]
        public IActionResult UpdatePost(int id , UpdatePostViewModel postViewModel)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_HttpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _PostServices.UpdatePost(UserId, id,postViewModel);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        [HttpPost("interaction/{postId}")]
        public IActionResult AddInteraction(int postId)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_HttpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response =  _PostServices.InteractionOnPost(UserId, postId );
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        [HttpDelete("interaction/{postId}")]
        public IActionResult RemoveInteraction(int postId)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_HttpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _PostServices.RemoveInteraction(UserId, postId );
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        //[HttpGet("friendsposts")]
        //public IActionResult FriendsPost()
        //{
        //    JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

        //    int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_HttpContextAccessor.HttpContext
        //        .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

        //    ApiResponse response = _PostServices.ViewPostForCustomer(UserId);
        //    if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Seccess" : false)
        //        return BadRequest(response);
        //    return Ok(response);
        //}

        //[HttpGet("followingpagesposts")]
        //public IActionResult PagesPost()
        //{
        //    JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

        //    int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_HttpContextAccessor.HttpContext
        //        .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

        //    ApiResponse response = _PostServices.ViewPostForMarketer(UserId);
        //    if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Seccess" : false)
        //        return BadRequest(response);
        //    return Ok(response);
        //}
        //[HttpGet("marketerpost")]
        //public IActionResult GetSellerPosts()
        //{
        //    try
        //    {
        //        JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

        //        int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
        //            .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

        //        ApiResponse response = _PostServices.ViewPostForMarketer(UserId);

        //        if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Seccess" : false)
        //            return BadRequest(response);

        //        return Ok(response);
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, ex +"حدث خطأ أثناء جلب المنشورات للبائع.");
        //    }
        //}

        //[HttpGet("customerpost")]
        //public IActionResult GetcustomerPosts()
        //{
        //    try
        //    {
        //        JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

        //        int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
        //            .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

        //        ApiResponse response = _PostServices.ViewPostForCustomer(UserId);

        //        if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Seccess" : false)
        //            return BadRequest(response);
        //        return Ok(response);
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, ex + "حدث خطأ أثناء جلب المنشورات للبائع.");
        //    }
        //}

        //[HttpPost("interaction")]
        //public IActionResult AddInteraction(int postId, string reactionType)
        //{
        //    // الحصول على معرّف المستخدم الحالي
        //    var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        //    // قم بتحويل معرّف المستخدم إلى int إذا كان من النوع int
        //    int.TryParse(userId, out int parsedUserId);

        //    // إنشاء كائن Interaction وتعيين القيم
        //    var interaction = new Interaction
        //    {
        //        PostId = postId,
        //        UserId = parsedUserId,
        //        ReactionType = reactionType,
        //        CreatedDate = DateTime.Now
        //    };

        //    // قم بإضافة التفاعل إلى قاعدة البيانات (أو قم بتنفيذ الإجراء المناسب)
        //    _dbContext.Interactions.Add(interaction);
        //    _dbContext.SaveChanges();

        //    // العودة برمز استجابة HTTP 200 للدلالة على نجاح العملية
        //    return Ok();
        //}



    }
}
