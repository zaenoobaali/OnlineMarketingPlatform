using Microsoft.AspNetCore.Mvc;
using Project2.DTOs.OrderDTOs;
using Project2.DTOs.ProductDTOs;
using Project2.Model.Helpers;
using Project2.Repository.Interfaces;
using System.IdentityModel.Tokens.Jwt;

namespace Project2.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class OrderController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IOrderService _orderService;

        public OrderController(IHttpContextAccessor httpContextAccessor, IOrderService orderService)
        {
           
            _httpContextAccessor = httpContextAccessor;
            _orderService = orderService;
        }

        [HttpGet("marketersales")]
        public IActionResult GetOrders()
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _orderService.ViewMarketerSales(UserId);

            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        [HttpGet("customerorders")]
        public IActionResult GetCustomerOrders()
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _orderService.ViewCustomerOrder(UserId);

            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        //[HttpDelete("customerorders/{Id}")]
        //public IActionResult deleteCustOrder(int Id)
        //{
        //    JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

        //    int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
        //        .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

        //    ApiResponse response = _orderService.RemoveCustomerOrder(UserId, Id);

        //    if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Seccess" : false)
        //        return BadRequest(response);
        //    return Ok(response);
        //}

        [HttpGet("deliveryorders")]
        public IActionResult GetDeliveryOrders()
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _orderService.ViewDeliverOrder(UserId);

            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }
        //[HttpDelete("marketersales/{Id}")]
        //public IActionResult deleteOrder(int Id)
        //{
        //    JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

        //    int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
        //        .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

        //    ApiResponse response = _orderService.RemoveMarketerSales(UserId,Id);

        //    if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Seccess" : false)
        //        return BadRequest(response);
        //    return Ok(response);
        //}

        [HttpGet("yourbag/{marketerId}")]
        public IActionResult GetBag(int marketerId)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _orderService.ViewBag(UserId,marketerId);

            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        [HttpGet("updatedetails/{productorderId}")]
        public IActionResult Updatrd(int productorderId)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _orderService.UpdateDetails(UserId, productorderId);

            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        [HttpPost("addordertobag/{postId}")]
        public IActionResult AddOrderToBag(int postId, ProductOrderViewModel productOrder)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _orderService.AddOrderToBag(UserId, postId , productOrder);

            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        [HttpPost("addorder/{marketerId}")]
        public async Task<IActionResult> AddOrder(int marketerId)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = await _orderService.AddOrder(UserId , marketerId);

            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        [HttpPost("sendorder/{orderId}")]
        public IActionResult SendOrder(int orderId , AddOrderVM orderViewModel)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _orderService.SendOrder(UserId, orderId, orderViewModel);

            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        [HttpPost("sendorderbycustomer/{orderId}/{customerId}")]
        public IActionResult SendOrder(int orderId,int customerId, AddOrderVM orderViewModel)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _orderService.SendOrder(customerId, UserId, orderId, orderViewModel);

            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        [HttpPost("accepteorder/{orderId}")]
        public IActionResult AccepteOrder(int orderId)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _orderService.AccepteOrder(UserId, orderId);

            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        [HttpPost("unaccepteorder/{orderId}")]
        public IActionResult UnAccepteOrder(int orderId)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _orderService.UnAccepteOrder(UserId, orderId);

            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        [HttpPost("accpetdeliverorder/{orderId}")]
        public IActionResult AccepetDeliverOrder(int orderId)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _orderService.AccepetDeliverOrder(UserId, orderId);

            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        [HttpPost("deliverdtodelivery/{orderId}")]
        public IActionResult DeliveredToDelivery(int orderId)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _orderService.DeliveredToDelivery(UserId, orderId);

            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        [HttpPost("receivedfrommarketer/{orderId}")]
        public IActionResult ReceivedFromMarketer(int orderId)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _orderService.ReceivedFromMarketer(UserId, orderId);

            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        [HttpPost("delivered/{orderId}")]
        public IActionResult Delivered(int orderId)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _orderService.Delivered(UserId, orderId);

            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        [HttpPost("received/{orderId}")]
        public IActionResult Received(int orderId)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _orderService.Received(UserId, orderId);

            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        [HttpPost("updateorder/{productorderId}")]
        public IActionResult UpdateOrder(int productorderId, ProductOrderViewModel productOrder)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _orderService.UpdateOrder(UserId, productorderId,productOrder);

            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

        [HttpDelete("deletorder/{productorderId}")]
        public IActionResult DeleteOrder(int productorderId)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
                .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

            ApiResponse response = _orderService.DeleteOrder(UserId, productorderId);

            //if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Success" : false)
            //    return BadRequest(response);
            return Ok(response);
        }

      

        //[HttpDelete("deliveryorders/{Id}")]
        //public IActionResult deletedelivOrder(int Id)
        //{
        //    JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

        //    int UserId = Convert.ToInt32(jwtHandler.ReadJwtToken(_httpContextAccessor.HttpContext
        //        .Request.Headers["Authorization"].ToString().Split(" ")[1]).Claims.ToList()[0].Value);

        //    ApiResponse response = _orderService.RemoveDeliverOrder(UserId, Id);

        //    if (!string.IsNullOrEmpty(response.ErrorMessage) ? response.ErrorMessage != "Seccess" : false)
        //        return BadRequest(response);
        //    return Ok(response);
        //}

    }

}
