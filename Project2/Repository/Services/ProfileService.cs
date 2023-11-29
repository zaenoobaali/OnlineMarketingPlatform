using Microsoft.EntityFrameworkCore;
using Project2.DTOs.CustomerDTOs;
using Project2.DTOs.DeliverDTOs;
using Project2.DTOs.MarketerDTOs;
using Project2.DTOs.UserDTOs;
using Project2.Model;
using Project2.Model.Entities;
using Project2.Model.Helpers;
using Project2.Repository.Interfaces;

namespace Project2.Repository.Services
{
    public class ProfileService : IProfileService
    {
        public AppDbContext _dbContext { get; set; }
        public ProfileService(AppDbContext DbContext)
        {
            _dbContext = DbContext;
        }

        //public ApiResponse ViewCustomerProfile(int userId)
        //{
        //    var query = from customer in _dbContext.Customers
        //                join user in _dbContext.Users on customer.userId equals user.UID
        //                where user.UID == userId
        //                select new
        //                {
        //                    custName = customer.FName + " " + customer.LName,
        //                    custPhon = customer.phoneNumber,
        //                    custBirth = customer.Birthdate,
        //                    custPhoto = customer.photo,
        //                    custCity = customer.city,
        //                    custZone = customer.zone,
        //                    custage = customer.age,
        //                    custGender = customer.gender,
        //                    CustEmail = user.Email
        //                };
        //    var cust = _dbContext.Customers.FirstOrDefault(c => c.userId == userId);
        //    if (cust == null)
        //        return new ApiResponse();
        //    var post = from cutpost in _dbContext.CustPosts
        //               join pro in _dbContext.ProductOrders on cutpost.ProductOrderId equals pro.Id
        //               join pos in _dbContext.Posts on pro.prouductId equals pos.productId
        //               join mark in _dbContext.Marketers on pos.marketerId equals mark.Id
        //               where cutpost.CustomerId == cust.Id
        //               select new
        //               {
        //                   prouductPhoto = pro.photo,
        //                   proudName = pro.name,
        //                   //prouductSizes = pro.size,
        //                   //prouductColors = pro.color,
        //                   reaction = cutpost.reactioncounter,
        //                   marketereName = mark.Name,
        //                   PostId = pos.Id,
        //               };

        //    var customerWithUserEmail = query.ToList();
        //    var customerpost = post.ToList();

        //    if (customerWithUserEmail == null)
        //        return new ApiResponse(false, "notFound");

        //    var profile = new
        //    {
        //        customerinfo = customerWithUserEmail,
        //        customerposts = customerpost
        //    };

        //    return new ApiResponse(profile, "Seccess");
        //}

        public override ApiResponse ViewCustomerProfileById(int userId, int customerId)
        {
            var usercust = _dbContext.Customers.FirstOrDefault(c => c.userId == userId);
            var cust = _dbContext.Customers.FirstOrDefault(c => c.userId == customerId);
            if (usercust == null) return new ApiResponse(false , "user not found");
            if (cust == null) return new ApiResponse(false , "customer not found");
         
            if (userId == customerId)
            {

                if (usercust.IsAgent)
                {
                    var querya = userInformation(userId);
                    var myposta = UserPosts(userId);
                    var agent = AgentPost(userId);
                    var myprofilea = new
                    {
                        customerinfo = querya,
                        customerposts = myposta,
                        agentpost = agent
                    };

                    return new ApiResponse(myprofilea, "Success");
                }

                var query = userInformation(userId);

                var mypost = UserPosts(userId);

                var myprofile = new
                {
                    customerinfo = query,
                    customerposts = mypost
                };

                return new ApiResponse(myprofile, "Success");
            }
            else {
                if (cust.IsAgent) {
                    var infoa = userInformation(customerId);
                    var posta = from cutpost in _dbContext.CustPosts
                                join pro in _dbContext.ProductOrders on cutpost.ProductOrderId equals pro.Id
                                join pos in _dbContext.Posts on pro.prouductId equals pos.productId
                                join mark in _dbContext.Marketers on pos.marketerId equals mark.Id
                                where cutpost.CustomerId == cust.Id && cutpost.status == Data.Enum.PostStatus.Public
                                select new
                                {
                                    productPhoto = pro.photo,
                                    productName = pro.name,
                                    //prouductSizes = pro.size,
                                    //prouductColors = pro.color,
                                    reaction = cutpost.reactioncounter,
                                    marketerName = mark.Name,
                                    PostId = pos.Id,
                                    customerId = userId
                                }; 
                    var agentc = AgentPost(customerId);
                    bool isExisting = _dbContext.Friends
                   .Any(f => f.friendId == customerId && f.userId == userId);
                    var friend = false;
                    if (isExisting)
                        friend = true;

                    var profilea = new
                    {
                        customerinfo = infoa,
                        customerposts = posta.ToList(),
                        agentposts = agentc,
                        customerfreind = friend
                    };

                    return new ApiResponse(profilea, "Success");
                }

                var info = userInformation(customerId);
                var post = from cutpost in _dbContext.CustPosts
                           join pro in _dbContext.ProductOrders on cutpost.ProductOrderId equals pro.Id
                           join pos in _dbContext.Posts on pro.prouductId equals pos.productId
                           join mark in _dbContext.Marketers on pos.marketerId equals mark.Id
                           where cutpost.CustomerId == cust.Id && cutpost.status == Data.Enum.PostStatus.Public
                           select new
                           {
                               productPhoto = pro.photo,
                               productName = pro.name,
                               //prouductSizes = pro.size,
                               //prouductColors = pro.color,
                               reaction = cutpost.reactioncounter,
                               marketerName = mark.Name,
                               PostId = pos.Id,
                               customerId = userId
                           };
                bool issExisting = _dbContext.Friends
                  .Any(f => f.friendId == customerId && f.userId == userId);
                var friendc = false;
                if (issExisting)
                    friendc = true;

                var profile = new
                {
                    customerinfo = info,
                    customerposts = post.ToList(),
                    customerfreind = friendc
                };

                return new ApiResponse(profile, "Success");
            }
        }

        public Object userInformation(int userId)
        {
            var cust = _dbContext.Customers.FirstOrDefault(c => c.userId == userId);
            var mark = _dbContext.Marketers.FirstOrDefault(m => m.userId == userId);
            if (cust != null)
            {
                var query = from customer in _dbContext.Customers
                            join user in _dbContext.Users on customer.userId equals user.UID
                            where user.UID == userId
                            select new
                            {
                                custName = customer.FName + " " + customer.LName,
                                custPhon = customer.phoneNumber,
                                custBirth = customer.Birthdate,
                                custPhoto = customer.photo,
                                custCity = customer.city,
                                custZone = customer.zone,
                                custage = customer.age,
                                custGender = customer.gender,
                                CustEmail = user.Email,
                                custPoint = customer.Point,
                                custBill = user.Billfold,
                                customer.userId
                            };
                return query.ToList();
            }
            else if(mark != null)
            {
                var querym = from marketer in _dbContext.Marketers
                            join user in _dbContext.Users on marketer.userId equals user.UID
                            where user.UID == userId
                            select new
                            {
                                MarkName = marketer.Name,
                                MarkPhone = marketer.phoneNumber,
                                MarkMobil = marketer.mobileNumber,
                                MarkCity = marketer.city,
                                MarkZone = marketer.zone,
                                MarkPhoto = marketer.photo,
                                UserId = marketer.userId,
                                MarkEmail = user.Email,
                                MarkPoint = marketer.Point,
                                MarkBill = user.Billfold
                            };
                return querym.ToList();
            }
            return new ApiResponse(false, "not found");
        }
        public Object UserPosts(int userId)
        {
            var cust = _dbContext.Customers.FirstOrDefault(c => c.userId == userId);
            var mar = _dbContext.Marketers.FirstOrDefault(m => m.userId == userId);
           
            if (cust != null)
            {
                var mypost = from cutpost in _dbContext.CustPosts
                             join pro in _dbContext.ProductOrders on cutpost.ProductOrderId equals pro.Id
                             join pos in _dbContext.Posts on pro.prouductId equals pos.productId
                             join mark in _dbContext.Marketers on pos.marketerId equals mark.Id
                             where cutpost.CustomerId == cust.Id
                             select new
                             {
                                 productPhoto = pro.photo,
                                 prouductName = pro.name,
                                 InteractionsCount = cutpost.reactioncounter,
                                 marketerName = mark.Name,
                                 PostId = pos.Id,
                                 custId = cust.userId
                             };

                return mypost.ToList();
            }
            else if(mar != null)
            {
                var post = from pos in _dbContext.Posts
                           join prod in _dbContext.Products on pos.productId equals prod.id
                           where pos.marketerId == mar.Id
                           select new
                           {
                               productPhoto = prod.photo,
                               prouductName = prod.Name,
                               postId = pos.Id,
                               reactionNum = pos.reactioncount,
                               marketerName = mar.Name
                           };
                return post.ToList();
            }
            return new ApiResponse();
        }
        public Object AgentPost(int userId)
        {

            var salepost = from custo in _dbContext.Customers
                           join agent in _dbContext.CustomersAgents on custo.Id equals agent.customerId
                           join mark in _dbContext.Marketers on agent.marketerId equals mark.Id
                           join pos in _dbContext.Posts on mark.Id equals pos.marketerId
                           join prod in _dbContext.Products on pos.productId equals prod.id
                           where custo.userId == userId
                           select new
                           {
                               productPhoto = prod.photo,
                               productName = prod.Name,
                               postId = pos.Id,
                               InteractionsCount = pos.reactioncount
                           };
            return salepost.ToList();
        }

    
        public override ApiResponse ViewMarketerProfileById(int userId, int marketerId)
        {
            if(userId == marketerId)
            {
                var query = userInformation(userId);
                var post = UserPosts(userId);
                var myprofile = new
                {
                    markterinfo = query,
                    markterpost = post
                };

                return new ApiResponse(myprofile, "Success");
            }

            var querym = userInformation(marketerId);
            var postm = UserPosts(marketerId);   

            bool isExisting = _dbContext.FollowingPages
                .Any(fp => fp.pageId == marketerId && fp.userId == userId);
            bool follow = false;
            if (isExisting)
                follow = true;
            
            var profilem = new
            {
                markterinfo = querym,
                markterpost = postm,
                followmarkter = follow
            };

            return new ApiResponse(profilem, "Success");
        }

        public override ApiResponse ViewDeliverProfile(int userId)
        {
            var query = from deliver in _dbContext.Delivers
                        join user in _dbContext.Users on deliver.userId equals user.UID
                        where user.UID == userId
                        select new
                        {
                            DName = deliver.Name,
                            DPhone = deliver.phoneNumber,
                            DMobile = deliver.mobileNumber,
                            DCity = deliver.city,
                            DZone = deliver.zone,
                            DPhoto = deliver.photo,
                            //deliver.userId,
                            DEmail = user.Email
                        };
            
            var deliverWithUserEmail = query.ToList();

            if (deliverWithUserEmail == null)
                return new ApiResponse(false, "notFound");

            return new ApiResponse(deliverWithUserEmail, "Success");
        }

        public override ApiResponse UpdateCustomerProfile(int userId, int custId, UpdateCustomerViewModel updateCustomer)
        {
            var user = _dbContext.Users.Include(u => u.Customer).FirstOrDefault(u => u.UID == userId);
            if (user == null)
                return new ApiResponse(false, "User not found");
            var customer = _dbContext.Customers.FirstOrDefault(c => c.userId == custId);
            if (customer == null) return new ApiResponse(false, "Customer not found"); 

            if (user.Customer == null || user.Customer.Id != custId)
                return new ApiResponse(false, "you cann't edit this!");

            customer.FName = updateCustomer.FName;
            customer.LName = updateCustomer.LName;
            customer.phoneNumber = updateCustomer.phoneNumber;
            customer.photo = updateCustomer.photo;
            customer.Birthdate = updateCustomer.Birthdate;
            customer.city = updateCustomer.city;
            customer.zone = updateCustomer.zone;
            customer.gender = updateCustomer.gender;
            customer.age = AgeCalculation.GetAge(updateCustomer.Birthdate);
            customer.CreatedDate = DateTime.Now;

            _dbContext.SaveChanges();

            return new ApiResponse(true, "Success");
        }

        public override ApiResponse UpdateMarketerProfile(int userId, int markId, UpdateMarketerViewModel updateMarketer)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.UID == userId);
            if (user == null)
                return new ApiResponse(false, "User not found");
            var marketer = _dbContext.Marketers.FirstOrDefault(m => m.userId == markId);
            if (marketer == null) return new ApiResponse(false, "Marketer not found");

            if (userId != markId)
                return new ApiResponse(false, "you cann't edit this!");

            marketer.Name = updateMarketer.Name;
            marketer.phoneNumber = updateMarketer.phoneNumber;
            marketer.mobileNumber = updateMarketer.mobileNumber;
            marketer.photo = updateMarketer.photo;
            marketer.city = updateMarketer.city;
            marketer.zone = updateMarketer.zone;
            marketer.CreatedDate = DateTime.Now;

            _dbContext.SaveChanges();

            return new ApiResponse(true, "Success");
        }

        public override ApiResponse UpdateDeliverProfile(int userId, int delivId, UpdateDeliverViewModel updateDeliver)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.UID == userId);
            if (user == null)
                return new ApiResponse(false, "User not found");
            var deliver = _dbContext.Delivers.FirstOrDefault(d => d.userId == delivId);
            if (deliver == null) return new ApiResponse(false, "Deliver not found");
       
            if (userId != delivId)
                return new ApiResponse(false, "you cann't edit this!");

            deliver.Name = updateDeliver.Name;
            deliver.phoneNumber = updateDeliver.phoneNumber;
            deliver.mobileNumber = updateDeliver.mobileNumber;
            deliver.photo = updateDeliver.photo;
            deliver.city = updateDeliver.city;
            deliver.zone = updateDeliver.zone;
            deliver.CreatedDate = DateTime.Now;

            _dbContext.SaveChanges();

            return new ApiResponse(true, "Success");
        }

        public override ApiResponse ViewFollowingPagesList(int userId)
        {
            var pages = from page in _dbContext.FollowingPages
                        join mark in _dbContext.Marketers on page.pageId equals mark.Id
                        where page.userId == userId
                        select new
                        {
                            mark.Name,
                            mark.photo,
                            mark.userId
                        };

            var followingPages = pages.ToList();
            if (followingPages == null)
                return new ApiResponse(false, "notFound");

            return new ApiResponse(followingPages, "Success" , pages.Count());
        }

        public override ApiResponse ViewFriendsList(int userId)
        {
            var friend = from frin in _dbContext.Friends
                         join cust in _dbContext.Customers on frin.friendId equals cust.Id
                         where frin.userId == userId
                         select new
                         {
                             Name = cust.FName + " " + cust.LName,
                             cust.photo,
                             cust.userId
                         };
            var custfriend = friend.ToList();

            if (custfriend == null)
                return new ApiResponse(false, "notFound");
            return new ApiResponse(custfriend, "Success" ,friend.Count());
        }

        public override ApiResponse FollowMarketer(int userId, int marketerId)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.UID == userId);
            if (user == null) return new ApiResponse(false, "User not Found");
            var marketer = _dbContext.Marketers.FirstOrDefault(m => m.userId == marketerId);
            if(marketer == null) return new ApiResponse(false, "Marketer not Found");

            bool isExisting = _dbContext.FollowingPages
                .Any(fp => fp.pageId == marketer.Id && fp.userId == user.UID);

            if (isExisting) return new ApiResponse(false, "You are following this page!");

            if (userId == marketerId) return new ApiResponse(false, "you cann't follow yourself 😁");

            var followingPage = new FollowingPage
            {
                pageId = marketer.Id,
                userId = user.UID,
                Marketer = marketer,
                User = user,
                CreatedDate = DateTime.Now
            };

            _dbContext.FollowingPages.Add(followingPage);
            //user.FollowingPages.Add(followingPage);
            _dbContext.SaveChanges();

            return new ApiResponse(true , "Success"); 
           
        }

        public override ApiResponse UnfollowMarketer(int userId, int marketerId)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.UID == userId);
            var followingPage = _dbContext.FollowingPages
                .FirstOrDefault(fp => fp.Marketer.userId == marketerId && fp.userId == userId);
            if (user == null)
                return new ApiResponse(false, "user not found");
            if (followingPage == null)
                return new ApiResponse(false, "page not found");

            //user.FollowingPages.Remove(followingPage);
            _dbContext.FollowingPages.Remove(followingPage);
            _dbContext.SaveChanges();
            return new ApiResponse(true, "Success");
         
        }

        public override ApiResponse FollowCustomer(int userId, int customerId)
        {
            var customer = _dbContext.Users.FirstOrDefault(c => c.UID == userId);
            if (customer == null)
                return new ApiResponse(false, "User not Found");
            var frindcustomer = _dbContext.Customers.FirstOrDefault(c => c.userId == customerId);
            if (frindcustomer == null)
                return new ApiResponse(false, "Customer not Found");
            
            bool isExisting = _dbContext.Friends
                    .Any(f => f.friendId == frindcustomer.Id && f.userId == userId);

            if (isExisting) return new ApiResponse(false, "You are following this page!");

            if (userId == customerId) return new ApiResponse(false, "you cann't follow yourself 😁");
            
           var friend = new Friend
            {
                friendId = frindcustomer.Id,
                userId = userId,
                User = customer,
                Customer = frindcustomer,
                CreatedDate = DateTime.Now
            };

            _dbContext.Friends.Add(friend);
            //customer.Friends.Add(friend);
            _dbContext.SaveChanges();
            

            return new ApiResponse(true, "Success");
        }

        public override ApiResponse UnfollowCustomer(int userId, int customerId)
        {
            var customer = _dbContext.Customers.FirstOrDefault(c => c.userId == userId);
            var friends = _dbContext.Friends
                .FirstOrDefault(fp => fp.Customer.userId == customerId && fp.userId == userId);
            if (customer == null)
                return new ApiResponse(false ,"customer not found");
            if (friends == null)
                return new ApiResponse(false, "friend not found");
            
            //customer.Friends.Remove(friends);
            _dbContext.Friends.Remove(friends);
            _dbContext.SaveChanges();

            return new ApiResponse(friends, "Success");
            
        }

        public override ApiResponse ContractWithDeliver(int userId, int deliverId)
        {
            var marketer = _dbContext.Marketers.FirstOrDefault(c => c.userId == userId);
            if (marketer == null) return new ApiResponse(false, "Marketer not Found");
            var deliver = _dbContext.Delivers.FirstOrDefault(d => d.userId == deliverId);
            if (deliver == null) return new ApiResponse(false, "Deliverer not Found");
            //if(marketer.Delivers.)

            bool isExisting = _dbContext.ContractedDelivers
                   .Any(f => f.marketerId == marketer.Id && f.deliverId == deliver.Id);

            if (isExisting) return new ApiResponse(false, "You are contracting with this company!");

            var notify = new Notification
            {
                Body = $"The Marketer {marketer.Name} sent you a request to contract with him ",
                SenderId = marketer.userId,
                RecieverId = deliver.userId,
                notifyType = Data.Enum.NotifyType.Contract,
                CreatedDate = DateTime.Now
            };

            _dbContext.Notifications.Add(notify);


            //var contact = new ContractedDeliver
            //{
            //    deliverId = deliver.Id,
            //    marketerId = marketer.Id,
            //    CreatedDate = DateTime.Now
            //};

            //_dbContext.ContractedDelivers.Add(contact);
            _dbContext.SaveChanges();

            return new ApiResponse(true, "Success");
        }

        public override ApiResponse CancelContractWithDeliver(int userId, int deliverId)
        {
            var marketer = _dbContext.Marketers.FirstOrDefault(c => c.userId == userId);
            if (marketer == null)
                return new ApiResponse(false, "Marketer not Found");
            var deliver = _dbContext.Delivers.FirstOrDefault(d => d.userId == deliverId);
            if (deliver == null)
                return new ApiResponse(false, "Deliver not Found");
            var contact = _dbContext.ContractedDelivers
                .FirstOrDefault(c => c.marketerId == marketer.Id && c.deliverId == deliver.Id);
            if (contact == null) return new ApiResponse(false, "not found");

            _dbContext.ContractedDelivers.Remove(contact);
            _dbContext.SaveChanges();

            return new ApiResponse(marketer, "Success");
        }

        public override ApiResponse AddAgent(int userId, int customerId)
        {
            var marketer = _dbContext.Marketers.FirstOrDefault(c => c.userId == userId);
            if (marketer == null)
                return new ApiResponse(false, "Marketer not Found");
            var customer = _dbContext.Customers.FirstOrDefault(c => c.userId == customerId);
            if (customer == null)
                return new ApiResponse(false, "Customer not Found");


            bool isExisting = _dbContext.CustomersAgents
                   .Any(f => f.marketerId == marketer.Id && f.customerId == customer.Id);

            if (isExisting) return new ApiResponse(false, "This customer is already your agent!");
            
            var notify = new Notification
            {
                Body = $"The Marketer {marketer.Name} sent you a request to be his agent ",
                SenderId = marketer.userId,
                RecieverId = customer.userId,
                notifyType = Data.Enum.NotifyType.Agent,
                CreatedDate = DateTime.Now
            };

            _dbContext.Notifications.Add(notify);

            //var agent = new CustomersAgent
            //{
            //    customerId = customer.Id,
            //    marketerId = marketer.Id,
            //    CreatedDate = DateTime.Now
            //};
            //customer.IsAgent = true;
            //_dbContext.CustomersAgents.Add(agent);

            _dbContext.SaveChanges();

            return new ApiResponse(true, "Success");
        }

        public override ApiResponse RemoveAgent(int userId, int customerId)
        {
            var marketer = _dbContext.Marketers.FirstOrDefault(c => c.userId == userId);
            if (marketer == null)
                return new ApiResponse(false, "Marketer not Found");
            var customer = _dbContext.Customers.FirstOrDefault(c => c.Id == customerId);
            if (customer == null)
                return new ApiResponse(false, "Customer not Found");
            var agent = _dbContext.CustomersAgents
                .FirstOrDefault(c => c.marketerId == marketer.Id && c.customerId == customer.Id);
            if (agent == null) return new ApiResponse(false, "not found");

            _dbContext.CustomersAgents.Remove(agent);
            customer.IsAgent = false;
            _dbContext.SaveChanges();
            return new ApiResponse(true, "Success");
        }

        public override ApiResponse EditUserInfo(int userId, EditUserViewModel editUser)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.UID == userId);
            if (user == null)
                return new ApiResponse(false, "notFound");

            user.UserName = editUser.UserName;
            user.Email = editUser.Email;

            if (user.userType.Equals(Data.Enum.UserType.Customer))
            {
                var cust = _dbContext.Customers.FirstOrDefault(c => c.userId == userId);
                if (cust == null) return new ApiResponse(false,"customer not found");
                cust.UserName = editUser.UserName;
                _dbContext.SaveChanges();
            }
            else if (user.userType.Equals(Data.Enum.UserType.Marketer))
            {
                var mark = _dbContext.Marketers.FirstOrDefault(m => m.userId == userId);
                if (mark == null) return new ApiResponse(false, "marketer not found");
                mark.UserName = editUser.UserName;
                _dbContext.SaveChanges();
            }
            else if(user.userType.Equals(Data.Enum.UserType.Deliver))
            {
                var del = _dbContext.Delivers.FirstOrDefault(d => d.userId == userId);
                if (del == null) return new ApiResponse(false, "deliver not found");
                del.UserName = editUser.UserName;
                _dbContext.SaveChanges();
            }
            else if (user.userType.Equals(Data.Enum.UserType.Maintainer))
            {
                var main = _dbContext.Maintainers.FirstOrDefault(m => m.userId == userId);
                if(main == null) return new ApiResponse(false, "maintaner not found");
                main.UserName = editUser.UserName;
                _dbContext.SaveChanges();
            }

            _dbContext.SaveChanges();

            return new ApiResponse(true, "Success");
        }

        public override ApiResponse ChangePass(int userId, UserPasswordViewModel userPassword)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.UID == userId);
            if (user == null) return new ApiResponse(false,"user not found");

            if(userPassword.password == userPassword.confirmPassword)
            {
                user.password =Encryption.pass(userPassword.password);
                _dbContext.SaveChanges();
                return new ApiResponse(true , "Success");
            }

            return new ApiResponse(false,"Password doesn't match ");
        }

        public override ApiResponse ViewContactedDeliver(int userId)
        {
            var query = from marketer in _dbContext.Marketers
                        join contract in _dbContext.ContractedDelivers on marketer.Id equals contract.marketerId
                        join deliver in _dbContext.Delivers on contract.deliverId equals deliver.Id
                        where marketer.userId == userId
                        select new
                        {
                           deliverName = deliver.Name,
                           deliverphoto = deliver.photo,
                           deliver.userId
                        };

            var ContractDeliver = query.ToList();

            return new ApiResponse(ContractDeliver, "Success", query.Count());
        }

        public override ApiResponse ViewCustomerAgent(int userId)
        {
            var query = from marketer in _dbContext.Marketers
                        join agent in _dbContext.CustomersAgents on marketer.Id equals agent.marketerId
                        join cust in _dbContext.Customers on agent.customerId equals cust.Id
                        where marketer.userId == userId
                        select new
                        {
                            agentname = cust.FName + " " + cust.LName,
                            agentphoto = cust.photo,
                            cust.userId
                        };

            var CustomersAgents = query.ToList();
            return new ApiResponse(CustomersAgents, "Success", query.Count());
        }
    }

}
