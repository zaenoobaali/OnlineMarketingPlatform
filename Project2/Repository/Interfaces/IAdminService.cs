using Project2.DTOs.AdminDTOs;
using Project2.DTOs.DeliverDTOs;
using Project2.DTOs.NotifyDTOs;
using Project2.Model.Helpers;
namespace Project2.Repository.Interfaces
{
    public abstract class IAdminService
    {
       public abstract ApiResponse ViewUsers(int adminId);
       public abstract ApiResponse BlockUser(int adminId,int userId);
       public abstract ApiResponse unBlockUser ( int adminId,int userId );
       public abstract ApiResponse ViewMarketers(int adminId);
       public abstract ApiResponse ViewComplaints(int adminId);
       public abstract ApiResponse ReplayComplaint(int adminId,int complaintId, AddNotificationViewModel notificationViewModel);
       public abstract ApiResponse DeleteComplaint(int adminId, int complaintId);
       public abstract ApiResponse ViewDelivers(int adminId);
       public abstract ApiResponse ViewMaintainers(int adminId);
       public abstract ApiResponse ViewRoles(int adminId);
       public abstract Task<ApiResponse> AddMaintainer(int adminId, MaintainerViewModel maintainerView);
       public abstract ApiResponse DeleteMaintainer(int adminId, int maintainerId);
       public abstract ApiResponse RolesNames();
       public abstract ApiResponse AddRole(int adminId, RoleViewModel roleViewModel);
       public abstract ApiResponse DeleteRole(int adminId, int roleId);
       public abstract ApiResponse ViewPopularization(int adminId);
       public abstract ApiResponse AcceptPopularization(int adminId, int popularizationId);
       public abstract ApiResponse UnAcceptPopularization(int adminId, int popularizationId);
       public abstract ApiResponse ViewTender (int adminId);
       public abstract ApiResponse CancelTender(int adminId, int tenderId);
       public abstract ApiResponse ViewAuction (int adminId);
       public abstract ApiResponse CancelAuction(int adminId, int auctionId);
       public abstract ApiResponse PointRequest(int adminId);
       public abstract ApiResponse AcceptPointRequest(int adminId, int markterId);
       public abstract ApiResponse UnAcceptPointRequest(int adminId, int markterId);
        //Task<ApiResponse> RegisterForDeliver(int adminId, AddDeliverViewModel NewDeliver);
    }
}
