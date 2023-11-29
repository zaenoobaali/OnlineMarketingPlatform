using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project2.DTOs;
using Project2.Model.Helpers;
using Project2.Repository.Interfaces;
using System.IdentityModel.Tokens.Jwt;

namespace Project2.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProductController : ControllerBase
    {

        private readonly IHttpContextAccessor _HttpContextAccessor;
        private IProductService _ProductService;
        public ProductController(IProductService ProductService, IHttpContextAccessor httpContextAccessor)
        {
            _ProductService = ProductService;
            _HttpContextAccessor = httpContextAccessor;
        }
        [HttpGet("myproducts")]
        public IActionResult GetAllProducts()
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_HttpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse Response = _ProductService.AllProducts(UserId);
            //if (!string.IsNullOrEmpty(Response.ErrorMessage) ? Response.ErrorMessage != "Success" : false)
            //    return BadRequest(Response);
            return Ok(Response);
        }

        [HttpGet("popularproducts")]
        public IActionResult PopularProducts()
        {
            ApiResponse Response = _ProductService.PopularProduct();
            //if (!string.IsNullOrEmpty(Response.ErrorMessage) ? Response.ErrorMessage != "Success" : false)
            //    return BadRequest(Response);
            return Ok(Response);
        }
    }
}
