using Microsoft.AspNetCore.Mvc;
using Project2.Repository.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using Project2.Model.Helpers;
using Project2.DTOs.CustomerDTOs;
using Project2.DTOs.MarketerDTOs;
using Project2.DTOs.DeliverDTOs;
using Project2.DTOs.UserDTOs;

namespace Project2.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProfileController : Controller
    {
        private readonly ILogger<ProfileController> _logger;
        private readonly IProfileService _profileService;
        private readonly IHttpContextAccessor _httpContextAccessor;


        public ProfileController(ILogger<ProfileController> logger,IHttpContextAccessor httpContextAccessor, IProfileService profileService)
        {
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
            _profileService = profileService;
        }

        [HttpGet("customerprofile/{id}")]
        public IActionResult CustomerProfile(int id)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _profileService.ViewCustomerProfileById(UserId, id);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        // عرض بروفايل التاجر 
        [HttpGet("marketerprofile/{id}")]
        public IActionResult MarketerProfile(int id)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _profileService.ViewMarketerProfileById(UserId, id);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        //صفحة شركة التوصيل
        [HttpGet("deliverprofile/{id}")]
        public IActionResult DeliverProfile(int id)
        {
            ApiResponse response = _profileService.ViewDeliverProfile(id);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        

        // تعديل معلومات الزبون
        [HttpPost("editcustomerprofile/{id}")]
        public IActionResult EditCustomerProfile(int id ,UpdateCustomerViewModel Updatecustomer)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _profileService.UpdateCustomerProfile(UserId, id, Updatecustomer);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
         
        }

        //تعديل معلومات التاجر
        [HttpPost("editmarketerprofile/{id}")]
        public IActionResult EditMarketerProfile(int id, UpdateMarketerViewModel updatedMarketer)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _profileService.UpdateMarketerProfile(UserId, id, updatedMarketer);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
     
        }

        //تعديل معلومات التوصيل
        [HttpPost("editdeliverprofile/{id}")]
        public IActionResult EditDriverProfile(int id, UpdateDeliverViewModel updatedDeliver)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _profileService.UpdateDeliverProfile(UserId, id, updatedDeliver);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
            
        }

        [HttpPost("edituserinformation/{id}")]
        public IActionResult EditUserInfo(int id, EditUserViewModel editUser)
        {
            ApiResponse response = _profileService.EditUserInfo(id, editUser);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        [HttpPost("changepassword/{id}")]
        public IActionResult ChangePassword(int id, UserPasswordViewModel userPassword)
        {
            ApiResponse response = _profileService.ChangePass(id, userPassword);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }
        // متابعة التاجر
        [HttpPost("followmarketer/{id}")]
        public IActionResult FollowMarketer(int id)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _profileService.FollowMarketer(UserId, id);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);

        }

        // إلغاء متابعة التاجر
        [HttpPost("unfollowmarketer/{id}")]
        public IActionResult UnfollowMarketer(int id)
         {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _profileService.UnfollowMarketer(UserId, id);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        // متابعة زبون آخر
        [HttpPost("followcustomer/{id}")]
        public IActionResult FollowCustomer(int id)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _profileService.FollowCustomer(UserId, id);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        //إلغاء متابعة زبون
        [HttpPost("unfollowcustomer/{id}")]
        public IActionResult UnfollowCustomer(int id)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _profileService.UnfollowCustomer(UserId, id);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        // عرض الصفحات المتابعة للمستخدم
        [HttpGet("followingpages")]
        public IActionResult FollowingPages()
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _profileService.ViewFollowingPagesList(UserId);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }
        
        //عرص الاصدقاء
        [HttpGet("friendslist")]
        public IActionResult FriendsList()
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _profileService.ViewFriendsList(UserId);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }
        //التعاقد مع شركة توصيل
        [HttpPost("contactdeliver/{id}")]
        public IActionResult ContractWithDeliver(int id)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _profileService.ContractWithDeliver(UserId, id);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }
        [HttpPost("cancelcontactdeliver/{id}")]
        public IActionResult CancelContractWithDeliver(int id)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _profileService.CancelContractWithDeliver(UserId, id);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        //
        [HttpPost("addcustomeragent/{id}")]
        public IActionResult AddAgent(int id)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _profileService.AddAgent(UserId, id);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        //
        [HttpPost("removecustomeragent/{id}")]
        public IActionResult RemoveAgent(int id)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _profileService.RemoveAgent(UserId, id);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        [HttpGet("myallagents")]
        public IActionResult CustomerAgent()
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _profileService.ViewCustomerAgent(UserId);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        [HttpGet("contracteddelivery")]
        public IActionResult ContactDeliver()
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _profileService.ViewContactedDeliver(UserId);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }
    }
}
