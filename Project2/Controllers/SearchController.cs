using Microsoft.AspNetCore.Mvc;
using Project2.Model.Helpers;
using Project2.DTOs.NotifyDTOs;
using Project2.Model;
using Project2.Repository.Interfaces;
using Project2.Repository.Services;
using System.IdentityModel.Tokens.Jwt;

namespace Project2.Controllers
{
    [ApiController]
    [Route("api/[controller]/")]
    public class SearchController : Controller
    {
        private readonly AppDbContext _dbContext;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ISearchService _searchService;

        public SearchController(AppDbContext dbContext, IHttpContextAccessor httpContextAccessor = null, ISearchService searchService = null)
        {
            _dbContext = dbContext;
            _httpContextAccessor = httpContextAccessor;
            _searchService = searchService;
        }

        [HttpGet("searchlist")]
        public IActionResult GetSearch()
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _searchService.ViewSearchList(UserId);

            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        [HttpPost("search")]
        public IActionResult PostSearch(AddSearchViewModel search)
        {
           
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _searchService.AddSearch(UserId, search);

            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
            
        }

        [HttpDelete("search/{id}")]
        public IActionResult DeleteSearch(int id)
        {
            
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _searchService.DeleteSearch(UserId, id);

            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
           
        }

    }
}
