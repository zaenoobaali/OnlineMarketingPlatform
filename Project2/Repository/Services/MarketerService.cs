using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Project2.DTOs.MarketerDTOs;
using Project2.Model;
using Project2.Model.Entities;
using Project2.Model.Helpers;
using Project2.Repository.Interfaces;
using System.Reflection;

namespace Project2.Repository.Services
{
    public class MarketerService : IMarketerService
    {
        public AppDbContext _DbContext { get; set; }
        private IMapper _Mapper;

        public MarketerService(AppDbContext DbContext, IMapper Mapper)
        {
            _DbContext = DbContext;
            _Mapper = Mapper;
        }
        //public override ApiResponse GetAllMarketers(ComplexFilter Filter)
        //{
        //    List<MarketerViewModel> Marketers = _Mapper.Map<List<MarketerViewModel>>(_DbContext.Marketers
        //        .Include(x => x.User)
        //        .Where(x => (!string.IsNullOrEmpty(Filter.SearchQuery) ?
        //            x.User.Name.ToLower().StartsWith(Filter.SearchQuery) : true)).ToList());

        //    int Count = Marketers.Count();

        //    if (!string.IsNullOrEmpty(Filter.Sort))
        //    {
        //        PropertyInfo? SortProperty = typeof(MarketerViewModel).GetProperty(Filter.Sort);

        //        if (SortProperty != null && Filter.Order == "asc")
        //            Marketers = Marketers.OrderBy(x => SortProperty.GetValue(x)).ToList();

        //        else if (SortProperty != null && Filter.Order == "desc")
        //            Marketers = Marketers.OrderByDescending(x => SortProperty.GetValue(x)).ToList();

        //        Marketers = Marketers.Skip((Filter.PageIndex - 1) * Filter.PageSize)
        //            .Take(Filter.PageSize).ToList();
        //    }
        //    else
        //        Marketers = Marketers.Skip((Filter.PageIndex - 1) * Filter.PageSize)
        //            .Take(Filter.PageSize).ToList();

        //    return new ApiResponse(Marketers, "Success", Count);

        //}

        public override ApiResponse AddPoint(int userId, AddPointViewModel Points)
        {
            var marketer = _DbContext.Marketers.FirstOrDefault(m => m.userId == userId);
            if (marketer == null) return new ApiResponse(false, "marketer not found");
            var user = _DbContext.Users.FirstOrDefault(u => u.UID == userId);
            if (user == null) return new ApiResponse(false, "user not found");

            //var user = _DbContext.Users.FirstOrDefault(u => u.UserName == "admin");
            //if (user == null) return new ApiResponse(false, "user not found");

            int pointCost = Points.points * 100;

            if (user.Billfold < pointCost) return new ApiResponse(false, "you dont have enough !");

            var point = new PointRequest
            {
                marketerId = marketer.Id,
                pointsAmount = Points.points,
                pointsPrice = pointCost,
                status = Data.Enum.PopularizationStatus.None
            };

            _DbContext.PointRequests.Add(point);
            _DbContext.SaveChanges();


            return new ApiResponse(true, "Success");
        }

        public override ApiResponse AllMarketers()
        {
            var marketer = from market in _DbContext.Marketers
                           join user in _DbContext.Users on market.userId equals user.UID
                           select new
                           {
                               market.photo,
                               market.Name,
                               market.userId
                           };


            var markters = marketer.ToList();
            int count = marketer.Count();

            return new ApiResponse(markters, "Success", count);
        }
    }
}
