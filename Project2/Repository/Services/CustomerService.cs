using NuGet.Frameworks;
using Project2.Model;
using Project2.Model.Entities;
using Project2.Model.Helpers;
using Project2.Repository.Interfaces;

namespace Project2.Repository.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly AppDbContext _dbContext;

        public CustomerService(AppDbContext DbContext)
        {
            _dbContext = DbContext;
        }

        public override ApiResponse AcceptToBeAgent(int customerId, int marketerId)
        {
            var marketer = _dbContext.Marketers.FirstOrDefault(c => c.userId == marketerId);
            if (marketer == null)
                return new ApiResponse(false, "MarketernotFound");
            var customer = _dbContext.Customers.FirstOrDefault(c => c.userId == customerId);
            if (customer == null)
                return new ApiResponse(false, "CustomernotFound");
            var name = customer.FName + " " + customer.LName;

            var agent = new CustomersAgent
            {
                customerId = customer.Id,
                marketerId = marketer.Id,
                CreatedDate = DateTime.Now
            };

            var notify = new Notification
            {
                Body = $"The customer {name} accepted to be your agint !",
                SenderId = customerId,
                RecieverId = marketerId,
                notifyType = Data.Enum.NotifyType.Normal,
                CreatedDate = DateTime.Now
            };

            customer.IsAgent = true;

            _dbContext.Notifications.Add(notify);
            _dbContext.CustomersAgents.Add(agent);
            _dbContext.SaveChanges();

            return new ApiResponse(true, "Success");
        }

        public override ApiResponse UnAcceptToBeAgent(int customerId, int marketerId)
        {
            var marketer = _dbContext.Marketers.FirstOrDefault(c => c.userId == marketerId);
            if (marketer == null)
                return new ApiResponse(false, "MarketernotFound");
            var customer = _dbContext.Customers.FirstOrDefault(c => c.userId == customerId);
            if (customer == null)
                return new ApiResponse(false, "CustomernotFound");
            var name = customer.FName + " " + customer.LName;


            var notify = new Notification
            {
                Body = $"The customer {name} is not  accepted to be your agint !",
                SenderId = customerId,
                RecieverId = marketerId,
                notifyType = Data.Enum.NotifyType.Normal,
                CreatedDate = DateTime.Now
            };

            customer.IsAgent = false;

            _dbContext.Notifications.Add(notify);
            _dbContext.SaveChanges();

            return new ApiResponse(true, "Success");
        }


        public override ApiResponse CustomersFollowMarketers(int marketerId)
        {
            var markter = _dbContext.Marketers.FirstOrDefault(m => m.userId == marketerId);
            if (markter == null) return new ApiResponse();

            //var pages = from page in _dbContext.FollowingPages
            //            join mark in _dbContext.Marketers on page.pageId equals mark.Id
            //            where page.userId == userId
            //            select new
            //            {
            //                mark.Name,
            //                mark.photo,
            //                mark.userId
            //            };

            //var followingPages = pages.ToList();
            //if (followingPages == null)
            //    return new ApiResponse(false, "notFound");



            var Follower = from follow in _dbContext.FollowingPages
                              join cust in _dbContext.Customers on follow.userId equals cust.userId
                              where follow.pageId == markter.Id
                              select new
                              {
                                  custmerName = cust.FName + " " + cust.LName,
                                  custphoto = cust.photo,
                                  cust.userId
                              };

            var myfollowers = Follower.ToList();

            return new ApiResponse(myfollowers, "Success", Follower.Count());
        }

        public override ApiResponse ViewAllCustomers()
        {
            var customers = from custm in _dbContext.Customers
                            join user in _dbContext.Users on custm.userId equals user.UID
                            select new
                            {
                                custmername = custm.FName + " " + custm.LName,
                                custmerphoto = custm.photo,
                                id = custm.userId
                            };
            var allcust = customers.ToList();

            return new ApiResponse(allcust, "Success", customers.Count());
        }
    }
}
