using Project2.DTOs;
using Project2.DTOs.CustomerDTOs;
using Project2.DTOs.DeliverDTOs;
using Project2.DTOs.EmailDTOs;
using Project2.DTOs.MarketerDTOs;
using Project2.Model.Helpers;

namespace Project2.Repository.Interfaces
{
    public abstract class IUserService
    {
       public abstract ApiResponse Login(LoginViewModel Login);
       public abstract Task<ApiResponse> RegisterForCustomer(AddCustomerViewModel NewCustomer);
       public abstract Task<ApiResponse> RegisterForDeliver(int adminId, AddDeliverViewModel NewDeliver);
       public abstract Task<ApiResponse> RegisterForMarketer( AddMarketerViewModel NewMarketer);
       public abstract ApiResponse ForgetPassword(PasswordResetRequest request);
       public abstract ApiResponse VerifyResetCode(string token , VerifyCodeViewModel verifyCode);
       public abstract ApiResponse ChangePassword(string token , ResetPasswordViewModel resetPassword);
    }
}
