using Microsoft.AspNetCore.Mvc;
using Project2.DTOs.ComplaintDTOs;
using Project2.Model.Entities;
using Project2.Model.Helpers;
using Project2.Repository.Interfaces;
using System.IdentityModel.Tokens.Jwt;

namespace Project2.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ComplaintController : Controller
    {
        private readonly IComplaintService _complaintService;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public ComplaintController(IComplaintService complaintService, IHttpContextAccessor httpContextAccessor)
        {
            _complaintService = complaintService;
            _HttpContextAccessor = httpContextAccessor;
        }

        [HttpPost("addcomplaint/{postId}")]
        public IActionResult PostComplaint(int postId,ComplaintViewModel complaintViewModel)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_HttpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _complaintService.AddComplaint(UserId,postId, complaintViewModel);
            if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
                return BadRequest(response);
            return Ok(response);
        }
        [HttpGet("{complaintId}")]
        public IActionResult ViewComplaint(int complaintId)
        {
            ApiResponse response = _complaintService.ViewComplaint(complaintId);
            if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
                return BadRequest(response);
            return Ok(response);
        }
    }
}
