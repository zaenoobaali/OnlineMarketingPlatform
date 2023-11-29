using Microsoft.EntityFrameworkCore.Query.Internal;
using Project2.DTOs.ComplaintDTOs;
using Project2.Model;
using Project2.Model.Entities;
using Project2.Model.Helpers;
using Project2.Repository.Interfaces;

namespace Project2.Repository.Services
{
    public class ComplaintService : IComplaintService
    {
        public AppDbContext _dbContext { get; set; }
        public ComplaintService(AppDbContext DbContext)
        {
            _dbContext = DbContext;
        }

        public override ApiResponse AddComplaint(int userId,int postId, ComplaintViewModel complaintViewModel)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.UID == userId);
            var post = _dbContext.Posts.FirstOrDefault(p => p.Id == postId);
            //var admin = _dbContext.Users
            //    .FirstOrDefault(a => a.userType.Equals(Data.Enum.UserType.Admin));
            if (user == null) return new ApiResponse(false,"user not found 😶");
            if (post == null) return new ApiResponse(false, "post not found");
            //var main = _dbContext.Maintainers
            //    .FirstOrDefault(m => m.RoleId == 2);

            //if (admin == null && main == null)
            //    return new ApiResponse(false,"Where is the admin!!😮");

            var complaint = new Complaint
            {
                ComplainerId = user.UID,
                Discretion = complaintViewModel.Discretion,
                postId = postId,
                CreatedDate = DateTime.Now,
                Status = false
            };

            _dbContext.Complaints.Add(complaint);
            _dbContext.SaveChanges();
            //if (main == null)
            //{
            //    var notifyad = new Notification
            //    {
            //        Body = $"The User {user.Name} filed a complaint 🥴",
            //        SenderId = user.UID,
            //        RecieverId = admin.UID,
            //        CreatedDate = DateTime.Now
            //    };
            //    _dbContext.Notifications.Add(notifyad);
            //    _dbContext.SaveChanges();

            //    var compNotifyd = new
            //    {
            //        notificationad = notifyad,
            //        complaintId = complaint.Id
            //    };

            //    return new ApiResponse(compNotifyd, "Seccess");
            //}

            //var notify = new Notification
            //{
            //    Body = $"The User {user.Name} filed a complaint 🥴",
            //    SenderId = user.UID,
            //    RecieverId = main.userId,
            //    Sender = user,
            //    CreatedDate = DateTime.Now
            //};

            //_dbContext.Notifications.Add(notify);
            //_dbContext.SaveChanges();

            //var compNotify = new
            //{
            //    notificationad = notify,
            //    complaintId = complaint.Id
            //};

            return new ApiResponse(true, "Success");
        }

        public override ApiResponse ViewComplaint(int complaintId)
        {
            var complaint = from comp in _dbContext.Complaints
                            join user in _dbContext.Users on comp.ComplainerId equals user.UID
                            join post in _dbContext.Posts on comp.postId equals post.Id
                            join prod in _dbContext.Products on post.productId equals prod.id
                            where comp.Id == complaintId
                            select new
                            {
                                complainter = user.Name,
                                comp.Discretion,
                                prod.Name,
                                comp.Status,
                                comp.Id,
                                comp.postId
                            };
            var complaints = complaint.ToList();

            return new ApiResponse(complaints , "Success");
        }
    }
}
