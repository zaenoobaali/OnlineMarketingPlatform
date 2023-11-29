using AutoMapper;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Project2.DTOs.AdminDTOs;
using Project2.DTOs.NotifyDTOs;
using Project2.Model;
using Project2.Model.Entities;
using Project2.Model.Helpers;
using Project2.Repository.Interfaces;

namespace Project2.Repository.Services
{
    public class AdminService : IAdminService
    {
        public AppDbContext _dbContext { get; set; }
        private IMapper _Mapper;
        public AdminService(AppDbContext DbContext, IMapper mapper)
        {
            _dbContext = DbContext;
            _Mapper = mapper;
        }


        //admin   
        public override ApiResponse ViewDelivers(int adminId)
        {
            var admin = _dbContext.Users
             .FirstOrDefault(u => u.UID == adminId &&
             (u.userType.Equals(Data.Enum.UserType.Admin)));

            //if (admin == null) return new ApiResponse(false, "You are not admin!");

            var maintainer = _dbContext.Maintainers
               .FirstOrDefault(m => m.userId == adminId && m.Role.Name == "User Manager");

            if (maintainer != null || admin != null)
            {
                var deliver = from deliv in _dbContext.Delivers
                              join user in _dbContext.Users on deliv.userId equals user.UID
                              select new
                              {
                                  deliv.Name,
                                  deliv.userId,
                                  user.Email
                              };

                var delivers = deliver.ToList();
                int count = deliver.Count();

                return new ApiResponse(delivers, "Success", count);
            }
            return new ApiResponse(false, "You are not authorized to this action!");
        }
        public override ApiResponse ViewMaintainers(int adminId)
        {
            var admin = _dbContext.Users
             .FirstOrDefault(u => u.UID == adminId &&
             (u.userType.Equals(Data.Enum.UserType.Admin)));

            if (admin == null) return new ApiResponse(false, "You are not admin!");

            var maintainer = from maint in _dbContext.Maintainers
                             join User in _dbContext.Users on maint.userId equals User.UID
                             join role in _dbContext.Roles on maint.RoleId equals role.Id
                             select new
                             {
                                 Name = maint.FName + " " + maint.LName,
                                 User.Email,
                                 roleName = role.Name,
                                 maint.userId
                             };

            var maintainers = maintainer.ToList();
            int count = maintainer.Count();

            return new ApiResponse(maintainers, "Success", count);
        }
        public override ApiResponse ViewMarketers(int adminId)
        {
            var admin = _dbContext.Users
             .FirstOrDefault(u => u.UID == adminId &&
             (u.userType.Equals(Data.Enum.UserType.Admin)));

            //if (admin == null) return new ApiResponse(false, "You are not admin!");

            var maintainer = _dbContext.Maintainers
               .FirstOrDefault(m => m.userId == adminId && m.Role.Name == "User Manager");

            if (maintainer != null || admin != null)
            {
                var marketer = from market in _dbContext.Marketers
                               join user in _dbContext.Users on market.userId equals user.UID
                               select new
                               {
                                   market.Name,
                                   market.userId,
                                   user.Email
                               };


                var markters = marketer.ToList();
                int count = marketer.Count();

                return new ApiResponse(markters, "Success", count);
            }
            return new ApiResponse(false, "You are not authorized to this action!");
        }
        public override ApiResponse ViewRoles(int adminId)
        {
            var admin = _dbContext.Users
             .FirstOrDefault(u => u.UID == adminId &&
             (u.userType.Equals(Data.Enum.UserType.Admin)));

            if (admin == null) return new ApiResponse(false, "You are not admin!");

            var role = from rol in _dbContext.Roles
                       select new
                       {
                           rol.Name,
                           rol.Description,
                           rol.Id
                       };
            var roles = role.ToList();
            int count = role.Count();

            return new ApiResponse(roles, "Success", count);
        }
        public override ApiResponse ViewUsers(int adminId)
        {
            var admin = _dbContext.Users
             .FirstOrDefault(u => u.UID == adminId &&
             (u.userType.Equals(Data.Enum.UserType.Admin)));

            //if (admin == null) return new ApiResponse(false, "You are not admin!");

            var maintainer = _dbContext.Maintainers
                  .FirstOrDefault(m => m.userId == adminId && m.Role.Name == "User Manager");

            if (maintainer != null || admin != null)
            {
                var customer = from cust in _dbContext.Customers
                               join user in _dbContext.Users on cust.userId equals user.UID
                               select new
                               {
                                   Name = cust.FName + " " + cust.LName,
                                   cust.userId,
                                   user.Email
                               };

                var users = customer.ToList();
                int count = customer.Count();

                return new ApiResponse(users, "Success", count);
            }
            return new ApiResponse(false, "You are not authorized to this action!");
        }
        public override ApiResponse RolesNames()
        {
            var role = from rol in _dbContext.Roles
                       select new
                       {
                           rol.Name,
                       };
            var roles = role.ToList();
            int count = role.Count();

            return new ApiResponse(roles, "Success", count);
        }

        public override async Task<ApiResponse> AddMaintainer(int adminId, MaintainerViewModel maintainerView)
        {
            var admin = _dbContext.Users
             .FirstOrDefault(u => u.UID == adminId &&
             (u.userType.Equals(Data.Enum.UserType.Admin)));
            if (admin == null) return new ApiResponse(false, "You are not admin!");

            var role = _dbContext.Roles.FirstOrDefault(r => r.Name == maintainerView.roleName);
            if (role == null) return new ApiResponse(false, "this role not found");

            User NewUserEntity = _Mapper.Map<User>(maintainerView.UserInformation);
            NewUserEntity.userType = Data.Enum.UserType.Maintainer;
            NewUserEntity.Name = maintainerView.FName + " " + maintainerView.LName;

            byte[] Salt = new byte[16] { 41, 214, 78, 222, 28, 87, 170, 211, 217, 125, 200, 214, 185, 144, 44, 34 };

            // Derive a 256-bit Subkey (Use HMACSHA256 With 100,000 Iterations)
            NewUserEntity.password = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: maintainerView.UserInformation.password,
                salt: Salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
            numBytesRequested: 256 / 8));

            await _dbContext.Users.AddAsync(NewUserEntity);
            await _dbContext.SaveChangesAsync();

            Maintainer NewMaintainerEntity = _Mapper.Map<Maintainer>(maintainerView);

            NewMaintainerEntity.userId = NewUserEntity.UID;
            NewMaintainerEntity.RoleId = role.Id;

            _dbContext.Maintainers.Add(NewMaintainerEntity);
            _dbContext.SaveChanges();

            return new ApiResponse(true, "Success");
        }

        public override ApiResponse AddRole(int adminId, RoleViewModel roleViewModel)
        {
            var admin = _dbContext.Users
             .FirstOrDefault(u => u.UID == adminId &&
             (u.userType.Equals(Data.Enum.UserType.Admin)));
            if (admin == null) return new ApiResponse(false, "You are not admin!");

            var role = new Role
            {
                Name = roleViewModel.Name,
                Description = roleViewModel.Description

            };

            _dbContext.Roles.Add(role);
            _dbContext.SaveChanges();

            return new ApiResponse(true, "Success");
        }

        public override ApiResponse DeleteMaintainer(int adminId, int maintainerId)
        {
            var admin = _dbContext.Users
             .FirstOrDefault(u => u.UID == adminId &&
             (u.userType.Equals(Data.Enum.UserType.Admin)));
            if (admin == null) return new ApiResponse(false, "You are not admin!");

            var maintainer = _dbContext.Maintainers.FirstOrDefault(r => r.userId == maintainerId);
            if (maintainer == null)
                return new ApiResponse(false, "not found");

            _dbContext.Maintainers.Remove(maintainer);
            _dbContext.SaveChanges();

            return new ApiResponse(true, "Success");
        }

        public override ApiResponse DeleteRole(int adminId, int roleId)
        {
            var admin = _dbContext.Users
             .FirstOrDefault(u => u.UID == adminId &&
             (u.userType.Equals(Data.Enum.UserType.Admin)));
            if (admin == null) return new ApiResponse(false, "You are not admin!");

            var role = _dbContext.Roles.FirstOrDefault(r => r.Id == roleId);
            if (role == null)
                return new ApiResponse(false, "not found");

            _dbContext.Roles.Remove(role);
            _dbContext.SaveChanges();

            return new ApiResponse(true, "Success");
        }

        public override ApiResponse PointRequest(int adminId)
        {
            var admin = _dbContext.Users
           .FirstOrDefault(u => u.UID == adminId &&
           (u.userType.Equals(Data.Enum.UserType.Admin)));
            if (admin == null) return new ApiResponse(false, "You are not admin!");

            var request = from req in _dbContext.PointRequests
                          join mar in _dbContext.Marketers on req.marketerId equals mar.Id
                          select new
                          {
                              markterName = mar.Name,
                              pointAmounts = req.pointsAmount,
                              pointCost = req.pointsPrice,
                              reqStatus = req.status.ToString(),
                              mar.userId
                          };
            var allRequests = request.ToList();
            return new ApiResponse(allRequests, "Success", request.Count());
        }

        public override ApiResponse AcceptPointRequest(int adminId, int markterId)
        {
            var admin = _dbContext.Users
           .FirstOrDefault(u => u.UID == adminId &&
           (u.userType.Equals(Data.Enum.UserType.Admin)));
            if (admin == null) return new ApiResponse(false, "You are not admin!");
            var marketer = _dbContext.Marketers.FirstOrDefault(m => m.userId == markterId);
            if (marketer == null) return new ApiResponse(false, "marketer not found");
            var usermar = _dbContext.Users.FirstOrDefault(u => u.UID == markterId);
            if (usermar == null) return new ApiResponse(false, "user not found");
            var reqFind = _dbContext.PointRequests.FirstOrDefault(r => r.marketerId == marketer.Id);
            if (reqFind == null) return new ApiResponse(false, "requst not found");

            reqFind.status = Data.Enum.PopularizationStatus.Acceptance;
            marketer.Point += reqFind.pointsAmount;
            usermar.Billfold -= reqFind.pointsPrice;
            admin.Billfold += reqFind.pointsPrice;

            var notify = new Notification
            {
                Body = "Admin accepted your requst point! Check your point!",
                SenderId = adminId,
                RecieverId = marketer.userId,
                notifyType = Data.Enum.NotifyType.Normal,
                CreatedDate = DateTime.Now
            };
            _dbContext.Notifications.Add(notify);
            _dbContext.SaveChanges();
            return new ApiResponse(true, "Success");
        }

        public override ApiResponse UnAcceptPointRequest(int adminId, int markterId)
        {
            var admin = _dbContext.Users
           .FirstOrDefault(u => u.UID == adminId &&
           (u.userType.Equals(Data.Enum.UserType.Admin)));
            if (admin == null) return new ApiResponse(false, "You are not admin!");
            var marketer = _dbContext.Marketers.FirstOrDefault(m => m.userId == markterId);
            if (marketer == null) return new ApiResponse(false, "marketer not found");
            var reqFind = _dbContext.PointRequests.FirstOrDefault(r => r.marketerId == marketer.Id);
            if (reqFind == null) return new ApiResponse(false, "requst not found");
            if (reqFind.status.Equals(Data.Enum.PopularizationStatus.Acceptance))
                return new ApiResponse(false, "You cant do this action !");
            reqFind.status = Data.Enum.PopularizationStatus.Unacceptable;
            _dbContext.SaveChanges();
            return new ApiResponse(true, "Success");
        }

        //user  manager
        public override ApiResponse BlockUser(int adminId, int userId)
        {
            var admin = _dbContext.Users
             .FirstOrDefault(u => u.UID == adminId &&
             (u.userType.Equals(Data.Enum.UserType.Admin)));

            var maintainer = _dbContext.Maintainers
                 .FirstOrDefault(m => m.userId == adminId && m.Role.Name == "User Manager");

            if (maintainer != null || admin != null)
            {
                var user = _dbContext.Users.FirstOrDefault(u => u.UID == userId);
                if (user == null)
                    return new ApiResponse(false, "üser not found");

                user.status = Data.Enum.AccountStatus.Inactive;
                _dbContext.SaveChanges();
                return new ApiResponse(true, "Success");
            }
            return new ApiResponse(false, "You are not authorized to this action!");
        }

        public override ApiResponse unBlockUser(int adminId, int userId)
        {
            var admin = _dbContext.Users
             .FirstOrDefault(u => u.UID == adminId &&
             (u.userType.Equals(Data.Enum.UserType.Admin)));

            //var main = _dbContext.Maintainers.FirstOrDefault(m => m.userId == adminId && m.RoleId == 1);
            //if (admin == null && main == null) return new ApiResponse(false, "You are not admin!");

            var maintainer = _dbContext.Maintainers
                 .FirstOrDefault(m => m.userId == adminId && m.Role.Name == "User Manager");

            if (maintainer != null || admin != null)
            {
                var user = _dbContext.Users.FirstOrDefault(u => u.UID == userId);
                if (user == null)
                    return new ApiResponse(false, "üser not found");

                user.status = Data.Enum.AccountStatus.Active;
                _dbContext.SaveChanges();
                return new ApiResponse(true, "Success");
            }
            return new ApiResponse(false, "You are not authorized to this action!");
        }


        //acuti on & tender manager
        public override ApiResponse ViewAuction(int adminId)
        {
            var admin = _dbContext.Users
             .FirstOrDefault(u => u.UID == adminId &&
             (u.userType.Equals(Data.Enum.UserType.Admin)));

            //var main = _dbContext.Maintainers.FirstOrDefault(m => m.userId == adminId && m.RoleId == 4);
            //if (admin == null && main == null) return new ApiResponse(false, "You are not admin!");

            var maintainer = _dbContext.Maintainers
                 .FirstOrDefault(m => m.userId == adminId && m.Role.Name == "Tender & Auction Manager");

            if (maintainer != null || admin != null)
            {
                var auction = from mark in _dbContext.Marketers
                              join auct in _dbContext.Auctions on mark.Id equals auct.MarketerId
                              select new
                              {
                                  marketerName = mark.Name,
                                  auctionTitle = auct.Title,
                                  auctionDisc = auct.Discretion,
                                  startVal = auct.Value,
                                  auctionStat = auct.Status,
                                  finishDate = auct.FinalDate
                              };
                var auctions = auction.ToList();
                int count = auction.Count();

                return new ApiResponse(auctions, "Success", count);
            }
            return new ApiResponse(false, "You are not authorized to this action!");
        }

        public override ApiResponse CancelAuction(int adminId, int auctionId)
        {
            var admin = _dbContext.Users
             .FirstOrDefault(u => u.UID == adminId &&
             (u.userType.Equals(Data.Enum.UserType.Admin)));

            //var main = _dbContext.Maintainers.FirstOrDefault(m => m.userId == adminId && m.RoleId == 4);
            //if (admin == null && main == null) return new ApiResponse(false, "You are not admin!");

            var maintainer = _dbContext.Maintainers
                 .FirstOrDefault(m => m.userId == adminId && m.Role.Name == "Tender & Auction Manager");

            if (maintainer != null || admin != null)
            {
                var auction = _dbContext.Auctions.FirstOrDefault(a => a.Id == auctionId);
                if (auction == null)
                    return new ApiResponse(false, "not found");

                auction.Status = Data.Enum.AuctionTenderStatus.Canceled;
                _dbContext.SaveChanges();

                return new ApiResponse(true, "Success");
            }
            return new ApiResponse(false, "You are not authorized to this action!");
        }

        public override ApiResponse ViewTender(int adminId)
        {
            var admin = _dbContext.Users
             .FirstOrDefault(u => u.UID == adminId &&
             (u.userType.Equals(Data.Enum.UserType.Admin)));

            //var main = _dbContext.Maintainers.FirstOrDefault(m => m.userId == adminId && m.RoleId == 4);
            //if (admin == null && main == null) return new ApiResponse(false, "You are not admin!");

            var maintainer = _dbContext.Maintainers
                 .FirstOrDefault(m => m.userId == adminId && m.Role.Name == "Tender & Auction Manager");

            if (maintainer != null || admin != null)
            {
                var tender = from cust in _dbContext.Customers
                             join tend in _dbContext.Tenders on cust.Id equals tend.CustomerId
                             select new
                             {
                                 customerName = cust.FName + " " + cust.LName,
                                 TenderTitle = tend.Title,
                                 TenderDisc = tend.Discretion,
                                 startVal = tend.Value,
                                 TenderStat = tend.Status,
                                 finishDate = tend.FinalDate
                             };
                var tenders = tender.ToList();
                int count = tender.Count();

                return new ApiResponse(tenders, "Success", count);
            }
            return new ApiResponse(false, "You are not authorized to this action!");
        }

        public override ApiResponse CancelTender(int adminId, int tenderId)
        {
            var admin = _dbContext.Users
             .FirstOrDefault(u => u.UID == adminId &&
             (u.userType.Equals(Data.Enum.UserType.Admin)));

            //var main = _dbContext.Maintainers.FirstOrDefault(m => m.userId == adminId && m.RoleId == 4);
            //if (admin == null && main == null) return new ApiResponse(false, "You are not admin!");

            var maintainer = _dbContext.Maintainers
                 .FirstOrDefault(m => m.userId == adminId && m.Role.Name == "Tender & Auction Manager");

            if (maintainer != null || admin != null)
            {
                var tender = _dbContext.Tenders.FirstOrDefault(a => a.Id == tenderId);
                if (tender == null)
                    return new ApiResponse(false, "not found");

                tender.Status = Data.Enum.AuctionTenderStatus.Canceled;
                _dbContext.SaveChanges();

                return new ApiResponse(true, "Success");
            }
            return new ApiResponse(false, "You are not authorized to this action!");
        }

        //compl aint manager
        public override ApiResponse ViewComplaints(int adminId)
        {
            var admin = _dbContext.Users
                .FirstOrDefault(u => u.UID == adminId &&
                (u.userType.Equals(Data.Enum.UserType.Admin)));

            var maintainer = _dbContext.Maintainers
               .FirstOrDefault(m => m.userId == adminId && m.Role.Name == "Complaint Manager");


            //var main = _dbContext.Maintainers.FirstOrDefault(m => m.userId == adminId && m.RoleId == 2);
            //if (admin == null && main == null) return new ApiResponse(false, "You are not admin!");

            if (maintainer != null || admin != null)
            {
                var comp = from compl in _dbContext.Complaints
                           join user in _dbContext.Users on compl.ComplainerId equals user.UID
                           join post in _dbContext.Posts on compl.postId equals post.Id
                           join prod in _dbContext.Products on post.productId equals prod.id
                           join mark in _dbContext.Marketers on post.marketerId equals mark.Id
                           select new
                           {
                               Complainer = user.Name,
                               compl.Discretion,
                               productName = prod.Name,
                               mmarketerName = mark.Name,
                               compl.Status,
                               compl.Id,
                               compl.postId
                           };
                var complaints = comp.ToList();
                int count = comp.Count();

                return new ApiResponse(complaints, "Success", count);
            }
            return new ApiResponse(false, "You are not authorized to this action!");
        }

        public override ApiResponse DeleteComplaint(int adminId, int complaintId)
        {
            var admin = _dbContext.Users
               .FirstOrDefault(u => u.UID == adminId &&
               (u.userType.Equals(Data.Enum.UserType.Admin)));

            //var main = _dbContext.Maintainers.FirstOrDefault(m => m.userId == adminId && m.RoleId == 2);
            //if (admin == null && main == null) return new ApiResponse(false, "You are not admin!");

            var maintainer = _dbContext.Maintainers
                 .FirstOrDefault(m => m.userId == adminId && m.Role.Name == "Complaint Manager");

            if (maintainer != null || admin != null)
            {
                var complaint = _dbContext.Complaints.FirstOrDefault(c => c.Id == complaintId);
                if (complaint == null)
                    return new ApiResponse(false, "not found");

                _dbContext.Complaints.Remove(complaint);
                _dbContext.SaveChanges();

                return new ApiResponse(true, "Success");
            }
            return new ApiResponse(false, "You are not authorized to this action!");
        }

        public override ApiResponse ReplayComplaint(int adminId, int complaintId, AddNotificationViewModel notificationViewModel)
        {
            var admin = _dbContext.Users
             .FirstOrDefault(u => u.UID == adminId &&
             (u.userType.Equals(Data.Enum.UserType.Admin)));

            //var main = _dbContext.Maintainers.FirstOrDefault(m => m.userId == adminId && m.RoleId == 2);
            //if (admin == null && main == null) return new ApiResponse(false, "You are not admin!");

            var maintainer = _dbContext.Maintainers
                 .FirstOrDefault(m => m.userId == adminId && m.Role.Name == "Complaint Manager");

            if (maintainer != null || admin != null)
            {
                var complaint = _dbContext.Complaints.FirstOrDefault(c => c.Id == complaintId);
                if (complaint == null)
                    return new ApiResponse(false, "not found");

                var notify = new Notification
                {
                    Body = notificationViewModel.Body,
                    RecieverId = complaint.ComplainerId,
                    SenderId = adminId,
                    notifyType = Data.Enum.NotifyType.Normal
                };
                _dbContext.Notifications.Add(notify);
                _dbContext.SaveChanges();

                return new ApiResponse(true, "Success");
            }
            return new ApiResponse(false, "You are not authorized to this action!");
        }

        // popu lar manager
        public override ApiResponse ViewPopularization(int adminId)
        {
            var admin = _dbContext.Users
              .FirstOrDefault(u => u.UID == adminId &&
              (u.userType.Equals(Data.Enum.UserType.Admin)));

            //var main = _dbContext.Maintainers.FirstOrDefault(m => m.userId == adminId && m.RoleId == 3);
            //if (admin == null && main == null) return new ApiResponse(false, "You are not admin!");

            var maintainer = _dbContext.Maintainers
                 .FirstOrDefault(m => m.userId == adminId && m.Role.Name == "Popularization Manager");

            if (maintainer != null || admin != null)
            {
                var popular = from pop in _dbContext.Popularizations
                              join mark in _dbContext.Marketers on pop.marketerId equals mark.Id
                              join prod in _dbContext.Products on pop.productId equals prod.id
                              select new
                              {
                                  Productname = prod.Name,
                                  Storename = mark.Name,
                                  zone = pop.targetzone,
                                  targetgender = pop.targetGender,
                                  description = pop.Description,
                                  targetAge = "from agr " + pop.fromAge + " to age " + pop.toAge,
                                  pop.Id
                              };
                var popularization = popular.ToList();
                int count = popular.Count();

                return new ApiResponse(popularization, "Success", count);
            }
            return new ApiResponse(false, "You are not authorized to this action!");
        }

        public override ApiResponse UnAcceptPopularization(int adminId, int popularizationId)
        {
            var admin = _dbContext.Users
             .FirstOrDefault(u => u.UID == adminId &&
             (u.userType.Equals(Data.Enum.UserType.Admin)));

            //var main = _dbContext.Maintainers.FirstOrDefault(m => m.userId == adminId && m.RoleId == 3);
            //if (admin == null && main == null) return new ApiResponse(false, "You are not admin!");
            var maintainer = _dbContext.Maintainers
                 .FirstOrDefault(m => m.userId == adminId && m.Role.Name == "Popularization Manager");

            if (maintainer != null || admin != null)
            {
                var popular = _dbContext.Popularizations.FirstOrDefault(p => p.Id == popularizationId);
                if (popular == null)
                    return new ApiResponse(false, "not found");

                popular.status = Data.Enum.PopularizationStatus.Unacceptable;
                _dbContext.SaveChanges();

                return new ApiResponse(true, "Success");
            }
            return new ApiResponse(false, "You are not authorized to this action!");
        }

        public override ApiResponse AcceptPopularization(int adminId, int popularizationId)
        {
            var admin = _dbContext.Users
             .FirstOrDefault(u => u.UID == adminId &&
             (u.userType.Equals(Data.Enum.UserType.Admin)));
            //var main = _dbContext.Maintainers.FirstOrDefault(m => m.userId == adminId && m.RoleId == 3);
            //if (admin == null && main == null) return new ApiResponse(false, "You are not admin!");
            var maintainer = _dbContext.Maintainers
                 .FirstOrDefault(m => m.userId == adminId && m.Role.Name == "Popularization Manager");

            if (maintainer != null || admin != null)
            {
                var popular = _dbContext.Popularizations.FirstOrDefault(p => p.Id == popularizationId);
                if (popular == null)
                    return new ApiResponse(false, "not found");
                var mark = _dbContext.Marketers.FirstOrDefault(m => m.Id == popular.marketerId);
                if (mark == null) return new ApiResponse(false, "marketer not found");
                popular.status = Data.Enum.PopularizationStatus.Acceptance;

                var notify = new Notification
                {
                    Body = "Admin accepted your popularzation!",
                    SenderId = adminId,
                    RecieverId = mark.userId,
                    notifyType = Data.Enum.NotifyType.Normal,
                    CreatedDate = DateTime.Now
                };
                _dbContext.Notifications.Add(notify);
                _dbContext.SaveChanges();

                _dbContext.SaveChanges();


                return new ApiResponse(true, "Success");
            }
            return new ApiResponse(false, "You are not authorized to this action!");
        }


    }
}
