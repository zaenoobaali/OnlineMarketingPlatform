using Microsoft.AspNetCore.Mvc;
using Project2.Model.Helpers;
using Project2.DTOs.AdminDTOs;
using Project2.Repository.Interfaces;
using Project2.DTOs.DeliverDTOs;
using Project2.DTOs.NotifyDTOs;
using System.IdentityModel.Tokens.Jwt;

namespace Project2.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class AdminController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IAdminService _adminService;
        private readonly IUserService _userService;

        public AdminController( IAdminService adminService, IHttpContextAccessor httpContextAccessor , IUserService userService)
        {
            _adminService = adminService;
            _httpContextAccessor = httpContextAccessor;
            _userService = userService;
        }
        [HttpGet("allcustomers")]
        public IActionResult GetUsers()
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _adminService.ViewUsers(UserId);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        [HttpGet("allmarketers")]
        public IActionResult GetMarkter()
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _adminService.ViewMarketers(UserId);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);

        }

        [HttpGet("allcomplaints")]
        public IActionResult GetComplaint()
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _adminService.ViewComplaints(UserId);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);

        }

        [HttpGet("alldelivers")]
        public IActionResult GetDeliver()
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _adminService.ViewDelivers(UserId);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);

        }

        [HttpGet("allroles")]
        public IActionResult GetRoles()
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _adminService.ViewRoles(UserId);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);

        }

        [HttpGet("rolesnames")]
        public IActionResult Roles()
        {
            ApiResponse response = _adminService.RolesNames();
            return Ok(response);
        }

        [HttpGet("allmaintainers")]
        public IActionResult GetMaintainer()
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _adminService.ViewMaintainers(UserId);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);

        }
        [HttpGet("allpopularizations")]
        public IActionResult GetPopular()
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _adminService.ViewPopularization(UserId);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);

        }
        [HttpGet("alltenders")]
        public IActionResult GetTender()
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _adminService.ViewTender(UserId);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);

        }
        [HttpGet("allauctions")]
        public IActionResult GetAuction()
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _adminService.ViewAuction(UserId);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);

        }

        [HttpGet("allpointsrequests")]
        public IActionResult GetPOints()
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _adminService.PointRequest(UserId);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);

        }

        [HttpPost("addrole")]
        public IActionResult PostRole(RoleViewModel roleViewModel)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _adminService.AddRole(UserId, roleViewModel);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }


        [HttpPost("addmaintaner")]
        public async Task<IActionResult> PostMaintaner(MaintainerViewModel maintainerView)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response =await _adminService.AddMaintainer(UserId, maintainerView);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

       
        [HttpPost("adddeliver")]
        public async Task<IActionResult> PostDeliver(AddDeliverViewModel NewDeliver)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response =await _userService.RegisterForDeliver(UserId , NewDeliver);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);

        }

        [HttpPost("blockuser/{id}")]
        public IActionResult BlockUser(int id)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _adminService.BlockUser(UserId, id);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }
        [HttpPost("unblockuser/{id}")]
        public IActionResult UnBlockUser(int id)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _adminService.unBlockUser(UserId, id);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        [HttpPost("acceptpopularization/{id}")]
        public IActionResult AcceptPopularization(int id)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _adminService.AcceptPopularization(UserId, id);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        [HttpPost("unacceptpopularization/{id}")]
        public IActionResult UnAcceptPopularization(int id)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _adminService.UnAcceptPopularization(UserId, id);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }
        [HttpPost("acceptpointrequest/{marketerId}")]
        public IActionResult AcceptPointRequest(int marketerId)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);
           
            ApiResponse response = _adminService.AcceptPointRequest(UserId, marketerId);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        [HttpPost("unacceptpointrequest/{marketerId}")]
        public IActionResult UnAcceptPointRequest(int marketerId)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _adminService.UnAcceptPointRequest(UserId, marketerId);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        [HttpPost("cancelauction/{id}")]
        public IActionResult CancelAuction(int id)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _adminService.CancelAuction(UserId, id);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        [HttpPost("canceltender/{id}")]
        public IActionResult CancelTender(int id)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _adminService.CancelTender(UserId, id);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        [HttpPost("replaycomplaint/{id}")]
        public IActionResult ReplayComplaint(int id ,AddNotificationViewModel addNotificationView)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _adminService.ReplayComplaint(UserId, id, addNotificationView);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }
        [HttpDelete("deletemaintaner/{id}")]
        public IActionResult DeleteMaintaner(int id)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _adminService.DeleteMaintainer(UserId, id);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        [HttpDelete("deletecomplaint/{id}")]
        public IActionResult DeleteComplaint(int id)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _adminService.DeleteComplaint(UserId, id);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }


        [HttpDelete("deleterole/{id}")]
        public IActionResult DeleteRole(int id)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _adminService.DeleteRole(UserId, id);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

    }
}
