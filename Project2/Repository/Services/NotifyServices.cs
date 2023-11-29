using Project2.DTOs.NotifyDTOs;
using Project2.Model;
using Project2.Model.Entities;
using Project2.Model.Helpers;
using Project2.Repository.Interfaces;

namespace Project2.Repository.Services
{
    public class NotifyServices : INotifyServices
    {
        public AppDbContext _dbContext { get; set; }
        public NotifyServices(AppDbContext DbContext)
        {
            _dbContext = DbContext;
        }
        public override ApiResponse AddNotification(int senderId,int receiverId,AddNotificationViewModel addNotification)
        {
            var recuser = _dbContext.Users
                .FirstOrDefault(u => u.UID == receiverId);// :)
            var senduser = _dbContext.Users
                .FirstOrDefault(u => u.UID == senderId); // :}
            if (recuser == null)
                return new ApiResponse(false , "Receiver User not Found");
            if (senduser == null)
                return new ApiResponse(false ,"Sender User Not Found");

            var notification = new Notification 
            {
                Body = addNotification.Body,
                SenderId = senduser.UID,
                RecieverId = recuser.UID
            
            };
            _dbContext.Notifications.Add(notification);
            _dbContext.SaveChanges();
                //return await new ApiResponse();
            return new ApiResponse(notification , "Success");
        }


        public override ApiResponse DeleteNotification(int userId, int notificationId)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.UID == userId);
            if (user == null)
                return new ApiResponse(false, "notFound");
            var notifaction = _dbContext.Notifications
                .FirstOrDefault(n => n.Id == notificationId & n.RecieverId == userId);
            if (notifaction == null)
                return new ApiResponse(false , "notFound");

            _dbContext.Notifications.Remove(notifaction);
            _dbContext.SaveChanges();

            return new ApiResponse(notifaction , "Success");
        }

        public override ApiResponse ViewNotificationsList(int userId)
        {
            var notification =from notify in _dbContext.Notifications
                               join user in _dbContext.Users on notify.SenderId equals user.UID
                               where notify.RecieverId == userId
                               select new
                               {
                                   notifyFrom = user.Name,
                                   userId = user.UID,
                                   notify.Body,
                                   type = notify.notifyType,
                                   notifyId = notify.Id
                               };
            var notifications = notification.ToList();
            if (notifications == null)
                return new ApiResponse(false, "notFound");

            return new ApiResponse(notifications , "Success");
        }

       
    }
}
