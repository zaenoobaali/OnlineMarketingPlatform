using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project2.DTOs.PopularizationDTOs;
using Project2.Model;
using Project2.Model.Entities;
using Project2.Model.Helpers;
using Project2.Repository.Interfaces;

namespace Project2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PopularizationController : Controller
    {
        private readonly IHttpContextAccessor _HttpContextAccessor;
        private readonly IPopularizationService _popularization; 

        public PopularizationController(IPopularizationService popularization, IHttpContextAccessor httpContextAccessor)
        {
            _popularization = popularization;
            _HttpContextAccessor = httpContextAccessor;
        }

        [HttpGet("showpopulaization")]
        public IActionResult ViewPopulaization()
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_HttpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _popularization.GetPopularization(UserId);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        [HttpPost("addpopulaization")]
        public  IActionResult CreatePopulaization(AddPopularizationViewModel addPopularization)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_HttpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _popularization.CreatePopularization(UserId, addPopularization);
            ////if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            ////    return BadRequest(response);
            return Ok(response);
        }

        [HttpGet("details/{id}")]
        public IActionResult Details(int id)
        {
            ApiResponse response = _popularization.PopularizationDetails(id);
            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        

    }
}
