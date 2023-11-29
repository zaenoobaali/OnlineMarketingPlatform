using Project2.DTOs.NotifyDTOs;
using Project2.Model.Helpers;

namespace Project2.Repository.Interfaces
{
    public abstract class INotifyServices
    {
       public abstract ApiResponse ViewNotificationsList(int userId);
       public abstract ApiResponse AddNotification(int senderId, int receiverId, AddNotificationViewModel addNotification);
       public abstract ApiResponse DeleteNotification(int userId, int notificationId);
    }
}
