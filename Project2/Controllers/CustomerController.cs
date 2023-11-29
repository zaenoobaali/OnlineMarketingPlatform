using Microsoft.AspNetCore.Mvc;
using Project2.Model.Helpers;
using Project2.Repository.Interfaces;
using System.IdentityModel.Tokens.Jwt;

namespace Project2.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ICustomerService _customerService;
        public CustomerController(ICustomerService customerService, IHttpContextAccessor httpContextAccessor)
        {
            _customerService = customerService;
            _httpContextAccessor = httpContextAccessor;
        }
        [HttpGet("allcustomers")]
        public IActionResult GetAllCustomers()
        {
           ApiResponse Response = _customerService.ViewAllCustomers();
            return Ok(Response);
        }

        [HttpGet("myfollowers")]
        public IActionResult GetMyFollowers()
        {

            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse Response = _customerService.CustomersFollowMarketers(UserId);
            return Ok(Response);
        }


        [HttpPost("accepttobeagent/{marketerId}")]
        public IActionResult AcceptTobeAgent(int marketerId)
        {

            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse Response = _customerService.AcceptToBeAgent(UserId , marketerId);
            return Ok(Response);
        }

        [HttpPost("unaccepttobeagent/{marketerId}")]
        public IActionResult UnAcceptTobeAgent(int marketerId)
        {

            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse Response = _customerService.UnAcceptToBeAgent(UserId, marketerId);
            return Ok(Response);
        }
    }
}
