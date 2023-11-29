using Microsoft.AspNetCore.Mvc;
using Project2.DTOs.MarketerDTOs;
using Project2.Model.Entities;
using Project2.Model.Helpers;
using Project2.Repository.Interfaces;
using Project2.Repository.Services;
using System.IdentityModel.Tokens.Jwt;

namespace Project2.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class MarketerController : Controller
    {
        private IMarketerService _marketerService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public MarketerController(IMarketerService marketerService, IHttpContextAccessor httpContextAccessor)
        {
            _marketerService = marketerService;
            _httpContextAccessor = httpContextAccessor;
        }
        [HttpPost("addpoint")]
        public IActionResult AddPoint(AddPointViewModel Points)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
            .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _marketerService.AddPoint(UserId, Points);

            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }
    }
}
