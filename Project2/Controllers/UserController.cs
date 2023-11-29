using Microsoft.AspNetCore.Mvc;
using Project2.DTOs;
using Project2.DTOs.CustomerDTOs;
using Project2.DTOs.DeliverDTOs;
using Project2.DTOs.EmailDTOs;
using Project2.DTOs.MarketerDTOs;
using Project2.Model.Helpers;
using Project2.Repository.Interfaces;


namespace Project2.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class UserController : ControllerBase
    {
        private IUserService _UserService;
        public UserController(IUserService UserService)
        {
            _UserService = UserService;
        }
        [HttpPost("Login")]
        public IActionResult Login(LoginViewModel Login)
        {
            ApiResponse Response = _UserService.Login(Login);
            return Ok(Response);
        }
        [HttpPost("RegisterForCustomer")]
        public async Task<IActionResult> RegisterForCustomer(AddCustomerViewModel NewCustomer)
        {
            ApiResponse Response = await _UserService.RegisterForCustomer(NewCustomer);
            return Ok(Response);
        }
        //[HttpPost("RegisterForDeliver")]
        //public async Task<IActionResult> RegisterForDeliver(AddDeliverViewModel NewDeliver)
        //{
        //    ApiResponse Response = await _UserService.RegisterForDeliver(NewDeliver);
        //    return Ok(Response);
        //}
        [HttpPost("RegisterForMarketer")]
        public async Task<IActionResult> RegisterForMarketer(AddMarketerViewModel NewMarketer)
        {
            ApiResponse Response = await _UserService.RegisterForMarketer(NewMarketer);
            return Ok(Response);
        }
        [HttpPost("forget-password")]
        public IActionResult ForgetPassword(PasswordResetRequest request)
        {
            ApiResponse Response = _UserService.ForgetPassword(request);
            return Ok(Response);
        }
        [HttpPost("verify-code")]
        public IActionResult VerifyResetCode(string token, VerifyCodeViewModel verifyCode)
        {
            ApiResponse Response = _UserService.VerifyResetCode(token,verifyCode);
            return Ok(Response);
        }
        [HttpPost("change-password")]
        public IActionResult ChangePassword(string token, ResetPasswordViewModel resetPassword)
        {
            ApiResponse Response = _UserService.ChangePassword(token,resetPassword);
            return Ok(Response);
        }
    }
}
