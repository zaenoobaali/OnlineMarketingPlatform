using Microsoft.EntityFrameworkCore;
using Project2.Model;
using Project2.Model.Entities;
using Project2.Model.Helpers;
using Project2.Repository.Interfaces;

namespace Project2.Repository.Services
{
    public class DeliverService : IDeliverService
    {
        public AppDbContext _dbContext { get; set; }
        public DeliverService(AppDbContext DbContext)
        {
            _dbContext = DbContext;
        }

        public override ApiResponse AllDeliver()
        {
            var deliver = from deliv in _dbContext.Delivers
                          join user in _dbContext.Users on deliv.userId equals user.UID
                          select new
                          {
                              deliv.photo,
                              deliv.Name,
                              deliv.userId
                          };

            var delivers = deliver.ToList();
            int count = deliver.Count();

            return new ApiResponse(delivers, "Success", count);
        }

        public override ApiResponse ShowDeliverName()
        {
            var deliver = from deliv in _dbContext.Delivers
                          join user in _dbContext.Users on deliv.userId equals user.UID
                          select new
                          {
                              deliv.Name,
                              deliv.userId
                          };

            var delivers = deliver.ToList();
            int count = deliver.Count();

            return new ApiResponse(delivers, "Success", count);
        }

        public override ApiResponse AcceptToContract(int deliverId, int marketerId)
        {
            var marketer = _dbContext.Marketers.FirstOrDefault(c => c.userId == marketerId);
            if (marketer == null) return new ApiResponse(false, "Marketer not Found");
            var deliver = _dbContext.Delivers.FirstOrDefault(d => d.userId == deliverId);
            if (deliver == null) return new ApiResponse(false, "Deliverer not Found");

            var contact = new ContractedDeliver
            {
                deliverId = deliver.Id,
                marketerId = marketer.Id,
                CreatedDate = DateTime.Now
            };

            var notify = new Notification
            {
                Body = $"The deliver {deliver.Name} accepted to contract with you !",
                SenderId = deliverId,
                RecieverId = marketerId,
                notifyType = Data.Enum.NotifyType.Normal,
                CreatedDate = DateTime.Now
            };

            _dbContext.Notifications.Add(notify);
            _dbContext.ContractedDelivers.Add(contact);
            _dbContext.SaveChanges();

            return new ApiResponse(true, "Success");
        }

        public override ApiResponse UnAcceptToContract(int deliverId, int marketerId)
        {
            var marketer = _dbContext.Marketers.FirstOrDefault(c => c.userId == marketerId);
            if (marketer == null) return new ApiResponse(false, "Marketer not Found");
            var deliver = _dbContext.Delivers.FirstOrDefault(d => d.userId == deliverId);
            if (deliver == null) return new ApiResponse(false, "Deliverer not Found");


            var notify = new Notification
            {
                Body = $"The deliver {deliver.Name} is not accepted to contract with you !",
                SenderId = deliverId,
                RecieverId = marketerId,
                notifyType = Data.Enum.NotifyType.Normal,
                CreatedDate = DateTime.Now
            };

            _dbContext.Notifications.Add(notify);
            _dbContext.SaveChanges();

            return new ApiResponse(true, "Success");
        }

    }
}
