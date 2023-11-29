using Project2.DTOs.CustomerDTOs;
using Project2.DTOs.DeliverDTOs;
using Project2.DTOs.MarketerDTOs;
using Project2.DTOs.UserDTOs;
using Project2.Model.Helpers;

namespace Project2.Repository.Interfaces
{
    public abstract class IProfileService
    {
        //ApiResponse ViewMarketerProfile(int userId);
       public abstract ApiResponse ViewMarketerProfileById(int userId,int marketerId);
       public abstract ApiResponse ViewCustomerProfileById(int userId,int customerId);
       public abstract ApiResponse ViewDeliverProfile(int userId);
       public abstract ApiResponse UpdateCustomerProfile(int userId, int custId, UpdateCustomerViewModel updateCustomer);
       public abstract ApiResponse UpdateMarketerProfile(int userId, int markId, UpdateMarketerViewModel updateMarketer);
       public abstract ApiResponse UpdateDeliverProfile(int userId, int delivId, UpdateDeliverViewModel updateDeliver);
       public abstract ApiResponse ViewFollowingPagesList(int userId);
       public abstract ApiResponse ViewFriendsList(int userId);
       public abstract ApiResponse FollowMarketer(int userId , int marketerId );
       public abstract ApiResponse UnfollowMarketer(int userId , int marketerId );
       public abstract ApiResponse FollowCustomer(int userId, int customerId);
       public abstract ApiResponse UnfollowCustomer(int userId, int customerId);
       public abstract ApiResponse ViewContactedDeliver(int userId);
       public abstract ApiResponse ContractWithDeliver(int userId , int deliverId);
       public abstract ApiResponse CancelContractWithDeliver(int userId, int deliverId);
       public abstract ApiResponse ViewCustomerAgent(int userId);
       public abstract ApiResponse AddAgent(int userId, int customerId);
       public abstract ApiResponse RemoveAgent(int userId, int customerId);
       public abstract ApiResponse EditUserInfo(int userId, EditUserViewModel editUser);
       public abstract ApiResponse ChangePass(int userId ,UserPasswordViewModel userPassword);

    }
}
