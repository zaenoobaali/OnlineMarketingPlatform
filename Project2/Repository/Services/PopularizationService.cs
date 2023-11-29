using Project2.DTOs.PopularizationDTOs;
using Project2.Model;
using Project2.Model.Entities;
using Project2.Model.Helpers;
using Project2.Repository.Interfaces;

namespace Project2.Repository.Services
{
    public class PopularizationService : IPopularizationService
    {
        public AppDbContext _dbContext { get; set; }

        public PopularizationService (AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public override ApiResponse CreatePopularization(int userId, AddPopularizationViewModel addPopularization)
        {
            var markter = _dbContext.Marketers.FirstOrDefault(m => m.userId == userId);
            if (markter == null) return new ApiResponse(false, "markter not found 😶");
            var prod = _dbContext.Products.FirstOrDefault(p => p.Name == addPopularization.productname);
            if (prod == null) return new ApiResponse(false, "you dont have this product 😴");

            var popular = new Popularization
            {
                marketerId = markter.Id,
                productId = prod.id,
                Description = addPopularization.Description,
                targetGender = addPopularization.targetGender,
                targetzone = addPopularization.targetzone,
                fromAge = addPopularization.fromAge,
                toAge = addPopularization.toAge,
                status = Data.Enum.PopularizationStatus.None,
                CreatedDate = DateTime.Now
            };

            _dbContext.Popularizations.Add(popular);
            _dbContext.SaveChanges();

            return new ApiResponse(true , "Success");
        }

        public override ApiResponse PopularizationDetails(int PopularizationId)
        {
            var popular = from pop in _dbContext.Popularizations
                          join mark in _dbContext.Marketers on pop.marketerId equals mark.Id
                          join prod in _dbContext.Products on pop.productId equals prod.id
                          where pop.Id == PopularizationId
                          select new
                          {
                              markname = mark.Name,
                              prodname = prod.Name,
                              des = pop.Description,
                              Tgender = pop.targetGender,
                              Tzone = pop.targetzone,
                              AgeBetween = pop.fromAge + " - " + pop.toAge
                          };

            var popularzation = popular.ToList();

            return new ApiResponse(popularzation , "Success",popular.Count());
        }

        public override ApiResponse GetPopularization(int userId)
        {
            var cust = _dbContext.Customers.FirstOrDefault(c => c.userId == userId);
            if (cust == null) return new ApiResponse(false , "not found");

            var popular = from pop in _dbContext.Popularizations
                          join mark in _dbContext.Marketers on pop.marketerId equals mark.Id
                          join prod in _dbContext.Products on pop.productId equals prod.id
                          where (pop.fromAge < cust.age && pop.toAge > cust.age) && 
                            (pop.targetzone == cust.zone || pop.targetzone == cust.city) &&
                            (pop.targetGender == cust.gender) &&
                            (pop.status == Data.Enum.PopularizationStatus.Acceptance)
                          select new
                          {
                              markname = mark.Name,
                              prodphoto = prod.photo,
                              prodname = prod.Name,
                              pop.Id
                          };

            var popularzation = popular.ToList();

            return new ApiResponse(popularzation, "Success",popular.Count());
        }
    }
}
