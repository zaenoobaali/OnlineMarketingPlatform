using Microsoft.AspNetCore.Mvc;
using Project2.Model.Helpers;
using Project2.Repository.Interfaces;
using Project2.Repository.Services;
using System.IdentityModel.Tokens.Jwt;

namespace Project2.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class DeliverController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IDeliverService _deliverService;
        public DeliverController(IDeliverService deliverService, IHttpContextAccessor httpContextAccessor)
        {
            _deliverService = deliverService;
            _httpContextAccessor = httpContextAccessor;
        }
        [HttpGet("deliversnames")]
        public IActionResult GetAllCustomers()
        {
            ApiResponse Response = _deliverService.ShowDeliverName();
            return Ok(Response);
        }

        [HttpPost("accepttobecontract/{marketerId}")]
        public IActionResult acceptTobeContract(int marketerId)
        {

            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse Response = _deliverService.AcceptToContract(UserId,marketerId);
            return Ok(Response);
        }


        [HttpPost("unaccepttobecontract/{marketerId}")]
        public IActionResult UnacceptTobeContract(int marketerId)
        {

            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse Response = _deliverService.UnAcceptToContract(UserId, marketerId);
            return Ok(Response);
        }
    }
}
