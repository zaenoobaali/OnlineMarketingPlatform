using Microsoft.EntityFrameworkCore;
using Project2.DTOs.NotifyDTOs;
using Project2.Model;
using Project2.Model.Entities;
using Project2.Model.Helpers;
using Project2.Repository.Interfaces;

namespace Project2.Repository.Services
{
    public class SearchService : ISearchService
    {
        public AppDbContext _dbContext { get; set; }
        public SearchService(AppDbContext DbContext)
        {
            _dbContext = DbContext;
        }
    
        public override ApiResponse ViewSearchList(int userId)
        {
            var search = from ser in _dbContext.Searches
                         where ser.userId == userId
                         select new
                         {
                             ser.Title,
                             ser.Id
                         };
            var searches = search.ToList();
            if (searches == null)
                return new ApiResponse(false, "notFound");

            return new ApiResponse(searches, "Success");
        }
  
        public override ApiResponse AddSearch(int userId, AddSearchViewModel addSearch)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.UID == userId);

            if (user == null)
                return new ApiResponse(false,"not found");

            var search = new Search
            {
                Title = addSearch.Title,
                userId = userId,
                CreatedDate = DateTime.Now
            };

            _dbContext.Searches.Add(search);
            _dbContext.SaveChanges();

            var name = addSearch.Title;

            var users =from usr in _dbContext.Customers
                where usr.FName == name || usr.UserName == name
                select new
                {
                    name = usr.FName +" "+ usr.LName,
                    Cphoto = usr.photo,
                    usr.userId
                    
                };
            var markterusers = from mark in _dbContext.Marketers
                               where mark.Name == name || mark.UserName == name
                               select new
                               {
                                   name = mark.Name,
                                   Mphoto = mark.photo,
                                   mark.userId
                               };
            var deliverusers = from deliver in _dbContext.Delivers
                               where deliver.Name == name || deliver.UserName == name
                               select new
                               {
                                   name = deliver.Name,
                                   Dphoto = deliver.photo,
                                   deliver.userId
                               };
            if (users == null)
                return new ApiResponse(false, "customers not found");

            var products = from prod in _dbContext.Posts
                           join p in _dbContext.Products on prod.productId equals p.id
                           join mar in _dbContext.Marketers on prod.marketerId equals mar.Id
                           where (p.productType == name || p.Name == name) && prod.status == Data.Enum.PostStatus.Public
                           select new
                           {
                               Pphoto = p.photo,
                               prodName = p.Name,
                               MarketerName = mar.Name,
                               Desc = prod.Description,
                               prod.Id
                           };

            if (user.userType.Equals(Data.Enum.UserType.Customer) ||
                user.userType.Equals(Data.Enum.UserType.Admin)) 
            {
                var searchresultc = new
                {
                    customer = users.ToList(),
                    marketer = markterusers.ToList(),
                    deliver = deliverusers.ToList(),
                    product = products.ToList()
                };
                return new ApiResponse(searchresultc, "Success");
            }
            else if (user.userType.Equals(Data.Enum.UserType.Marketer)) 
            {
                var searchresultm = new
                {
                    marketer = markterusers.ToList(),
                    deliver = deliverusers.ToList(),
                    product = products.ToList()
                };
                return new ApiResponse(searchresultm, "Success");
            }
            else if (user.userType.Equals(Data.Enum.UserType.Deliver))
            {
                var searchresultd = new
                {
                    marketer = markterusers.ToList(),
                    deliver = deliverusers.ToList()
                }; 
                return new ApiResponse(searchresultd, "Success");
            }
            
            return new ApiResponse(false, "fail");
        }

        public override ApiResponse DeleteSearch(int userId, int searchId)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.UID == userId);
            if (user == null)
                return new ApiResponse(false, "notFound");
            var search = _dbContext.Searches
                .FirstOrDefault(s => s.Id == searchId & s.userId == userId);
            if (search == null)
                return new ApiResponse(false, "notFound");

            _dbContext.Searches.Remove(search);
            _dbContext.SaveChanges();

            return new ApiResponse(search, "Success");
        }
    }
}
